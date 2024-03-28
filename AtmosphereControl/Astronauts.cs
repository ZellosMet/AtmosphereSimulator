using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtmosphereControl
{
	internal class Astronauts
	{
		readonly double consumption_oxygen = 0.03;					//Порция потребления кислорода космонавтом
		readonly double consumption_nitrogen = 0.03;				//Порция потребления азота космонавтом
		static readonly double consumption_carbon_diaxide = 0.03;	//Порция потребления СО2 космонавтом
		static List<Astronauts> astronauts_list;					//Список космонавтов
		Atmosphere atmosphere;										//Объект атмосферы
		//список свойств
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
		//Метод добавления космонавта
		public void AddAstronauts()
		{
			Astronauts astronaut = new Astronauts();
			astronauts_list.Add(astronaut);
		}
		//Метод удаления космонавта
		public void RemoveAstronauts()
		{
			if (astronauts_list.Count > 0) 
				astronauts_list.RemoveAt(0);
		}
		//Метод выдахаемого СО2
		public static double AtmosphereConsumption()
		{			
			return consumption_carbon_diaxide * 2 * astronauts_list.Count;
		}
	}
}
