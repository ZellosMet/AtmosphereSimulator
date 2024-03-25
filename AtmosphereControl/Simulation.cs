using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AtmosphereControl
{
	public partial class Simulation : Form
	{
		static Atmosphere atmosphere;
		static Automation automation;
		static Devices devices;
		public Simulation()
		{
			InitializeComponent();
			atmosphere = new Atmosphere();
			automation = new Automation(atmosphere);
			devices = new Devices(atmosphere);
		}
		double HeatExchange()
		{
			double coefficient_heat_exchange = 1.16;
			return Math.Round(((coefficient_heat_exchange * devices.DeviceSurfaceArea * Math.Abs(atmosphere.Temperature - devices.CurrentTemperature))/11.6), 2);
		}

		public void Form1_Load(object sender, EventArgs e)
		{
			amount_of_oxygen.Text = "Количество кислорода\n" + Convert.ToString(atmosphere.AmountOfOxygen) + " моль";
			amount_of_nitrogen.Text = "Количество азота\n" + Convert.ToString(atmosphere.AmountOfNitrogen) + " моль";
			amount_of_carbon_diaxide.Text = "Количество СО2\n" + Convert.ToString(atmosphere.AmountOfCarbonDiaxide) + " моль";
			pressure.Text = "Давление\n" + Convert.ToString(atmosphere.Pressure) + " Па";
			temperature.Text = "Температура\n" + Convert.ToString(atmosphere.Temperature) + " С";
			room_volume.Text = "Объём помещения\n" + Convert.ToString(atmosphere.RoomVolume) + " м3";
			Conditioner.Text = "Кондиционер не активен";
			DevicesTemperature.Text = "Температура устройств\n" + Convert.ToString(devices.CurrentTemperature) + " С";
			timer1.Start();
			t_Info.Start();
		}
		private void numericUpDown1_ValueChanged(object sender, EventArgs e)
		{
			atmosphere.Temperature = Convert.ToDouble(numericUpDown1.Value);
			atmosphere.GasPreassureFrom();
			temperature.Text = "Температура\n" + Convert.ToString(atmosphere.Temperature) + " С";
			pressure.Text = "Давление\n" + Convert.ToString(atmosphere.Pressure) + " Па";
		}

		private void timer1_Tick(object sender, EventArgs e)
		{
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
				if (atmosphere.Pressure > automation.MaxTargetPressure && automation.VentilationActive)			
					atmosphere.Pressure -= automation.PowerVentilation;
			}			

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
			temperature.BeginInvoke((MethodInvoker)(() => temperature.Text  = "Температура\n" + Convert.ToString(atmosphere.Temperature) + " С"));
			DevicesTemperature.BeginInvoke((MethodInvoker)(() => DevicesTemperature.Text = "Температура устройств\n" + Convert.ToString(devices.CurrentTemperature) + " С"));
			pressure.BeginInvoke((MethodInvoker)(() => pressure.Text = "Давление\n" + Convert.ToString(atmosphere.Pressure) + " Па"));
			numericUpDown1.BeginInvoke((MethodInvoker)(() => numericUpDown1.Value = Convert.ToInt32(atmosphere.Temperature)));			
			Conditioner.BeginInvoke((MethodInvoker)(() => Conditioner.Text = automation.ConditionerActive ? "Кондиционер активен" : "Кондиционер не активен"));
			l_ventilation.BeginInvoke((MethodInvoker)(() => l_ventilation.Text = automation.VentilationActive ? "Вентеляция активена" : "Вентеляция не активена"));
			label2.BeginInvoke((MethodInvoker)(() => label2.Text = $"{automation.ConditionerActive} {automation.PowerConditioner}"));
			label2.BeginInvoke((MethodInvoker)(() => label2.Text += $" {automation.VentilationActive} {automation.PowerVentilation}"));
		}
	}
}
