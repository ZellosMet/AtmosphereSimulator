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
			System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea5 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
			System.Windows.Forms.DataVisualization.Charting.Series series9 = new System.Windows.Forms.DataVisualization.Charting.Series();
			System.Windows.Forms.DataVisualization.Charting.Series series10 = new System.Windows.Forms.DataVisualization.Charting.Series();
			System.Windows.Forms.DataVisualization.Charting.Series series11 = new System.Windows.Forms.DataVisualization.Charting.Series();
			System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea6 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
			System.Windows.Forms.DataVisualization.Charting.Series series12 = new System.Windows.Forms.DataVisualization.Charting.Series();
			System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea7 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
			System.Windows.Forms.DataVisualization.Charting.Series series13 = new System.Windows.Forms.DataVisualization.Charting.Series();
			System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea8 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
			System.Windows.Forms.DataVisualization.Charting.Series series14 = new System.Windows.Forms.DataVisualization.Charting.Series();
			System.Windows.Forms.DataVisualization.Charting.Series series15 = new System.Windows.Forms.DataVisualization.Charting.Series();
			System.Windows.Forms.DataVisualization.Charting.Series series16 = new System.Windows.Forms.DataVisualization.Charting.Series();
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
			this.cht_MiniAmountSubstance = new System.Windows.Forms.DataVisualization.Charting.Chart();
			this.cht_MiniPressure = new System.Windows.Forms.DataVisualization.Charting.Chart();
			this.cht_MiniTemperature = new System.Windows.Forms.DataVisualization.Charting.Chart();
			this.panel2 = new System.Windows.Forms.Panel();
			this.cht_FullChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
			this.l_Info = new System.Windows.Forms.Label();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.cht_MiniAmountSubstance)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.cht_MiniPressure)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.cht_MiniTemperature)).BeginInit();
			this.panel2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.cht_FullChart)).BeginInit();
			this.SuspendLayout();
			// 
			// amount_of_oxygen
			// 
			this.amount_of_oxygen.AutoSize = true;
			this.amount_of_oxygen.ForeColor = System.Drawing.Color.Blue;
			this.amount_of_oxygen.Location = new System.Drawing.Point(11, 387);
			this.amount_of_oxygen.Name = "amount_of_oxygen";
			this.amount_of_oxygen.Size = new System.Drawing.Size(24, 16);
			this.amount_of_oxygen.TabIndex = 1;
			this.amount_of_oxygen.Text = "O2";
			// 
			// room_volume
			// 
			this.room_volume.AutoSize = true;
			this.room_volume.Location = new System.Drawing.Point(559, 9);
			this.room_volume.Name = "room_volume";
			this.room_volume.Size = new System.Drawing.Size(89, 16);
			this.room_volume.TabIndex = 2;
			this.room_volume.Text = "room_volume";
			// 
			// amount_of_nitrogen
			// 
			this.amount_of_nitrogen.AutoSize = true;
			this.amount_of_nitrogen.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
			this.amount_of_nitrogen.Location = new System.Drawing.Point(11, 403);
			this.amount_of_nitrogen.Name = "amount_of_nitrogen";
			this.amount_of_nitrogen.Size = new System.Drawing.Size(24, 16);
			this.amount_of_nitrogen.TabIndex = 3;
			this.amount_of_nitrogen.Text = "N2";
			// 
			// temperature
			// 
			this.temperature.AutoSize = true;
			this.temperature.ForeColor = System.Drawing.Color.Blue;
			this.temperature.Location = new System.Drawing.Point(11, 8);
			this.temperature.Name = "temperature";
			this.temperature.Size = new System.Drawing.Size(79, 16);
			this.temperature.TabIndex = 4;
			this.temperature.Text = "temperature";
			// 
			// amount_of_carbon_diaxide
			// 
			this.amount_of_carbon_diaxide.AutoSize = true;
			this.amount_of_carbon_diaxide.ForeColor = System.Drawing.Color.Red;
			this.amount_of_carbon_diaxide.Location = new System.Drawing.Point(11, 419);
			this.amount_of_carbon_diaxide.Name = "amount_of_carbon_diaxide";
			this.amount_of_carbon_diaxide.Size = new System.Drawing.Size(33, 16);
			this.amount_of_carbon_diaxide.TabIndex = 5;
			this.amount_of_carbon_diaxide.Text = "CO2";
			// 
			// pressure
			// 
			this.pressure.AutoSize = true;
			this.pressure.ForeColor = System.Drawing.Color.Blue;
			this.pressure.Location = new System.Drawing.Point(11, 204);
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
			this.Conditioner.Location = new System.Drawing.Point(254, 9);
			this.Conditioner.Name = "Conditioner";
			this.Conditioner.Size = new System.Drawing.Size(75, 16);
			this.Conditioner.TabIndex = 9;
			this.Conditioner.Text = "Conditioner";
			// 
			// checkBox1
			// 
			this.checkBox1.AutoSize = true;
			this.checkBox1.Location = new System.Drawing.Point(257, 101);
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
			this.DevicesTemperature.Location = new System.Drawing.Point(256, 124);
			this.DevicesTemperature.Name = "DevicesTemperature";
			this.DevicesTemperature.Size = new System.Drawing.Size(131, 16);
			this.DevicesTemperature.TabIndex = 11;
			this.DevicesTemperature.Text = "Divace Temperature";
			// 
			// t_Info
			// 
			this.t_Info.Tick += new System.EventHandler(this.t_Info_Tick);
			// 
			// l_ventilation
			// 
			this.l_ventilation.AutoSize = true;
			this.l_ventilation.Location = new System.Drawing.Point(254, 31);
			this.l_ventilation.Name = "l_ventilation";
			this.l_ventilation.Size = new System.Drawing.Size(69, 16);
			this.l_ventilation.TabIndex = 13;
			this.l_ventilation.Text = "Ventilation";
			// 
			// b_AddAstronaut
			// 
			this.b_AddAstronaut.Location = new System.Drawing.Point(257, 72);
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
			this.l_NumberOfAstronauts.Location = new System.Drawing.Point(254, 53);
			this.l_NumberOfAstronauts.Name = "l_NumberOfAstronauts";
			this.l_NumberOfAstronauts.Size = new System.Drawing.Size(134, 16);
			this.l_NumberOfAstronauts.TabIndex = 15;
			this.l_NumberOfAstronauts.Text = "Number of astronauts";
			// 
			// b_RemoveAstronaut
			// 
			this.b_RemoveAstronaut.Location = new System.Drawing.Point(397, 72);
			this.b_RemoveAstronaut.Name = "b_RemoveAstronaut";
			this.b_RemoveAstronaut.Size = new System.Drawing.Size(134, 23);
			this.b_RemoveAstronaut.TabIndex = 16;
			this.b_RemoveAstronaut.Text = "Remove Astronaut";
			this.b_RemoveAstronaut.UseVisualStyleBackColor = true;
			this.b_RemoveAstronaut.Click += new System.EventHandler(this.b_RemoveAstronaut_Click);
			// 
			// panel1
			// 
			this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel1.Controls.Add(this.cht_MiniAmountSubstance);
			this.panel1.Controls.Add(this.cht_MiniPressure);
			this.panel1.Controls.Add(this.cht_MiniTemperature);
			this.panel1.Controls.Add(this.temperature);
			this.panel1.Controls.Add(this.pressure);
			this.panel1.Controls.Add(this.amount_of_oxygen);
			this.panel1.Controls.Add(this.amount_of_nitrogen);
			this.panel1.Controls.Add(this.amount_of_carbon_diaxide);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(236, 619);
			this.panel1.TabIndex = 17;
			// 
			// cht_MiniAmountSubstance
			// 
			chartArea5.AxisX.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.False;
			chartArea5.Name = "ChartArea1";
			this.cht_MiniAmountSubstance.ChartAreas.Add(chartArea5);
			this.cht_MiniAmountSubstance.Location = new System.Drawing.Point(11, 447);
			this.cht_MiniAmountSubstance.Name = "cht_MiniAmountSubstance";
			series9.ChartArea = "ChartArea1";
			series9.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
			series9.Color = System.Drawing.Color.Blue;
			series9.Name = "Oxygen";
			series10.ChartArea = "ChartArea1";
			series10.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
			series10.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
			series10.Name = "Nitrogen";
			series11.ChartArea = "ChartArea1";
			series11.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
			series11.Color = System.Drawing.Color.Red;
			series11.Name = "CarbonDiaxide";
			this.cht_MiniAmountSubstance.Series.Add(series9);
			this.cht_MiniAmountSubstance.Series.Add(series10);
			this.cht_MiniAmountSubstance.Series.Add(series11);
			this.cht_MiniAmountSubstance.Size = new System.Drawing.Size(206, 161);
			this.cht_MiniAmountSubstance.TabIndex = 18;
			this.cht_MiniAmountSubstance.Click += new System.EventHandler(this.cht_MiniAmountSubstance_Click);
			// 
			// cht_MiniPressure
			// 
			chartArea6.AxisX.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.False;
			chartArea6.AxisY.TitleFont = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			chartArea6.Name = "ChartArea1";
			this.cht_MiniPressure.ChartAreas.Add(chartArea6);
			this.cht_MiniPressure.Location = new System.Drawing.Point(11, 223);
			this.cht_MiniPressure.Name = "cht_MiniPressure";
			series12.ChartArea = "ChartArea1";
			series12.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
			series12.Color = System.Drawing.Color.Blue;
			series12.Name = "Series1";
			this.cht_MiniPressure.Series.Add(series12);
			this.cht_MiniPressure.Size = new System.Drawing.Size(206, 161);
			this.cht_MiniPressure.TabIndex = 18;
			this.cht_MiniPressure.Click += new System.EventHandler(this.cht_MiniPressure_Click);
			// 
			// cht_MiniTemperature
			// 
			chartArea7.AxisX.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.False;
			chartArea7.AxisX.IsLabelAutoFit = false;
			chartArea7.AxisY.Maximum = 50D;
			chartArea7.AxisY.Minimum = 0D;
			chartArea7.AxisY.TitleFont = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			chartArea7.Name = "ChartArea1";
			this.cht_MiniTemperature.ChartAreas.Add(chartArea7);
			this.cht_MiniTemperature.Location = new System.Drawing.Point(11, 30);
			this.cht_MiniTemperature.Name = "cht_MiniTemperature";
			series13.ChartArea = "ChartArea1";
			series13.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
			series13.Color = System.Drawing.Color.Blue;
			series13.Name = "Series1";
			this.cht_MiniTemperature.Series.Add(series13);
			this.cht_MiniTemperature.Size = new System.Drawing.Size(206, 161);
			this.cht_MiniTemperature.TabIndex = 18;
			this.cht_MiniTemperature.Click += new System.EventHandler(this.cht_MiniTemperature_Click);
			// 
			// panel2
			// 
			this.panel2.Controls.Add(this.l_Info);
			this.panel2.Controls.Add(this.cht_FullChart);
			this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.panel2.Location = new System.Drawing.Point(236, 143);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(749, 476);
			this.panel2.TabIndex = 18;
			// 
			// cht_FullChart
			// 
			chartArea8.AxisX.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.False;
			chartArea8.AxisY.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.True;
			chartArea8.Name = "ChartArea1";
			this.cht_FullChart.ChartAreas.Add(chartArea8);
			this.cht_FullChart.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.cht_FullChart.Location = new System.Drawing.Point(0, 81);
			this.cht_FullChart.Name = "cht_FullChart";
			series14.ChartArea = "ChartArea1";
			series14.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
			series14.Color = System.Drawing.Color.Blue;
			series14.Name = "Series1";
			series15.ChartArea = "ChartArea1";
			series15.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
			series15.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
			series15.IsVisibleInLegend = false;
			series15.Name = "Series2";
			series16.ChartArea = "ChartArea1";
			series16.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
			series16.Color = System.Drawing.Color.Red;
			series16.Name = "Series3";
			this.cht_FullChart.Series.Add(series14);
			this.cht_FullChart.Series.Add(series15);
			this.cht_FullChart.Series.Add(series16);
			this.cht_FullChart.Size = new System.Drawing.Size(749, 395);
			this.cht_FullChart.TabIndex = 0;
			// 
			// l_Info
			// 
			this.l_Info.AutoSize = true;
			this.l_Info.Location = new System.Drawing.Point(18, 12);
			this.l_Info.Name = "l_Info";
			this.l_Info.Size = new System.Drawing.Size(28, 16);
			this.l_Info.TabIndex = 1;
			this.l_Info.Text = "Info";
			// 
			// Simulation
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(985, 619);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.b_RemoveAstronaut);
			this.Controls.Add(this.l_NumberOfAstronauts);
			this.Controls.Add(this.b_AddAstronaut);
			this.Controls.Add(this.l_ventilation);
			this.Controls.Add(this.DevicesTemperature);
			this.Controls.Add(this.checkBox1);
			this.Controls.Add(this.Conditioner);
			this.Controls.Add(this.room_volume);
			this.Name = "Simulation";
			this.Text = "Simulation";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.cht_MiniAmountSubstance)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.cht_MiniPressure)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.cht_MiniTemperature)).EndInit();
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.cht_FullChart)).EndInit();
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
		private System.Windows.Forms.DataVisualization.Charting.Chart cht_MiniPressure;
		private System.Windows.Forms.DataVisualization.Charting.Chart cht_MiniAmountSubstance;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.DataVisualization.Charting.Chart cht_FullChart;
		private System.Windows.Forms.Label l_Info;
	}
}

