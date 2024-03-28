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
		Atmosphere atmosphere = new Atmosphere();		//Объект атмосферы
		readonly double MIN_TARGET_PRESSURE = 100000;	//Минимальное целевой давлени
		readonly double MAX_TARGET_PRESSURE = 103000;	//Максимальое цедевое давление
		readonly double TARGET_TEMPERATURE = 20;		//Целевая температура
		readonly double TARGET_CARBON_DIAXIDE = 2;		//Целевое содержание СО2
		short power_conditioner = 1;					//Мощность кондиционера
		int power_ventilation = 1000;					//Мощность вентеляции
		bool ventilation_active;						//Состояние вентеляции
		bool conditioner_active;						//Состояние кондиционера
		//Список свойств
		public double TargetTemperature{ get { return TARGET_TEMPERATURE; }	}
		public double MinTargetPressure	{ get { return MIN_TARGET_PRESSURE; } }
		public double MaxTargetPressure	{ get { return MAX_TARGET_PRESSURE; } }
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
		public double TargetCarbonDiaxide { get { return TARGET_CARBON_DIAXIDE; } }
		public Automation(Atmosphere atmosphere)
		{
			this.atmosphere = atmosphere;
			this.ventilation_active = false;
			this.conditioner_active = false;
		}
		//Метод запуска вентиляции
		public bool StartVentilation()
		{
			return ventilation_active = true;
		}
		//Метод остановки вентеляции
		public bool StopVentilation()
		{
			return ventilation_active = false;
		}
		//Метод запуска кондиционера
		public bool StartConditioner()
		{
			return conditioner_active = true;
		}
		//Метод запуска кондиционера
		public bool StopConditioner()
		{
			return conditioner_active = false;
		}
		//Метод сканирования атмосферы
		public void ScanAtmosphere()
		{
			//Проверка температуры
			if (atmosphere.Temperature != TargetTemperature) StartConditioner();
			else StopConditioner();
			//проверка давления и состава атмосферы
			if ((atmosphere.Pressure < MIN_TARGET_PRESSURE || atmosphere.Pressure > MAX_TARGET_PRESSURE) || (atmosphere.GetCarbonDiaxideInPercent > TargetCarbonDiaxide)) StartVentilation();
			else StopVentilation();
			//Регулировака мощности кондифионера
			if (conditioner_active && atmosphere.Temperature - TargetTemperature <= 5) power_conditioner = 1;
			if (conditioner_active && atmosphere.Temperature - TargetTemperature > 5 && atmosphere.Temperature - TargetTemperature <= 10) power_conditioner = 5;
			if (conditioner_active && atmosphere.Temperature - TargetTemperature > 15 && atmosphere.Temperature - TargetTemperature <= 20) power_conditioner = 15;
			//Регулировка мощности вентеляции
			if (ventilation_active && atmosphere.Pressure - MAX_TARGET_PRESSURE <= 1000) power_ventilation = 1000;
			if (ventilation_active && atmosphere.Pressure - MAX_TARGET_PRESSURE > 1 && atmosphere.Pressure - MAX_TARGET_PRESSURE <= 2000) power_ventilation = 2000;
			if (ventilation_active && atmosphere.Pressure - MAX_TARGET_PRESSURE > 2 && atmosphere.Pressure - MAX_TARGET_PRESSURE <= 3000) power_ventilation = 3000;
		}
		//Метод продувки атмосферы
		public void AtmosphereFlow()
		{
			double amount_matter_in_one_part = atmosphere.GetAllMatter / atmosphere.RoomVolume;
			double current_amount_oxygen = atmosphere.GetOxygenInPercent * amount_matter_in_one_part / 100;
			double current_amount_nitrogen = atmosphere.GetNitrogenInPercent * amount_matter_in_one_part / 100;
			double current_amount_carbon_diaxide = atmosphere.GetCarbonDiaxideInPercent * amount_matter_in_one_part / 100;

			atmosphere.AmountOfOxygen = atmosphere.AmountOfOxygen + 8.74 - current_amount_oxygen;
			atmosphere.AmountOfNitrogen = atmosphere.AmountOfNitrogen + 32 - current_amount_nitrogen;
			atmosphere.AmountOfCarbonDiaxide = atmosphere.AmountOfCarbonDiaxide + 0.86 - current_amount_carbon_diaxide*1.5;
		}
	}
}
