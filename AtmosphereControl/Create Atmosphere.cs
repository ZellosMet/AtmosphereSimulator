using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AtmosphereControl
{
	public partial class CreateAtmosphere : Form
	{
		readonly double KELVIN = 273;
		readonly double R = 8.3145;
		readonly double portion_of_a_substance = 41.6;
		public CreateAtmosphere()
		{
			InitializeComponent();
		}
		private void nud_RoomVolume_ValueChanged(object sender, EventArgs e)
		{
			if (nud_RoomVolume.Value == 0 && nud_Temperature.Value == 0 && nud_O2.Value == 0 && nud_N2.Value == 0 && nud_CO2.Value == 0) return;
			//nud_Pressure.Value = Math.Round((((AmountOfOxygen + AmountOfNitrogen + AmountOfCarbonDiaxide) * R * ((double)nud_Temperature.Value + KELVIN)) / nud_RoomVolume.Value), 2);
		}
	}
}
