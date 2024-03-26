using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtmosphereControl
{
	internal class Astronauts
	{
		readonly int MIN_COMFORTABLE_TEMPERATURE = 15;
		readonly int MAX_COMFORTABLE_TEMPERATURE = 35;
		readonly int MIN_COMFORTABLE_PRESSURE = 90000;
		readonly int MAX_COMFORTABLE_PRESSURE = 110000;
		readonly double MIN_COMFORTABLE_NITROGEN = 566.5;
		readonly double MAX_COMFORTABLE_NITROGEN = 586.5;
		readonly double MIN_COMFORTABLE_OXYGEN = 147.22;
		readonly double MAX_COMFORTABLE_OXYGEN = 567.22;
		readonly double MIN_COMFORTABLE_CARBON_DIAXIDE = 4.98;
		readonly double MAX_COMFORTABLE_CARBON_DIAXIDE = 24.98;
		readonly double consumption_oxygen = 0.03;
		readonly double consumption_nitrogen = 0.03;
		static readonly double consumption_carbon_diaxide = 0.03;
		static List<Astronauts> astronauts_list;
		Atmosphere atmosphere;

		public double MinComfortableTemperature	{get { return MIN_COMFORTABLE_TEMPERATURE; }}
		public double MaxComfortableTemperature	{get { return MAX_COMFORTABLE_TEMPERATURE; }}
		public double MinComfortablePressure {get { return MIN_COMFORTABLE_PRESSURE; }}
		public double MaxComfortablePressure {get { return MAX_COMFORTABLE_PRESSURE; }}
		public double MinComfortableNitrogen {get { return MIN_COMFORTABLE_NITROGEN; }}
		public double MaxComfortableNitrogen {get { return MAX_COMFORTABLE_NITROGEN; }}
		public double MinComfortableOxygen {get { return MIN_COMFORTABLE_OXYGEN; }}
		public double MaxComfortableOxygen {get { return MAX_COMFORTABLE_OXYGEN; }}
		public double MinComfortableCarbonDiaxide {get { return MIN_COMFORTABLE_CARBON_DIAXIDE; }}
		public double MaxComfortableCarbonDiaxide {get { return MAX_COMFORTABLE_CARBON_DIAXIDE; }}
		public int GetCountAstronauts { get { return astronauts_list.Count; } }
		public double ConsumptionOxygen { get { return consumption_oxygen; } }
		public double ConsumptionNitrogen { get { return consumption_nitrogen; } }
		public double ConsumptionCarbonDiaxide { get { return consumption_carbon_diaxide; } }
		public Astronauts() {}
		public Astronauts(Atmosphere atmosphere)
		{
			astronauts_list = new List<Astronauts> { };
			this.atmosphere = atmosphere;
		}
		public void AddAstronauts()
		{
			Astronauts astronaut = new Astronauts();
			astronauts_list.Add(astronaut);
		}
		public void RemoveAstronauts()
		{
			if (astronauts_list.Count > 0) astronauts_list.RemoveAt(0);
		}
		public static double AtmosphereConsumption()
		{
			double carbon_diaxide = consumption_carbon_diaxide * 2 * astronauts_list.Count;			
			return carbon_diaxide;
		}
	}
}
