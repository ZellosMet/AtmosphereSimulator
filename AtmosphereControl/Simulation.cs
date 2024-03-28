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
		List<double> chart_temperature_list = new List<double>();
		List<double> chart_pressure_list = new List<double>();
		List<double> chart_oxygen_list = new List<double>();
		List<double> chart_nitrogen_list = new List<double>();
		List<double> chart_carbon_diaxide_list = new List<double>();
		double max_T;
		double min_T;
		double max_P;
		double min_P;
		byte select_chart = 0;
		static Atmosphere atmosphere;
		static Automation automation;
		static Devices devices;
		static Astronauts astronauts;
		public Simulation()
		{
			InitializeComponent();
			atmosphere = new Atmosphere();
			automation = new Automation(atmosphere);
			devices = new Devices(atmosphere);
			astronauts = new Astronauts(atmosphere);
		}
		double HeatExchange()
		{
			double coefficient_heat_exchange = 1.16;
			return Math.Round(((coefficient_heat_exchange * devices.DeviceSurfaceArea * Math.Abs(atmosphere.Temperature - devices.CurrentTemperature))/11.6), 2);
		}

		public void Form1_Load(object sender, EventArgs e)
		{
			FillList();

			cht_MiniTemperature.ChartAreas[0].AxisY.Maximum = 60;
			cht_MiniTemperature.ChartAreas[0].AxisY.Minimum = 0;

			cht_MiniPressure.ChartAreas[0].AxisY.Maximum = 110;
			cht_MiniPressure.ChartAreas[0].AxisY.Minimum = 90;

			cht_MiniAmountSubstance.ChartAreas[0].AxisY.Maximum = 100;
			cht_MiniAmountSubstance.ChartAreas[0].AxisY.Minimum = 0;

			cht_FullChart.ChartAreas[0].AxisY.Maximum = 60;
			cht_FullChart.ChartAreas[0].AxisY.Minimum = 0;

			amount_of_oxygen.Text = "Количество кислорода\n" + Convert.ToString(atmosphere.AmountOfOxygen) + " моль";
			amount_of_nitrogen.Text = "Количество азота\n" + Convert.ToString(atmosphere.AmountOfNitrogen) + " моль";
			amount_of_carbon_diaxide.Text = "Количество СО2\n" + Convert.ToString(atmosphere.AmountOfCarbonDiaxide) + " моль";
			pressure.Text = "Давление\n" + Convert.ToString(atmosphere.Pressure) + " Па";
			temperature.Text = "Температура\n" + Convert.ToString(atmosphere.Temperature) + " С";
			room_volume.Text = "Объём помещения " + Convert.ToString(atmosphere.RoomVolume) + " м3";
			Conditioner.Text = "Кондиционер не активен";
			DevicesTemperature.Text = $"Температура устройств {devices.CurrentTemperature} С";
			l_NumberOfAstronauts.Text = $"Всего космонавтов: {astronauts.GetCountAstronauts}";
			timer1.Start();
			t_Info.Start();
		}
		private void numericUpDown1_ValueChanged(object sender, EventArgs e)
		{
			atmosphere.GasPreassureFrom();
			temperature.Text = "Температура\n" + Convert.ToString(atmosphere.Temperature) + " С";
			pressure.Text = "Давление\n" + Convert.ToString(atmosphere.Pressure) + " Па";
		}

		private void timer1_Tick(object sender, EventArgs e)
		{
			atmosphere.AmountOfOxygen -= astronauts.ConsumptionOxygen * astronauts.GetCountAstronauts;
			atmosphere.AmountOfNitrogen -= astronauts.ConsumptionNitrogen * astronauts.GetCountAstronauts;
			atmosphere.AmountOfCarbonDiaxide = (atmosphere.AmountOfCarbonDiaxide - astronauts.ConsumptionCarbonDiaxide * astronauts.GetCountAstronauts) + Astronauts.AtmosphereConsumption();
			atmosphere.GasPreassureFrom();

			automation.ScanAtmosphere();
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

			if (atmosphere.GetCarbonDiaxideInPercent > automation.TargetCarbonDiaxide && automation.VentilationActive)
				automation.AtmosphereFlow();

			if (devices.DevicesActive)
			{
				devices.OverclokingDevices();
				atmosphere.Temperature += HeatExchange() - automation.PowerConditioner;
			}
			else if (devices.CurrentTemperature > atmosphere.Temperature && !devices.DevicesActive)			
				devices.CurrentTemperature--;			
		}

		private void checkBox1_CheckedChanged(object sender, EventArgs e)
		{
			if (checkBox1.Checked == true) devices.StartDevices();
			else devices.StopDevices();
		}
		private async void t_Info_Tick(object sender, EventArgs e)
		{
			await Task.Run(() => info());
		}
		void info()
		{
			amount_of_oxygen.BeginInvoke((MethodInvoker)(() => amount_of_oxygen.Text = "O2 - " + Math.Round((atmosphere.GetOxygenInPercent), 2) + " %"));
			amount_of_nitrogen.BeginInvoke((MethodInvoker)(() => amount_of_nitrogen.Text = "N2 - " + Math.Round(atmosphere.GetNitrogenInPercent, 2) + " %"));
			amount_of_carbon_diaxide.BeginInvoke((MethodInvoker)(() => amount_of_carbon_diaxide.Text = "СО2 - " + Math.Round(atmosphere.GetCarbonDiaxideInPercent, 2) + " %"));
			temperature.BeginInvoke((MethodInvoker)(() => temperature.Text  = "Температура " + Math.Round(atmosphere.Temperature, 2) + " С"));
			DevicesTemperature.BeginInvoke((MethodInvoker)(() => DevicesTemperature.Text = "Температура устройств " + Math.Round(devices.CurrentTemperature, 2) + " С"));
			pressure.BeginInvoke((MethodInvoker)(() => pressure.Text = "Давление " + Convert.ToString(atmosphere.Pressure/1000) + " КПа"));			
			Conditioner.BeginInvoke((MethodInvoker)(() => Conditioner.Text = automation.ConditionerActive ? "Кондиционер активен" : "Кондиционер не активен"));
			l_ventilation.BeginInvoke((MethodInvoker)(() => l_ventilation.Text = automation.VentilationActive ? "Вентеляция активена" : "Вентеляция не активена"));

			chart_temperature_list.RemoveAt(0);
			chart_temperature_list.Add(atmosphere.Temperature);
			cht_MiniTemperature.BeginInvoke((MethodInvoker)delegate{ DrawChart(cht_MiniTemperature, chart_temperature_list); });

			chart_pressure_list.RemoveAt(0);
			chart_pressure_list.Add(atmosphere.Pressure/1000);
			cht_MiniPressure.BeginInvoke((MethodInvoker)delegate{ DrawChart(cht_MiniPressure, chart_pressure_list); });

			chart_oxygen_list.RemoveAt(0);
			chart_nitrogen_list.RemoveAt(0);
			chart_carbon_diaxide_list.RemoveAt(0);
			chart_oxygen_list.Add(atmosphere.GetOxygenInPercent);
			chart_nitrogen_list.Add(atmosphere.GetNitrogenInPercent);
			chart_carbon_diaxide_list.Add(atmosphere.GetCarbonDiaxideInPercent);
			cht_MiniAmountSubstance.BeginInvoke((MethodInvoker)delegate{ DrawChart(cht_MiniAmountSubstance, chart_oxygen_list, chart_nitrogen_list, chart_carbon_diaxide_list); });

			switch (select_chart)
			{
				case 0:
					{ 
						cht_FullChart.BeginInvoke((MethodInvoker)delegate { DrawChart(cht_FullChart, chart_temperature_list); });
						max_T = max_T > chart_temperature_list.Max()? max_T : chart_temperature_list.Max();
						min_T = min_T > chart_temperature_list.Min()? min_T : chart_temperature_list.Min();
						l_Info.BeginInvoke((MethodInvoker)(() => l_Info.Text = $"Температура\n   Максимальная: {max_T}\n   Минимальная: {min_T}\n   Средняя {Math.Round(chart_temperature_list.Average(), 2)}"));
					}
				break;
				case 1:
					{ 
						cht_FullChart.BeginInvoke((MethodInvoker)delegate { DrawChart(cht_FullChart, chart_pressure_list); }); 
						max_P = max_P > chart_pressure_list.Max() ? max_P : chart_pressure_list.Max();
						min_P = min_P > chart_pressure_list.Min() ? min_P : chart_pressure_list.Min();
						l_Info.BeginInvoke((MethodInvoker)(() => l_Info.Text = $"Давление\n   Максимальное: {max_P}\n   Минимальное: {min_P}\n   Среднее {Math.Round(chart_pressure_list.Average(), 2)}"));
					}
				break;
				case 2:
					{ 
						cht_FullChart.BeginInvoke((MethodInvoker)delegate { DrawChart(cht_FullChart, chart_oxygen_list, chart_nitrogen_list, chart_carbon_diaxide_list); });
					}
				break;
			}			
		}
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

		private void b_AddAstronaut_Click(object sender, EventArgs e)
		{
			astronauts.AddAstronauts();
			l_NumberOfAstronauts.Text = $"Всего космонавтов: {astronauts.GetCountAstronauts}";
		}

		private void b_RemoveAstronaut_Click(object sender, EventArgs e)
		{
			astronauts.RemoveAstronauts();
			l_NumberOfAstronauts.Text = $"Всего космонавтов: {astronauts.GetCountAstronauts}";
		}

		private void cht_MiniTemperature_Click(object sender, EventArgs e)
		{
			cht_FullChart.ChartAreas[0].AxisY.Maximum = 60;
			cht_FullChart.ChartAreas[0].AxisY.Minimum = 0;
			cht_FullChart.Series[1].Points.Clear();
			cht_FullChart.Series[2].Points.Clear();
			select_chart = 0;
		}

		private void cht_MiniPressure_Click(object sender, EventArgs e)
		{
			cht_FullChart.ChartAreas[0].AxisY.Maximum = 110;
			cht_FullChart.ChartAreas[0].AxisY.Minimum = 90;
			cht_FullChart.Series[1].Points.Clear();
			cht_FullChart.Series[2].Points.Clear();
			select_chart = 1;
		}

		private void cht_MiniAmountSubstance_Click(object sender, EventArgs e)
		{
			cht_FullChart.ChartAreas[0].AxisY.Maximum = 100;
			cht_FullChart.ChartAreas[0].AxisY.Minimum = 0;
			select_chart = 2;
		}
	}
}
