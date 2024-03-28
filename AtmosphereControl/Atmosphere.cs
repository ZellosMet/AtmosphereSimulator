using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtmosphereControl
{
	internal class Atmosphere
	{
		readonly double KELVIN = 273; //0 по Кельвину
		readonly double R = 8.3145;  //Универсальная газовая постоянная
		double amount_of_oxygen; //Количество кислорода(моль)
		double amount_of_nitrogen; //Количество азота(моль)
		double amount_of_carbon_diaxide; //Количество СО2(моль)
		double all_matter;	//Общее количество вещества(моль)
		double room_volume; //Объём помещения(м3)
		double temperature; //Температура атмосферы(К)
		double pressure; //Давение атмосферы(Па)

		//Список свойст
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
		public double GetOxygenInPercent { get { return amount_of_oxygen*100/all_matter; } }
		public double GetNitrogenInPercent { get { return amount_of_nitrogen * 100 / all_matter; } }
		public double GetCarbonDiaxideInPercent { get { return amount_of_carbon_diaxide * 100 / all_matter; } }
		public double GetAllMatter { get { return AmountOfOxygen + AmountOfNitrogen + AmountOfCarbonDiaxide; } }
		public double RoomVolume { get { return room_volume; } }
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
			this.amount_of_oxygen = amount_of_oxygen;
			this.amount_of_nitrogen = amount_of_nitrogen;
			this.amount_of_carbon_diaxide = amount_of_carbon_diaxide;
			this.temperature = temperature;
			this.room_volume = room_volume;
			this.all_matter = AmountOfOxygen + AmountOfNitrogen + AmountOfCarbonDiaxide;
			this.pressure = Math.Round((((AmountOfOxygen + AmountOfNitrogen + AmountOfCarbonDiaxide) * R * (Temperature + KELVIN)) / RoomVolume), 2);
		}
		//Метод расчёта давления
		public void GasPreassureFrom()
		{ 
			Pressure = Math.Round((((AmountOfOxygen + AmountOfNitrogen + AmountOfCarbonDiaxide) * R * (Temperature + KELVIN)) / RoomVolume), 2);
		}
	}
}
