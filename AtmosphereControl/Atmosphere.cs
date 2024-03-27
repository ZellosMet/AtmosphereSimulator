using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtmosphereControl
{
	internal class Atmosphere
	{
		//pV = m/M* RT
		readonly double HEAT_TRANSFER_COEFFICIENT = 0.0259;
		readonly double KELVIN = 273; //0 по Кельвину
		readonly double R = 8.3145;  //универсальная  газовая постоянная
		double amount_of_oxygen; //количество кислорода, моль
		double amount_of_nitrogen; //количество азота, моль
		double amount_of_carbon_diaxide; // количество СО2, моль
		double all_matter;
		double room_volume; // объём помещения, м3
		double temperature; // температура атмосферы, К
		double pressure; // давение атмосферы, Па

		public double AmountOfOxygen 
		{
			get { return amount_of_oxygen; }
			set { amount_of_oxygen = value; }
		}
		public double AmountOfNitrogen
		{
			get { return amount_of_nitrogen; }
			set { amount_of_nitrogen = value; }
		}
		public double AmountOfCarbonDiaxide
		{
			get { return amount_of_carbon_diaxide; }
			set { amount_of_carbon_diaxide = value; }
		}
		public double GetOxygenInPercent
		{
			get { return amount_of_oxygen*100/all_matter; }
		}
		public double GetNitrogenInPercent
		{
			get { return amount_of_nitrogen * 100 / all_matter; }
		}
		public double GetCarbonDiaxideInPercent
		{
			get { return amount_of_carbon_diaxide * 100 / all_matter; }
		}

		public double RoomVolume
		{
			get { return room_volume; }
			set { room_volume = value; }
		}
		public double Temperature
		{
			get { return temperature; }
			set { temperature = value; }
		}
		public double Pressure
		{
			get { return pressure; }
			set { pressure = value; }
		}

		public Atmosphere(double amount_of_oxygen = 157.22, double amount_of_nitrogen = 576.5, double amount_of_carbon_diaxide = 14.98, double temperature = 20, double room_volume = 18)
		{
			AmountOfOxygen = amount_of_oxygen;
			AmountOfNitrogen = amount_of_nitrogen;
			AmountOfCarbonDiaxide = amount_of_carbon_diaxide;
			Temperature = temperature;
			RoomVolume = room_volume;
			all_matter = AmountOfOxygen + AmountOfNitrogen + AmountOfCarbonDiaxide;
			Pressure = Math.Round((((AmountOfOxygen + AmountOfNitrogen + AmountOfCarbonDiaxide) * R * (Temperature + KELVIN)) / RoomVolume), 2);
		}
		public void GasPreassureFrom()
		{
			//p = (m/M*RT)/V
			Pressure = Math.Round((((AmountOfOxygen + AmountOfNitrogen + AmountOfCarbonDiaxide) * R * (Temperature + KELVIN)) / RoomVolume), 2);
		}
	}
}
