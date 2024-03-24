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
	public partial class Form1 : Form
	{
		static Atmosphere atmosphere = new Atmosphere();
		static Automation automation = new Automation();
		static Devices devices = new Devices(atmosphere);
		public Form1()
		{
			InitializeComponent();
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
			automation.ScanAtmosphere(atmosphere);
			if (atmosphere.Temperature < automation.TargetTemperature && automation.ConditionerActive)
			{
				atmosphere.Temperature++;
				atmosphere.GasPreassureFrom();
			}
			else if (atmosphere.Temperature > automation.TargetTemperature && automation.ConditionerActive)
			{
				atmosphere.Temperature--;
				atmosphere.GasPreassureFrom();
			}
			else
			{
				automation.ScanAtmosphere(atmosphere);
				if(!devices.DevicesActive && !automation.ConditionerActive)
				Conditioner.Text = "Кондиционер не активен";
			}
			if (devices.DevicesActive) devices.OverclokingDevices();


			temperature.Text = "Температура\n" + Convert.ToString(atmosphere.Temperature) + " С";
			DevicesTemperature.Text = "Температура устройств\n" + Convert.ToString(devices.CurrentTemperature) + " С";
			pressure.Text = "Давление\n" + Convert.ToString(atmosphere.Pressure) + " Па";
			numericUpDown1.Value = Convert.ToInt32(atmosphere.Temperature);
		}

		private void textBox1_TextChanged(object sender, EventArgs e)
		{
			if (textBox1.Text != "")
			{ 
				atmosphere.Temperature = Convert.ToInt32(textBox1.Text);
				Conditioner.Text = "Кондиционер активен";
			}
		}

		private void checkBox1_CheckedChanged(object sender, EventArgs e)
		{
			if (checkBox1.Checked == true)
			{ 
				devices.StartDevices();
			}
			else 
			{ 
				devices.StopDevices();
			}
		}
	}
}
