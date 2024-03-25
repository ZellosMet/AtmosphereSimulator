using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace AtmosphereControl
{
	internal class Automation
	{
		Atmosphere atmosphere = new Atmosphere();
		//readonly double MIN_TARGET_TEMPERATURE = 18;
		//readonly double MAX_TARGET_TEMPERATURE = 25;
		readonly double MIN_TARGET_PRESSURE = 100000;
		readonly double MAX_TARGET_PRESSURE = 103000;
		readonly double TARGET_TEMPERATURE = 20;
		short power_conditioner = 1;
		int power_ventilation = 1000;
		double target_composition;
		bool ventilation_active;
		bool conditioner_active;

		public double TargetTemperature
		{
			get { return TARGET_TEMPERATURE; }
		}
		//public double MinTargetTemperature
		//{
		//	get { return MIN_TARGET_TEMPERATURE; }
		//}
		//public double MaxTargetTemperature
		//{
		//	get { return MAX_TARGET_TEMPERATURE; }
		//}
		public double MinTargetPressure
		{
			get { return MIN_TARGET_PRESSURE; }
		}
		public double MaxTargetPressure
		{
			get { return MAX_TARGET_PRESSURE; }
		}
		public double TargetComposition
		{
			get { return target_composition; }
			set { target_composition = value; }
		}
		public bool VentilationActive
		{
			get { return ventilation_active; }
			private set { ventilation_active = value; }
		}
		public bool ConditionerActive
		{
			get { return conditioner_active; }
			private set { conditioner_active = value; }
		}
		public short PowerConditioner
		{
			get { return power_conditioner; }
			private set { power_conditioner = value; }
		}
		public int PowerVentilation
		{
			get { return power_ventilation; }
			private set { power_ventilation = value; }
		}

		public Automation(Atmosphere atmosphere)
		{
			this.atmosphere = atmosphere;
			VentilationActive = false;
			ConditionerActive = false;
		}
		public bool StartVentilation()
		{
			return ventilation_active = true;
		}
		public bool StopVentilation()
		{
			return ventilation_active = false;
		}
		public bool StartConditioner()
		{
			return conditioner_active = true;
		}
		public bool StopConditioner()
		{
			return conditioner_active = false;
		}
		public void ScanAtmosphere()
		{
			if (atmosphere.Temperature != TargetTemperature) StartConditioner();
			else StopConditioner();
			if (atmosphere.Pressure < MIN_TARGET_PRESSURE || atmosphere.Pressure > MAX_TARGET_PRESSURE) StartVentilation();
			else StopVentilation();

			if (conditioner_active && atmosphere.Temperature - TargetTemperature <= 5) power_conditioner = 1;
			if (conditioner_active && atmosphere.Temperature - TargetTemperature > 5 && atmosphere.Temperature - TargetTemperature <= 10) power_conditioner = 5;
			if (conditioner_active && atmosphere.Temperature - TargetTemperature > 15 && atmosphere.Temperature - TargetTemperature <= 20) power_conditioner = 15;
			//if (conditioner_active && atmosphere.Temperature - TargetTemperature > 15 && atmosphere.Temperature - TargetTemperature <= 20) power_conditioner = 20;

			if (ventilation_active && atmosphere.Pressure - MAX_TARGET_PRESSURE <= 1000) power_ventilation = 1000;
			if (ventilation_active && atmosphere.Pressure - MAX_TARGET_PRESSURE > 1 && atmosphere.Pressure - MAX_TARGET_PRESSURE <= 2000) power_ventilation = 1500;
			if (ventilation_active && atmosphere.Pressure - MAX_TARGET_PRESSURE > 2 && atmosphere.Pressure - MAX_TARGET_PRESSURE <= 3000) power_ventilation = 2000;
		}
	}
}
