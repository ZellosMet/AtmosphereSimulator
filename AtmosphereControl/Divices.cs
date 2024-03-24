using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtmosphereControl
{
	internal class Devices
	{
		readonly double WORKING_TEMPERATURE = 45;
		double current_temperature;
		bool devices_active;
		public double WorkingTemperature
		{
			get { return WORKING_TEMPERATURE; }
		}
		public double CurrentTemperature
		{
			get { return current_temperature; }
			set { current_temperature = value; }
		}
		public bool DevicesActive
		{
			get { return devices_active; }
			set { devices_active = value; }
		}
		public Devices(Atmosphere atmosphere)
		{
			CurrentTemperature = atmosphere.Temperature;
			DevicesActive = false;
		}
		public void StartDevices()
		{
			DevicesActive = true;
		}
		public void StopDevices()
		{
			DevicesActive = false;
		}
		public void OverclokingDevices()
		{
			if (DevicesActive && CurrentTemperature < WORKING_TEMPERATURE) CurrentTemperature += 0.5;
		}
	}
}
