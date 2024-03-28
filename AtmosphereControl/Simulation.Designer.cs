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
			this.l_O2 = new System.Windows.Forms.Label();
			this.l_RoomVolume = new System.Windows.Forms.Label();
			this.l_N2 = new System.Windows.Forms.Label();
			this.temperature = new System.Windows.Forms.Label();
			this.l_CO2 = new System.Windows.Forms.Label();
			this.pressure = new System.Windows.Forms.Label();
			this.t_RefreshData = new System.Windows.Forms.Timer(this.components);
			this.l_Conditioner = new System.Windows.Forms.Label();
			this.cb_DeviceActive = new System.Windows.Forms.CheckBox();
			this.l_DevicesTemperature = new System.Windows.Forms.Label();
			this.t_RefreshInfo = new System.Windows.Forms.Timer(this.components);
			this.l_Ventilation = new System.Windows.Forms.Label();
			this.b_AddAstronaut = new System.Windows.Forms.Button();
			this.l_NumberOfAstronauts = new System.Windows.Forms.Label();
			this.b_RemoveAstronaut = new System.Windows.Forms.Button();
			this.p_MiniGraphics = new System.Windows.Forms.Panel();
			this.cht_MiniAmountSubstance = new System.Windows.Forms.DataVisualization.Charting.Chart();
			this.cht_MiniPressure = new System.Windows.Forms.DataVisualization.Charting.Chart();
			this.cht_MiniTemperature = new System.Windows.Forms.DataVisualization.Charting.Chart();
			this.p_FullGraphic = new System.Windows.Forms.Panel();
			this.l_Info = new System.Windows.Forms.Label();
			this.cht_FullChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
			this.p_Control = new System.Windows.Forms.Panel();
			this.p_MiniGraphics.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.cht_MiniAmountSubstance)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.cht_MiniPressure)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.cht_MiniTemperature)).BeginInit();
			this.p_FullGraphic.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.cht_FullChart)).BeginInit();
			this.p_Control.SuspendLayout();
			this.SuspendLayout();
			// 
			// l_O2
			// 
			this.l_O2.AutoSize = true;
			this.l_O2.ForeColor = System.Drawing.Color.Blue;
			this.l_O2.Location = new System.Drawing.Point(11, 387);
			this.l_O2.Name = "l_O2";
			this.l_O2.Size = new System.Drawing.Size(24, 16);
			this.l_O2.TabIndex = 1;
			this.l_O2.Text = "O2";
			// 
			// l_RoomVolume
			// 
			this.l_RoomVolume.AutoSize = true;
			this.l_RoomVolume.Location = new System.Drawing.Point(10, 5);
			this.l_RoomVolume.Name = "l_RoomVolume";
			this.l_RoomVolume.Size = new System.Drawing.Size(93, 16);
			this.l_RoomVolume.TabIndex = 2;
			this.l_RoomVolume.Text = "Room Volume";
			// 
			// l_N2
			// 
			this.l_N2.AutoSize = true;
			this.l_N2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
			this.l_N2.Location = new System.Drawing.Point(11, 403);
			this.l_N2.Name = "l_N2";
			this.l_N2.Size = new System.Drawing.Size(24, 16);
			this.l_N2.TabIndex = 3;
			this.l_N2.Text = "N2";
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
			// l_CO2
			// 
			this.l_CO2.AutoSize = true;
			this.l_CO2.ForeColor = System.Drawing.Color.Red;
			this.l_CO2.Location = new System.Drawing.Point(11, 419);
			this.l_CO2.Name = "l_CO2";
			this.l_CO2.Size = new System.Drawing.Size(33, 16);
			this.l_CO2.TabIndex = 5;
			this.l_CO2.Text = "CO2";
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
			// t_RefreshData
			// 
			this.t_RefreshData.Enabled = true;
			this.t_RefreshData.Interval = 1000;
			this.t_RefreshData.Tick += new System.EventHandler(this.RefreshData_Tick);
			// 
			// l_Conditioner
			// 
			this.l_Conditioner.AutoSize = true;
			this.l_Conditioner.Location = new System.Drawing.Point(10, 27);
			this.l_Conditioner.Name = "l_Conditioner";
			this.l_Conditioner.Size = new System.Drawing.Size(75, 16);
			this.l_Conditioner.TabIndex = 9;
			this.l_Conditioner.Text = "Conditioner";
			// 
			// cb_DeviceActive
			// 
			this.cb_DeviceActive.AutoSize = true;
			this.cb_DeviceActive.Location = new System.Drawing.Point(407, 56);
			this.cb_DeviceActive.Name = "cb_DeviceActive";
			this.cb_DeviceActive.Size = new System.Drawing.Size(174, 20);
			this.cb_DeviceActive.TabIndex = 10;
			this.cb_DeviceActive.Text = "Запуск оборудования";
			this.cb_DeviceActive.UseVisualStyleBackColor = true;
			this.cb_DeviceActive.CheckedChanged += new System.EventHandler(this.cb_DeviceActive_CheckedChanged);
			// 
			// l_DevicesTemperature
			// 
			this.l_DevicesTemperature.AutoSize = true;
			this.l_DevicesTemperature.Location = new System.Drawing.Point(11, 68);
			this.l_DevicesTemperature.Name = "l_DevicesTemperature";
			this.l_DevicesTemperature.Size = new System.Drawing.Size(194, 16);
			this.l_DevicesTemperature.TabIndex = 11;
			this.l_DevicesTemperature.Text = "Температура оборудования";
			// 
			// t_RefreshInfo
			// 
			this.t_RefreshInfo.Tick += new System.EventHandler(this.t_Info_Tick);
			// 
			// l_Ventilation
			// 
			this.l_Ventilation.AutoSize = true;
			this.l_Ventilation.Location = new System.Drawing.Point(11, 48);
			this.l_Ventilation.Name = "l_Ventilation";
			this.l_Ventilation.Size = new System.Drawing.Size(69, 16);
			this.l_Ventilation.TabIndex = 13;
			this.l_Ventilation.Text = "Ventilation";
			// 
			// b_AddAstronaut
			// 
			this.b_AddAstronaut.Location = new System.Drawing.Point(405, 27);
			this.b_AddAstronaut.Name = "b_AddAstronaut";
			this.b_AddAstronaut.Size = new System.Drawing.Size(159, 23);
			this.b_AddAstronaut.TabIndex = 14;
			this.b_AddAstronaut.Text = "Добавить космонавта";
			this.b_AddAstronaut.UseVisualStyleBackColor = true;
			this.b_AddAstronaut.Click += new System.EventHandler(this.b_AddAstronaut_Click);
			// 
			// l_NumberOfAstronauts
			// 
			this.l_NumberOfAstronauts.AutoSize = true;
			this.l_NumberOfAstronauts.Location = new System.Drawing.Point(404, 8);
			this.l_NumberOfAstronauts.Name = "l_NumberOfAstronauts";
			this.l_NumberOfAstronauts.Size = new System.Drawing.Size(134, 16);
			this.l_NumberOfAstronauts.TabIndex = 15;
			this.l_NumberOfAstronauts.Text = "Number of astronauts";
			// 
			// b_RemoveAstronaut
			// 
			this.b_RemoveAstronaut.Location = new System.Drawing.Point(573, 27);
			this.b_RemoveAstronaut.Name = "b_RemoveAstronaut";
			this.b_RemoveAstronaut.Size = new System.Drawing.Size(155, 23);
			this.b_RemoveAstronaut.TabIndex = 16;
			this.b_RemoveAstronaut.Text = "Удалить космонавта";
			this.b_RemoveAstronaut.UseVisualStyleBackColor = true;
			this.b_RemoveAstronaut.Click += new System.EventHandler(this.b_RemoveAstronaut_Click);
			// 
			// p_MiniGraphics
			// 
			this.p_MiniGraphics.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.p_MiniGraphics.Controls.Add(this.cht_MiniAmountSubstance);
			this.p_MiniGraphics.Controls.Add(this.cht_MiniPressure);
			this.p_MiniGraphics.Controls.Add(this.cht_MiniTemperature);
			this.p_MiniGraphics.Controls.Add(this.temperature);
			this.p_MiniGraphics.Controls.Add(this.pressure);
			this.p_MiniGraphics.Controls.Add(this.l_O2);
			this.p_MiniGraphics.Controls.Add(this.l_N2);
			this.p_MiniGraphics.Controls.Add(this.l_CO2);
			this.p_MiniGraphics.Dock = System.Windows.Forms.DockStyle.Left;
			this.p_MiniGraphics.Location = new System.Drawing.Point(0, 0);
			this.p_MiniGraphics.Name = "p_MiniGraphics";
			this.p_MiniGraphics.Size = new System.Drawing.Size(236, 619);
			this.p_MiniGraphics.TabIndex = 17;
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
			// p_FullGraphic
			// 
			this.p_FullGraphic.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.p_FullGraphic.Controls.Add(this.l_Info);
			this.p_FullGraphic.Controls.Add(this.cht_FullChart);
			this.p_FullGraphic.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.p_FullGraphic.Location = new System.Drawing.Point(236, 104);
			this.p_FullGraphic.Name = "p_FullGraphic";
			this.p_FullGraphic.Size = new System.Drawing.Size(755, 515);
			this.p_FullGraphic.TabIndex = 18;
			// 
			// l_Info
			// 
			this.l_Info.AutoSize = true;
			this.l_Info.Location = new System.Drawing.Point(8, 5);
			this.l_Info.Name = "l_Info";
			this.l_Info.Size = new System.Drawing.Size(28, 16);
			this.l_Info.TabIndex = 1;
			this.l_Info.Text = "Info";
			// 
			// cht_FullChart
			// 
			chartArea8.AxisX.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.False;
			chartArea8.AxisY.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.True;
			chartArea8.Name = "ChartArea1";
			this.cht_FullChart.ChartAreas.Add(chartArea8);
			this.cht_FullChart.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.cht_FullChart.Location = new System.Drawing.Point(0, 71);
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
			this.cht_FullChart.Size = new System.Drawing.Size(751, 440);
			this.cht_FullChart.TabIndex = 0;
			// 
			// p_Control
			// 
			this.p_Control.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.p_Control.Controls.Add(this.cb_DeviceActive);
			this.p_Control.Controls.Add(this.l_RoomVolume);
			this.p_Control.Controls.Add(this.b_RemoveAstronaut);
			this.p_Control.Controls.Add(this.l_Conditioner);
			this.p_Control.Controls.Add(this.l_NumberOfAstronauts);
			this.p_Control.Controls.Add(this.l_DevicesTemperature);
			this.p_Control.Controls.Add(this.b_AddAstronaut);
			this.p_Control.Controls.Add(this.l_Ventilation);
			this.p_Control.Dock = System.Windows.Forms.DockStyle.Top;
			this.p_Control.Location = new System.Drawing.Point(236, 0);
			this.p_Control.Name = "p_Control";
			this.p_Control.Size = new System.Drawing.Size(755, 108);
			this.p_Control.TabIndex = 19;
			// 
			// Simulation
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(991, 619);
			this.Controls.Add(this.p_Control);
			this.Controls.Add(this.p_FullGraphic);
			this.Controls.Add(this.p_MiniGraphics);
			this.Name = "Simulation";
			this.Text = "Simulation";
			this.p_MiniGraphics.ResumeLayout(false);
			this.p_MiniGraphics.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.cht_MiniAmountSubstance)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.cht_MiniPressure)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.cht_MiniTemperature)).EndInit();
			this.p_FullGraphic.ResumeLayout(false);
			this.p_FullGraphic.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.cht_FullChart)).EndInit();
			this.p_Control.ResumeLayout(false);
			this.p_Control.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion
		private System.Windows.Forms.Label l_O2;
		private System.Windows.Forms.Label l_RoomVolume;
		private System.Windows.Forms.Label l_N2;
		private System.Windows.Forms.Label temperature;
		private System.Windows.Forms.Label l_CO2;
		private System.Windows.Forms.Label pressure;
		private System.Windows.Forms.Timer t_RefreshData;
		private System.Windows.Forms.Label l_Conditioner;
		private System.Windows.Forms.CheckBox cb_DeviceActive;
		private System.Windows.Forms.Label l_DevicesTemperature;
		private System.Windows.Forms.Timer t_RefreshInfo;
		private System.Windows.Forms.Label l_Ventilation;
		private System.Windows.Forms.Button b_AddAstronaut;
		private System.Windows.Forms.Label l_NumberOfAstronauts;
		private System.Windows.Forms.Button b_RemoveAstronaut;
		private System.Windows.Forms.Panel p_MiniGraphics;
		private System.Windows.Forms.DataVisualization.Charting.Chart cht_MiniTemperature;
		private System.Windows.Forms.DataVisualization.Charting.Chart cht_MiniPressure;
		private System.Windows.Forms.DataVisualization.Charting.Chart cht_MiniAmountSubstance;
		private System.Windows.Forms.Panel p_FullGraphic;
		private System.Windows.Forms.DataVisualization.Charting.Chart cht_FullChart;
		private System.Windows.Forms.Label l_Info;
		private System.Windows.Forms.Panel p_Control;
	}
}

