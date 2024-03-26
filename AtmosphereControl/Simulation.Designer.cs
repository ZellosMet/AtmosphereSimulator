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
			this.label1 = new System.Windows.Forms.Label();
			this.amount_of_oxygen = new System.Windows.Forms.Label();
			this.room_volume = new System.Windows.Forms.Label();
			this.amount_of_nitrogen = new System.Windows.Forms.Label();
			this.temperature = new System.Windows.Forms.Label();
			this.amount_of_carbon_diaxide = new System.Windows.Forms.Label();
			this.pressure = new System.Windows.Forms.Label();
			this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
			this.timer1 = new System.Windows.Forms.Timer(this.components);
			this.Conditioner = new System.Windows.Forms.Label();
			this.checkBox1 = new System.Windows.Forms.CheckBox();
			this.DevicesTemperature = new System.Windows.Forms.Label();
			this.t_Info = new System.Windows.Forms.Timer(this.components);
			this.label2 = new System.Windows.Forms.Label();
			this.l_ventilation = new System.Windows.Forms.Label();
			this.b_AddAstronaut = new System.Windows.Forms.Button();
			this.l_NumberOfAstronauts = new System.Windows.Forms.Label();
			this.b_RemoveAstronaut = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(25, 26);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(28, 16);
			this.label1.TabIndex = 0;
			this.label1.Text = "Info";
			// 
			// amount_of_oxygen
			// 
			this.amount_of_oxygen.AutoSize = true;
			this.amount_of_oxygen.Location = new System.Drawing.Point(25, 59);
			this.amount_of_oxygen.Name = "amount_of_oxygen";
			this.amount_of_oxygen.Size = new System.Drawing.Size(120, 16);
			this.amount_of_oxygen.TabIndex = 1;
			this.amount_of_oxygen.Text = "amount_of_oxygen";
			// 
			// room_volume
			// 
			this.room_volume.AutoSize = true;
			this.room_volume.Location = new System.Drawing.Point(25, 115);
			this.room_volume.Name = "room_volume";
			this.room_volume.Size = new System.Drawing.Size(89, 16);
			this.room_volume.TabIndex = 2;
			this.room_volume.Text = "room_volume";
			// 
			// amount_of_nitrogen
			// 
			this.amount_of_nitrogen.AutoSize = true;
			this.amount_of_nitrogen.Location = new System.Drawing.Point(198, 59);
			this.amount_of_nitrogen.Name = "amount_of_nitrogen";
			this.amount_of_nitrogen.Size = new System.Drawing.Size(124, 16);
			this.amount_of_nitrogen.TabIndex = 3;
			this.amount_of_nitrogen.Text = "amount_of_nitrogen";
			// 
			// temperature
			// 
			this.temperature.AutoSize = true;
			this.temperature.Location = new System.Drawing.Point(198, 115);
			this.temperature.Name = "temperature";
			this.temperature.Size = new System.Drawing.Size(79, 16);
			this.temperature.TabIndex = 4;
			this.temperature.Text = "temperature";
			// 
			// amount_of_carbon_diaxide
			// 
			this.amount_of_carbon_diaxide.AutoSize = true;
			this.amount_of_carbon_diaxide.Location = new System.Drawing.Point(339, 59);
			this.amount_of_carbon_diaxide.Name = "amount_of_carbon_diaxide";
			this.amount_of_carbon_diaxide.Size = new System.Drawing.Size(169, 16);
			this.amount_of_carbon_diaxide.TabIndex = 5;
			this.amount_of_carbon_diaxide.Text = "amount_of_carbon_diaxide";
			// 
			// pressure
			// 
			this.pressure.AutoSize = true;
			this.pressure.Location = new System.Drawing.Point(339, 115);
			this.pressure.Name = "pressure";
			this.pressure.Size = new System.Drawing.Size(60, 16);
			this.pressure.TabIndex = 6;
			this.pressure.Text = "pressure";
			// 
			// numericUpDown1
			// 
			this.numericUpDown1.Location = new System.Drawing.Point(28, 267);
			this.numericUpDown1.Maximum = new decimal(new int[] {
            150,
            0,
            0,
            0});
			this.numericUpDown1.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
			this.numericUpDown1.Name = "numericUpDown1";
			this.numericUpDown1.Size = new System.Drawing.Size(120, 22);
			this.numericUpDown1.TabIndex = 7;
			this.numericUpDown1.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
			this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
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
			this.Conditioner.Location = new System.Drawing.Point(158, 189);
			this.Conditioner.Name = "Conditioner";
			this.Conditioner.Size = new System.Drawing.Size(75, 16);
			this.Conditioner.TabIndex = 9;
			this.Conditioner.Text = "Conditioner";
			// 
			// checkBox1
			// 
			this.checkBox1.AutoSize = true;
			this.checkBox1.Location = new System.Drawing.Point(441, 268);
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
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(342, 377);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(44, 16);
			this.label2.TabIndex = 12;
			this.label2.Text = "label2";
			// 
			// l_ventilation
			// 
			this.l_ventilation.AutoSize = true;
			this.l_ventilation.Location = new System.Drawing.Point(159, 223);
			this.l_ventilation.Name = "l_ventilation";
			this.l_ventilation.Size = new System.Drawing.Size(69, 16);
			this.l_ventilation.TabIndex = 13;
			this.l_ventilation.Text = "Ventilation";
			// 
			// b_AddAstronaut
			// 
			this.b_AddAstronaut.Location = new System.Drawing.Point(563, 59);
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
			this.l_NumberOfAstronauts.Location = new System.Drawing.Point(563, 143);
			this.l_NumberOfAstronauts.Name = "l_NumberOfAstronauts";
			this.l_NumberOfAstronauts.Size = new System.Drawing.Size(134, 16);
			this.l_NumberOfAstronauts.TabIndex = 15;
			this.l_NumberOfAstronauts.Text = "Number of astronauts";
			// 
			// b_RemoveAstronaut
			// 
			this.b_RemoveAstronaut.Location = new System.Drawing.Point(563, 99);
			this.b_RemoveAstronaut.Name = "b_RemoveAstronaut";
			this.b_RemoveAstronaut.Size = new System.Drawing.Size(134, 23);
			this.b_RemoveAstronaut.TabIndex = 16;
			this.b_RemoveAstronaut.Text = "Remove Astronaut";
			this.b_RemoveAstronaut.UseVisualStyleBackColor = true;
			this.b_RemoveAstronaut.Click += new System.EventHandler(this.b_RemoveAstronaut_Click);
			// 
			// Simulation
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.b_RemoveAstronaut);
			this.Controls.Add(this.l_NumberOfAstronauts);
			this.Controls.Add(this.b_AddAstronaut);
			this.Controls.Add(this.l_ventilation);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.DevicesTemperature);
			this.Controls.Add(this.checkBox1);
			this.Controls.Add(this.Conditioner);
			this.Controls.Add(this.numericUpDown1);
			this.Controls.Add(this.pressure);
			this.Controls.Add(this.amount_of_carbon_diaxide);
			this.Controls.Add(this.temperature);
			this.Controls.Add(this.amount_of_nitrogen);
			this.Controls.Add(this.room_volume);
			this.Controls.Add(this.amount_of_oxygen);
			this.Controls.Add(this.label1);
			this.Name = "Simulation";
			this.Text = "Simulation";
			this.Load += new System.EventHandler(this.Form1_Load);
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label amount_of_oxygen;
		private System.Windows.Forms.Label room_volume;
		private System.Windows.Forms.Label amount_of_nitrogen;
		private System.Windows.Forms.Label temperature;
		private System.Windows.Forms.Label amount_of_carbon_diaxide;
		private System.Windows.Forms.Label pressure;
		private System.Windows.Forms.NumericUpDown numericUpDown1;
		private System.Windows.Forms.Timer timer1;
		private System.Windows.Forms.Label Conditioner;
		private System.Windows.Forms.CheckBox checkBox1;
		private System.Windows.Forms.Label DevicesTemperature;
		private System.Windows.Forms.Timer t_Info;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label l_ventilation;
		private System.Windows.Forms.Button b_AddAstronaut;
		private System.Windows.Forms.Label l_NumberOfAstronauts;
		private System.Windows.Forms.Button b_RemoveAstronaut;
	}
}

