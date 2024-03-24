﻿namespace AtmosphereControl
{
	partial class Form1
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
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.Conditioner = new System.Windows.Forms.Label();
			this.checkBox1 = new System.Windows.Forms.CheckBox();
			this.DevicesTemperature = new System.Windows.Forms.Label();
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
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(244, 267);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(100, 22);
			this.textBox1.TabIndex = 8;
			this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
			// 
			// Conditioner
			// 
			this.Conditioner.AutoSize = true;
			this.Conditioner.Location = new System.Drawing.Point(244, 223);
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
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.DevicesTemperature);
			this.Controls.Add(this.checkBox1);
			this.Controls.Add(this.Conditioner);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.numericUpDown1);
			this.Controls.Add(this.pressure);
			this.Controls.Add(this.amount_of_carbon_diaxide);
			this.Controls.Add(this.temperature);
			this.Controls.Add(this.amount_of_nitrogen);
			this.Controls.Add(this.room_volume);
			this.Controls.Add(this.amount_of_oxygen);
			this.Controls.Add(this.label1);
			this.Name = "Form1";
			this.Text = "Form1";
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
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Label Conditioner;
		private System.Windows.Forms.CheckBox checkBox1;
		private System.Windows.Forms.Label DevicesTemperature;
	}
}
