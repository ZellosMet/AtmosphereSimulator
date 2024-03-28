using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace AtmosphereControl
{
	public partial class Simulation : Form
	{
		List<double> chart_temperature_list = new List<double>();		//Список значений для графика температуры 
		List<double> chart_pressure_list = new List<double>();			//Список значений для графика давления
		List<double> chart_oxygen_list = new List<double>();			//Список значений для графика состава вещества(О2)
		List<double> chart_nitrogen_list = new List<double>();			//Список значений для графика состава вещества(N2)
		List<double> chart_carbon_diaxide_list = new List<double>();    //Список значений для графика состава вещества(СО2)
		double max_T, min_T, max_P, min_P, max_O2, min_O2, max_N2, min_N2, max_CO2, min_CO2;    //Минимальные и максимальные значени													
		byte select_chart = 0;											//Активный график для отображения развёрнутого варианта
		static Atmosphere atmosphere;									//Объект атмосферы
		static Automation automation;									//Объект автоматики
		static Devices devices;											//Объект устройств
		static Astronauts astronauts;									//Объект космонавт
		public Simulation()
		{
			//CreateAtmosphere create_atmosphere = new CreateAtmosphere();
			//create_atmosphere.ShowDialog();

			InitializeComponent();
			//Инициализация объектов
			atmosphere = new Atmosphere();
			automation = new Automation(atmosphere);
			devices = new Devices(atmosphere);
			astronauts = new Astronauts(atmosphere);

			//Заполнение списков для графиков
			FillList();

			//Настройка акцис графиков
			cht_MiniTemperature.ChartAreas[0].AxisY.Maximum = 60;
			cht_MiniTemperature.ChartAreas[0].AxisY.Minimum = 0;
			cht_MiniPressure.ChartAreas[0].AxisY.Maximum = 110;
			cht_MiniPressure.ChartAreas[0].AxisY.Minimum = 90;
			cht_MiniAmountSubstance.ChartAreas[0].AxisY.Maximum = 100;
			cht_MiniAmountSubstance.ChartAreas[0].AxisY.Minimum = 0;
			cht_FullChart.ChartAreas[0].AxisY.Maximum = 60;
			cht_FullChart.ChartAreas[0].AxisY.Minimum = 0;

			l_RoomVolume.Text = $"Объём помещения {atmosphere.RoomVolume} м3";
			l_Conditioner.Text = "Кондиционер не активен";
			l_DevicesTemperature.Text = $"Температура устройств {devices.CurrentTemperature} С";
			l_NumberOfAstronauts.Text = $"Всего космонавтов: {astronauts.GetCountAstronauts}";
			t_RefreshData.Start();
			t_RefreshInfo.Start();
		}
		//Метод расчёта теплообменя атмосферы
		double HeatExchange()
		{
			double coefficient_heat_exchange = 1.16;
			return Math.Round(((coefficient_heat_exchange * devices.DeviceSurfaceArea * Math.Abs(atmosphere.Temperature - devices.CurrentTemperature))/11.6), 2);
		}
		//Евент обновления данных атмосферы по времени
		private void RefreshData_Tick(object sender, EventArgs e)
		{
			//Расчёт изменения состава вещества
			atmosphere.AmountOfOxygen -= astronauts.ConsumptionOxygen * astronauts.GetCountAstronauts;
			atmosphere.AmountOfNitrogen -= astronauts.ConsumptionNitrogen * astronauts.GetCountAstronauts;
			atmosphere.AmountOfCarbonDiaxide = (atmosphere.AmountOfCarbonDiaxide - astronauts.ConsumptionCarbonDiaxide * astronauts.GetCountAstronauts) + Astronauts.AtmosphereConsumption();
			atmosphere.GasPreassureFrom();

			automation.ScanAtmosphere(); //Сканирование атмосферы
			//Контроль температуры
			if (atmosphere.Temperature < automation.TargetTemperature && automation.ConditionerActive)
			{ 
				atmosphere.Temperature += Math.Abs(HeatExchange() + automation.PowerConditioner);
				atmosphere.GasPreassureFrom();
			}
			if (atmosphere.Temperature > automation.TargetTemperature && automation.ConditionerActive)
			{
				atmosphere.Temperature -= Math.Abs(HeatExchange() - automation.PowerConditioner);
				atmosphere.GasPreassureFrom();
			}
			//Контроль давления
			if (atmosphere.Pressure > automation.MaxTargetPressure && automation.VentilationActive)
			{ 
				atmosphere.Pressure -= automation.PowerVentilation;
				atmosphere.GasPreassureFrom();
			}
			if (atmosphere.Pressure < automation.MinTargetPressure && automation.VentilationActive)
			{ 
				atmosphere.Pressure += automation.PowerVentilation;
				atmosphere.GasPreassureFrom();
			}
			//Продувка атмосферы
			if (atmosphere.GetCarbonDiaxideInPercent > automation.TargetCarbonDiaxide && automation.VentilationActive)
				automation.AtmosphereFlow();
			//Нагрев оборудования
			if (devices.DevicesActive)
			{
				devices.OverclokingDevices();
				atmosphere.Temperature += HeatExchange() - automation.PowerConditioner;
			}
			else if (devices.CurrentTemperature > atmosphere.Temperature && !devices.DevicesActive)			
				devices.CurrentTemperature--;			
		}
		//Евент запуска оборудования
		private void cb_DeviceActive_CheckedChanged(object sender, EventArgs e)
		{
			if (cb_DeviceActive.Checked == true) devices.StartDevices();
			else devices.StopDevices();
		}
		//Асинхронный запуск эвента обновления информации
		private async void t_Info_Tick(object sender, EventArgs e)
		{
			await Task.Run(() => info());
		}
		//Метод обновления информации
		void info()
		{
			//Заполнение лейблов
			l_O2.BeginInvoke((MethodInvoker)(() => l_O2.Text = "O2 - " + Math.Round((atmosphere.GetOxygenInPercent), 2) + " %"));
			l_N2.BeginInvoke((MethodInvoker)(() => l_N2.Text = "N2 - " + Math.Round(atmosphere.GetNitrogenInPercent, 2) + " %"));
			l_CO2.BeginInvoke((MethodInvoker)(() => l_CO2.Text = "СО2 - " + Math.Round(atmosphere.GetCarbonDiaxideInPercent, 2) + " %"));
			temperature.BeginInvoke((MethodInvoker)(() => temperature.Text  = "Температура " + Math.Round(atmosphere.Temperature, 2) + " С"));
			l_DevicesTemperature.BeginInvoke((MethodInvoker)(() => l_DevicesTemperature.Text = "Температура устройств " + Math.Round(devices.CurrentTemperature, 2) + " С"));
			pressure.BeginInvoke((MethodInvoker)(() => pressure.Text = "Давление " + Math.Round(atmosphere.Pressure/1000, 2) + " КПа"));			
			l_Conditioner.BeginInvoke((MethodInvoker)(() => l_Conditioner.Text = automation.ConditionerActive ? "Кондиционер активен" : "Кондиционер не активен"));
			l_Ventilation.BeginInvoke((MethodInvoker)(() => l_Ventilation.Text = automation.VentilationActive ? "Вентеляция активена" : "Вентеляция не активена"));
			
			//Перерисовка графика температуры(мини)
			chart_temperature_list.RemoveAt(0);
			chart_temperature_list.Add(atmosphere.Temperature);
			cht_MiniTemperature.BeginInvoke((MethodInvoker)delegate{ DrawChart(cht_MiniTemperature, chart_temperature_list); });
			//Перерисовка графика давления(мини)
			chart_pressure_list.RemoveAt(0);
			chart_pressure_list.Add(atmosphere.Pressure/1000);
			cht_MiniPressure.BeginInvoke((MethodInvoker)delegate{ DrawChart(cht_MiniPressure, chart_pressure_list); });
			//Перерисовка графика состава вещества(мини)
			chart_oxygen_list.RemoveAt(0);
			chart_nitrogen_list.RemoveAt(0);
			chart_carbon_diaxide_list.RemoveAt(0);
			chart_oxygen_list.Add(atmosphere.GetOxygenInPercent);
			chart_nitrogen_list.Add(atmosphere.GetNitrogenInPercent);
			chart_carbon_diaxide_list.Add(atmosphere.GetCarbonDiaxideInPercent);
			cht_MiniAmountSubstance.BeginInvoke((MethodInvoker)delegate{ DrawChart(cht_MiniAmountSubstance, chart_oxygen_list, chart_nitrogen_list, chart_carbon_diaxide_list); });
			//Выбор графика полной версии 
			switch (select_chart)
			{
				case 0:
					{ 
						cht_FullChart.BeginInvoke((MethodInvoker)delegate { DrawChart(cht_FullChart, chart_temperature_list); });
						max_T = max_T > chart_temperature_list.Max()? max_T : chart_temperature_list.Max();
						min_T = min_T > chart_temperature_list.Min()? min_T : chart_temperature_list.Min();
						l_Info.BeginInvoke((MethodInvoker)(() => l_Info.Text = $"Температура\n   Максимальная: {Math.Round(max_T,2)}\n   Минимальная: {Math.Round(min_T,2)}\n   Средняя {Math.Round(chart_temperature_list.Average(), 2)}"));
					}
				break;
				case 1:
					{ 
						cht_FullChart.BeginInvoke((MethodInvoker)delegate { DrawChart(cht_FullChart, chart_pressure_list); }); 
						max_P = max_P > chart_pressure_list.Max() ? max_P : chart_pressure_list.Max();
						min_P = min_P > chart_pressure_list.Min() ? min_P : chart_pressure_list.Min();
						l_Info.BeginInvoke((MethodInvoker)(() => l_Info.Text = $"Давление\n   Максимальное: {Math.Round(max_P, 2)}\n   Минимальное: {Math.Round(min_P, 2)}\n   Среднее {Math.Round(chart_pressure_list.Average(), 2)}"));
					}
				break;
				case 2:
					{ 
						cht_FullChart.BeginInvoke((MethodInvoker)delegate { DrawChart(cht_FullChart, chart_oxygen_list, chart_nitrogen_list, chart_carbon_diaxide_list); });
						max_O2 = max_O2 > chart_oxygen_list.Max() ? max_O2 : chart_oxygen_list.Max();
						min_O2 = min_O2 > chart_oxygen_list.Min() ? min_O2 : chart_oxygen_list.Min();
						max_N2 = max_N2 > chart_nitrogen_list.Max() ? max_N2 : chart_nitrogen_list.Max();
						min_N2 = min_N2 > chart_nitrogen_list.Min() ? min_N2 : chart_nitrogen_list.Min();
						max_CO2 = max_CO2 > chart_carbon_diaxide_list.Max() ? max_CO2 : chart_carbon_diaxide_list.Max();
						min_CO2 = min_CO2 > chart_carbon_diaxide_list.Min() ? min_CO2 : chart_carbon_diaxide_list.Min();
						l_Info.BeginInvoke((MethodInvoker)(() => l_Info.Text = $@"Состав атмосферы
						   Максимальное O2: {Math.Round(max_O2, 2)}   Максимальное N2: {Math.Round(max_N2, 2)}   Максимальное СО2 {Math.Round(max_CO2, 2)}
						   Минимальное O2: {Math.Round(min_O2, 2)}   Минимально N2: {Math.Round(min_N2, 2)}   Минимально СО2 {Math.Round(min_CO2, 2)}
						   Среднее O2: {Math.Round(chart_oxygen_list.Average(), 2)}   Среднее N2: {Math.Round(chart_nitrogen_list.Average(), 2)}   Среднее СО2 {Math.Round(chart_carbon_diaxide_list.Average(), 2)}
						"));
					}
				break;
			}			
		}
		//Метод заполнения данных для графиклв
		void FillList()
		{
			for (int i = 0; i < 60; i++)
			{
				chart_temperature_list.Add(0);
				chart_pressure_list.Add(0);
				chart_oxygen_list.Add(0);
				chart_nitrogen_list.Add(0);
				chart_carbon_diaxide_list.Add(0);
			}
		}
		//Метод отрисовки графиков(одна линия)
		void DrawChart(Chart chart, List<double> list)
		{
			chart.Series[0].Points.Clear();
			int x = 0;
			while (x <= list.Count - 1)
			{ 
				chart.Series[0].Points.AddXY(x + 1, list[x]);
				x++;
			}
		}
		//Перегрузка метода отрисовки графиков(три линии)
		void DrawChart(Chart chart, List<double> list1, List<double> list2, List<double> list3)
		{
			chart.Series[0].Points.Clear();
			chart.Series[1].Points.Clear();
			chart.Series[2].Points.Clear();
			int x = 0;
			while (x <= list1.Count - 1)
			{
				chart.Series[0].Points.AddXY(x + 1, list1[x]);
				chart.Series[1].Points.AddXY(x + 1, list2[x]);
				chart.Series[2].Points.AddXY(x + 1, list3[x]);
				x++;
			}
		}
		//Эвент добавлени космонавта
		private void b_AddAstronaut_Click(object sender, EventArgs e)
		{
			astronauts.AddAstronauts();
			l_NumberOfAstronauts.Text = $"Всего космонавтов: {astronauts.GetCountAstronauts}";
		}
		//Эвент удаления космонавта
		private void b_RemoveAstronaut_Click(object sender, EventArgs e)
		{
			astronauts.RemoveAstronauts();
			l_NumberOfAstronauts.Text = $"Всего космонавтов: {astronauts.GetCountAstronauts}";
		}
		//Перенастройка графика полной версии для температуры
		private void cht_MiniTemperature_Click(object sender, EventArgs e)
		{
			cht_FullChart.ChartAreas[0].AxisY.Maximum = 60;
			cht_FullChart.ChartAreas[0].AxisY.Minimum = 0;
			cht_FullChart.Series[1].Points.Clear();
			cht_FullChart.Series[2].Points.Clear();
			select_chart = 0;
		}
		//Перестройка графика полной версии для давления
		private void cht_MiniPressure_Click(object sender, EventArgs e)
		{
			cht_FullChart.ChartAreas[0].AxisY.Maximum = 110;
			cht_FullChart.ChartAreas[0].AxisY.Minimum = 90;
			cht_FullChart.Series[1].Points.Clear();
			cht_FullChart.Series[2].Points.Clear();
			select_chart = 1;
		}
		//Перестройка график полной версии для составва вещества
		private void cht_MiniAmountSubstance_Click(object sender, EventArgs e)
		{
			cht_FullChart.ChartAreas[0].AxisY.Maximum = 100;
			cht_FullChart.ChartAreas[0].AxisY.Minimum = 0;
			select_chart = 2;
		}
	}
}
