using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace AtmosphereControl
{
	internal class Automation
	{
		readonly double MIN_TARGET_TEMPERATURE = 18;
		readonly double MAX_TARGET_TEMPERATURE = 25;
		readonly double TARGET_TEMPERATURE = 20;
		double target_composition;
		bool ventilation_active;
		bool conditioner_active;

		public double TargetTemperature
		{
			get { return TARGET_TEMPERATURE; }
		}
		public double MinTargetTemperature
		{
			get { return MIN_TARGET_TEMPERATURE; }
		}
		public double MaxTargetTemperature
		{
			get { return MAX_TARGET_TEMPERATURE; }
		}
		public double TargetComposition
		{
			get { return target_composition; }
			set { target_composition = value; }
		}
		public bool VentilationActive
		{
			get { return ventilation_active; }
			set { ventilation_active = value; }
		}
		public bool ConditionerActive
		{
			get { return conditioner_active; }
			set { conditioner_active = value; }
		}

		public Automation()
		{
			VentilationActive = false;
			ConditionerActive = false;
		}

		public void StartVentilation()
		{
			ventilation_active = true;
		}
		public void StopVentilation()
		{
			ventilation_active = false;
		}
		public void StartConditioner()
		{
			conditioner_active = true;
		}
		public void StopConditioner()
		{
			conditioner_active = false;
		}
		public void ScanAtmosphere(Atmosphere atmosphere)
		{
			if (atmosphere.Temperature != TargetTemperature) StartConditioner();
			else StopConditioner();
		}
	}
}
