using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtmosphereControl
{
	internal class Devices
	{
		readonly double WORKING_TEMPERATURE = 45; //Максимальная рабочая температура устройств
		double device_surface_area = 6; // Площадь поверхности устройст(условно куб 1х1х1м) 
		double current_temperature; //Текущая температура устройств
		bool devices_active; //Состояние устройств
		//Список свойств
		public double DeviceSurfaceArea
		{
			get { return device_surface_area; }
			private set { device_surface_area = value; }
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
			this.current_temperature = atmosphere.Temperature;
			this.devices_active = false;
		}
		//метод запуска устройств
		public void StartDevices()
		{
			DevicesActive = true;
		}
		//Метод остановки устройств
		public void StopDevices()
		{
			DevicesActive = false;
		}
		//Метод расчёта текущей температуры устройств
		public void OverclokingDevices()
		{
			if (DevicesActive && CurrentTemperature < WORKING_TEMPERATURE) 
				CurrentTemperature += 1;
		}
	}
}
