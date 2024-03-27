namespace AtmosphereControl
{
	partial class Simulation
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
			System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
			System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
			this.amount_of_oxygen = new System.Windows.Forms.Label();
			this.room_volume = new System.Windows.Forms.Label();
			this.amount_of_nitrogen = new System.Windows.Forms.Label();
			this.temperature = new System.Windows.Forms.Label();
			this.amount_of_carbon_diaxide = new System.Windows.Forms.Label();
			this.pressure = new System.Windows.Forms.Label();
			this.timer1 = new System.Windows.Forms.Timer(this.components);
			this.Conditioner = new System.Windows.Forms.Label();
			this.checkBox1 = new System.Windows.Forms.CheckBox();
			this.DevicesTemperature = new System.Windows.Forms.Label();
			this.t_Info = new System.Windows.Forms.Timer(this.components);
			this.l_ventilation = new System.Windows.Forms.Label();
			this.b_AddAstronaut = new System.Windows.Forms.Button();
			this.l_NumberOfAstronauts = new System.Windows.Forms.Label();
			this.b_RemoveAstronaut = new System.Windows.Forms.Button();
			this.panel1 = new System.Windows.Forms.Panel();
			this.cht_MiniTemperature = new System.Windows.Forms.DataVisualization.Charting.Chart();
			((System.ComponentModel.ISupportInitialize)(this.cht_MiniTemperature)).BeginInit();
			this.SuspendLayout();
			// 
			// amount_of_oxygen
			// 
			this.amount_of_oxygen.AutoSize = true;
			this.amount_of_oxygen.Location = new System.Drawing.Point(424, 381);
			this.amount_of_oxygen.Name = "amount_of_oxygen";
			this.amount_of_oxygen.Size = new System.Drawing.Size(120, 16);
			this.amount_of_oxygen.TabIndex = 1;
			this.amount_of_oxygen.Text = "amount_of_oxygen";
			// 
			// room_volume
			// 
			this.room_volume.AutoSize = true;
			this.room_volume.Location = new System.Drawing.Point(424, 437);
			this.room_volume.Name = "room_volume";
			this.room_volume.Size = new System.Drawing.Size(89, 16);
			this.room_volume.TabIndex = 2;
			this.room_volume.Text = "room_volume";
			// 
			// amount_of_nitrogen
			// 
			this.amount_of_nitrogen.AutoSize = true;
			this.amount_of_nitrogen.Location = new System.Drawing.Point(597, 381);
			this.amount_of_nitrogen.Name = "amount_of_nitrogen";
			this.amount_of_nitrogen.Size = new System.Drawing.Size(124, 16);
			this.amount_of_nitrogen.TabIndex = 3;
			this.amount_of_nitrogen.Text = "amount_of_nitrogen";
			// 
			// temperature
			// 
			this.temperature.AutoSize = true;
			this.temperature.Location = new System.Drawing.Point(597, 437);
			this.temperature.Name = "temperature";
			this.temperature.Size = new System.Drawing.Size(79, 16);
			this.temperature.TabIndex = 4;
			this.temperature.Text = "temperature";
			// 
			// amount_of_carbon_diaxide
			// 
			this.amount_of_carbon_diaxide.AutoSize = true;
			this.amount_of_carbon_diaxide.Location = new System.Drawing.Point(738, 381);
			this.amount_of_carbon_diaxide.Name = "amount_of_carbon_diaxide";
			this.amount_of_carbon_diaxide.Size = new System.Drawing.Size(169, 16);
			this.amount_of_carbon_diaxide.TabIndex = 5;
			this.amount_of_carbon_diaxide.Text = "amount_of_carbon_diaxide";
			// 
			// pressure
			// 
			this.pressure.AutoSize = true;
			this.pressure.Location = new System.Drawing.Point(738, 437);
			this.pressure.Name = "pressure";
			this.pressure.Size = new System.Drawing.Size(60, 16);
			this.pressure.TabIndex = 6;
			this.pressure.Text = "pressure";
			// 
			// timer1
			// 
			this.timer1.Enabled = true;
			this.timer1.Interval = 1000;
			this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
			// 
			// Conditioner
			// 
			this.Conditioner.AutoSize = true;
			this.Conditioner.Location = new System.Drawing.Point(666, 189);
			this.Conditioner.Name = "Conditioner";
			this.Conditioner.Size = new System.Drawing.Size(75, 16);
			this.Conditioner.TabIndex = 9;
			this.Conditioner.Text = "Conditioner";
			// 
			// checkBox1
			// 
			this.checkBox1.AutoSize = true;
			this.checkBox1.Location = new System.Drawing.Point(800, 134);
			this.checkBox1.Name = "checkBox1";
			this.checkBox1.Size = new System.Drawing.Size(118, 20);
			this.checkBox1.TabIndex = 10;
			this.checkBox1.Text = "Devices active";
			this.checkBox1.UseVisualStyleBackColor = true;
			this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
			// 
			// DevicesTemperature
			// 
			this.DevicesTemperature.AutoSize = true;
			this.DevicesTemperature.Location = new System.Drawing.Point(441, 223);
			this.DevicesTemperature.Name = "DevicesTemperature";
			this.DevicesTemperature.Size = new System.Drawing.Size(0, 16);
			this.DevicesTemperature.TabIndex = 11;
			// 
			// t_Info
			// 
			this.t_Info.Tick += new System.EventHandler(this.t_Info_Tick);
			// 
			// l_ventilation
			// 
			this.l_ventilation.AutoSize = true;
			this.l_ventilation.Location = new System.Drawing.Point(667, 223);
			this.l_ventilation.Name = "l_ventilation";
			this.l_ventilation.Size = new System.Drawing.Size(69, 16);
			this.l_ventilation.TabIndex = 13;
			this.l_ventilation.Text = "Ventilation";
			// 
			// b_AddAstronaut
			// 
			this.b_AddAstronaut.Location = new System.Drawing.Point(797, 12);
			this.b_AddAstronaut.Name = "b_AddAstronaut";
			this.b_AddAstronaut.Size = new System.Drawing.Size(134, 23);
			this.b_AddAstronaut.TabIndex = 14;
			this.b_AddAstronaut.Text = "Add Astronaut";
			this.b_AddAstronaut.UseVisualStyleBackColor = true;
			this.b_AddAstronaut.Click += new System.EventHandler(this.b_AddAstronaut_Click);
			// 
			// l_NumberOfAstronauts
			// 
			this.l_NumberOfAstronauts.AutoSize = true;
			this.l_NumberOfAstronauts.Location = new System.Drawing.Point(797, 100);
			this.l_NumberOfAstronauts.Name = "l_NumberOfAstronauts";
			this.l_NumberOfAstronauts.Size = new System.Drawing.Size(134, 16);
			this.l_NumberOfAstronauts.TabIndex = 15;
			this.l_NumberOfAstronauts.Text = "Number of astronauts";
			// 
			// b_RemoveAstronaut
			// 
			this.b_RemoveAstronaut.Location = new System.Drawing.Point(797, 52);
			this.b_RemoveAstronaut.Name = "b_RemoveAstronaut";
			this.b_RemoveAstronaut.Size = new System.Drawing.Size(134, 23);
			this.b_RemoveAstronaut.TabIndex = 16;
			this.b_RemoveAstronaut.Text = "Remove Astronaut";
			this.b_RemoveAstronaut.UseVisualStyleBackColor = true;
			this.b_RemoveAstronaut.Click += new System.EventHandler(this.b_RemoveAstronaut_Click);
			// 
			// panel1
			// 
			this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(236, 520);
			this.panel1.TabIndex = 17;
			// 
			// cht_MiniTemperature
			// 
			chartArea1.Name = "ChartArea1";
			this.cht_MiniTemperature.ChartAreas.Add(chartArea1);
			legend1.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Bottom;
			legend1.Name = "Legend1";
			this.cht_MiniTemperature.Legends.Add(legend1);
			this.cht_MiniTemperature.Location = new System.Drawing.Point(256, 22);
			this.cht_MiniTemperature.Name = "cht_MiniTemperature";
			series1.ChartArea = "ChartArea1";
			series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
			series1.Legend = "Legend1";
			series1.Name = "Series1";
			this.cht_MiniTemperature.Series.Add(series1);
			this.cht_MiniTemperature.Size = new System.Drawing.Size(514, 486);
			this.cht_MiniTemperature.TabIndex = 18;
			// 
			// Simulation
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(943, 520);
			this.Controls.Add(this.cht_MiniTemperature);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.b_RemoveAstronaut);
			this.Controls.Add(this.l_NumberOfAstronauts);
			this.Controls.Add(this.b_AddAstronaut);
			this.Controls.Add(this.l_ventilation);
			this.Controls.Add(this.DevicesTemperature);
			this.Controls.Add(this.checkBox1);
			this.Controls.Add(this.Conditioner);
			this.Controls.Add(this.pressure);
			this.Controls.Add(this.amount_of_carbon_diaxide);
			this.Controls.Add(this.temperature);
			this.Controls.Add(this.amount_of_nitrogen);
			this.Controls.Add(this.room_volume);
			this.Controls.Add(this.amount_of_oxygen);
			this.Name = "Simulation";
			this.Text = "Simulation";
			this.Load += new System.EventHandler(this.Form1_Load);
			((System.ComponentModel.ISupportInitialize)(this.cht_MiniTemperature)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.Label amount_of_oxygen;
		private System.Windows.Forms.Label room_volume;
		private System.Windows.Forms.Label amount_of_nitrogen;
		private System.Windows.Forms.Label temperature;
		private System.Windows.Forms.Label amount_of_carbon_diaxide;
		private System.Windows.Forms.Label pressure;
		private System.Windows.Forms.Timer timer1;
		private System.Windows.Forms.Label Conditioner;
		private System.Windows.Forms.CheckBox checkBox1;
		private System.Windows.Forms.Label DevicesTemperature;
		private System.Windows.Forms.Timer t_Info;
		private System.Windows.Forms.Label l_ventilation;
		private System.Windows.Forms.Button b_AddAstronaut;
		private System.Windows.Forms.Label l_NumberOfAstronauts;
		private System.Windows.Forms.Button b_RemoveAstronaut;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.DataVisualization.Charting.Chart cht_MiniTemperature;
	}
}

