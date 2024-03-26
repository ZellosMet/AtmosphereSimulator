using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtmosphereControl
{
	internal class Astronaut
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
		public Astronaut(Atmosphere atmosphere)
		{ 
			this.atmosphere = atmosphere;
		}
		public double AtmosphereConsumption()
		{
			double carbon_diaxide = 0;
			return carbon_diaxide;
		}
	}
}
