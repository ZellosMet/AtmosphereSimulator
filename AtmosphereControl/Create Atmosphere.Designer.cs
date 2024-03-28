namespace AtmosphereControl
{
	partial class CreateAtmosphere
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
			this.l_RoomVolume = new System.Windows.Forms.Label();
			this.nud_RoomVolume = new System.Windows.Forms.NumericUpDown();
			this.label2 = new System.Windows.Forms.Label();
			this.nud_Temperature = new System.Windows.Forms.NumericUpDown();
			this.nud_Pressure = new System.Windows.Forms.NumericUpDown();
			this.l_Pressure = new System.Windows.Forms.Label();
			this.nud_O2 = new System.Windows.Forms.NumericUpDown();
			this.l_AtmosphericComposition = new System.Windows.Forms.Label();
			this.l_O2 = new System.Windows.Forms.Label();
			this.l_CO2 = new System.Windows.Forms.Label();
			this.nud_CO2 = new System.Windows.Forms.NumericUpDown();
			this.l_N2 = new System.Windows.Forms.Label();
			this.nud_N2 = new System.Windows.Forms.NumericUpDown();
			((System.ComponentModel.ISupportInitialize)(this.nud_RoomVolume)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.nud_Temperature)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.nud_Pressure)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.nud_O2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.nud_CO2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.nud_N2)).BeginInit();
			this.SuspendLayout();
			// 
			// l_RoomVolume
			// 
			this.l_RoomVolume.AutoSize = true;
			this.l_RoomVolume.Location = new System.Drawing.Point(13, 13);
			this.l_RoomVolume.Name = "l_RoomVolume";
			this.l_RoomVolume.Size = new System.Drawing.Size(151, 16);
			this.l_RoomVolume.TabIndex = 0;
			this.l_RoomVolume.Text = "Объём помещения(м3)";
			// 
			// nud_RoomVolume
			// 
			this.nud_RoomVolume.Location = new System.Drawing.Point(16, 32);
			this.nud_RoomVolume.Name = "nud_RoomVolume";
			this.nud_RoomVolume.Size = new System.Drawing.Size(85, 22);
			this.nud_RoomVolume.TabIndex = 1;
			this.nud_RoomVolume.Value = new decimal(new int[] {
            18,
            0,
            0,
            0});
			this.nud_RoomVolume.ValueChanged += new System.EventHandler(this.nud_RoomVolume_ValueChanged);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(13, 68);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(190, 16);
			this.label2.TabIndex = 2;
			this.label2.Text = "Температура атмосфера(С)";
			// 
			// nud_Temperature
			// 
			this.nud_Temperature.DecimalPlaces = 1;
			this.nud_Temperature.Location = new System.Drawing.Point(16, 87);
			this.nud_Temperature.Name = "nud_Temperature";
			this.nud_Temperature.Size = new System.Drawing.Size(85, 22);
			this.nud_Temperature.TabIndex = 3;
			this.nud_Temperature.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
			// 
			// nud_Pressure
			// 
			this.nud_Pressure.DecimalPlaces = 2;
			this.nud_Pressure.Location = new System.Drawing.Point(16, 254);
			this.nud_Pressure.Name = "nud_Pressure";
			this.nud_Pressure.Size = new System.Drawing.Size(85, 22);
			this.nud_Pressure.TabIndex = 5;
			this.nud_Pressure.Value = new decimal(new int[] {
            121,
            0,
            0,
            65536});
			// 
			// l_Pressure
			// 
			this.l_Pressure.AutoSize = true;
			this.l_Pressure.Location = new System.Drawing.Point(13, 235);
			this.l_Pressure.Name = "l_Pressure";
			this.l_Pressure.Size = new System.Drawing.Size(176, 16);
			this.l_Pressure.TabIndex = 4;
			this.l_Pressure.Text = "Давление атмосферы(Па)";
			// 
			// nud_O2
			// 
			this.nud_O2.DecimalPlaces = 1;
			this.nud_O2.Location = new System.Drawing.Point(54, 141);
			this.nud_O2.Name = "nud_O2";
			this.nud_O2.Size = new System.Drawing.Size(85, 22);
			this.nud_O2.TabIndex = 7;
			this.nud_O2.Value = new decimal(new int[] {
            21,
            0,
            0,
            0});
			// 
			// l_AtmosphericComposition
			// 
			this.l_AtmosphericComposition.AutoSize = true;
			this.l_AtmosphericComposition.Location = new System.Drawing.Point(13, 122);
			this.l_AtmosphericComposition.Name = "l_AtmosphericComposition";
			this.l_AtmosphericComposition.Size = new System.Drawing.Size(152, 16);
			this.l_AtmosphericComposition.TabIndex = 6;
			this.l_AtmosphericComposition.Text = "Состав атмосферы(%)";
			// 
			// l_O2
			// 
			this.l_O2.AutoSize = true;
			this.l_O2.Location = new System.Drawing.Point(13, 147);
			this.l_O2.Name = "l_O2";
			this.l_O2.Size = new System.Drawing.Size(24, 16);
			this.l_O2.TabIndex = 8;
			this.l_O2.Text = "O2";
			// 
			// l_CO2
			// 
			this.l_CO2.AutoSize = true;
			this.l_CO2.Location = new System.Drawing.Point(13, 203);
			this.l_CO2.Name = "l_CO2";
			this.l_CO2.Size = new System.Drawing.Size(33, 16);
			this.l_CO2.TabIndex = 10;
			this.l_CO2.Text = "CO2";
			// 
			// nud_CO2
			// 
			this.nud_CO2.DecimalPlaces = 1;
			this.nud_CO2.Location = new System.Drawing.Point(54, 197);
			this.nud_CO2.Name = "nud_CO2";
			this.nud_CO2.Size = new System.Drawing.Size(85, 22);
			this.nud_CO2.TabIndex = 9;
			this.nud_CO2.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
			// 
			// l_N2
			// 
			this.l_N2.AutoSize = true;
			this.l_N2.Location = new System.Drawing.Point(13, 175);
			this.l_N2.Name = "l_N2";
			this.l_N2.Size = new System.Drawing.Size(24, 16);
			this.l_N2.TabIndex = 12;
			this.l_N2.Text = "N2";
			// 
			// nud_N2
			// 
			this.nud_N2.DecimalPlaces = 1;
			this.nud_N2.Location = new System.Drawing.Point(54, 169);
			this.nud_N2.Name = "nud_N2";
			this.nud_N2.Size = new System.Drawing.Size(85, 22);
			this.nud_N2.TabIndex = 11;
			this.nud_N2.Value = new decimal(new int[] {
            77,
            0,
            0,
            0});
			// 
			// CreateAtmosphere
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(878, 619);
			this.Controls.Add(this.l_N2);
			this.Controls.Add(this.nud_N2);
			this.Controls.Add(this.l_CO2);
			this.Controls.Add(this.nud_CO2);
			this.Controls.Add(this.l_O2);
			this.Controls.Add(this.nud_O2);
			this.Controls.Add(this.l_AtmosphericComposition);
			this.Controls.Add(this.nud_Pressure);
			this.Controls.Add(this.l_Pressure);
			this.Controls.Add(this.nud_Temperature);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.nud_RoomVolume);
			this.Controls.Add(this.l_RoomVolume);
			this.Name = "CreateAtmosphere";
			this.Text = "Create_Atmosphere";
			((System.ComponentModel.ISupportInitialize)(this.nud_RoomVolume)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.nud_Temperature)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.nud_Pressure)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.nud_O2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.nud_CO2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.nud_N2)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label l_RoomVolume;
		private System.Windows.Forms.NumericUpDown nud_RoomVolume;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.NumericUpDown nud_Temperature;
		private System.Windows.Forms.NumericUpDown nud_Pressure;
		private System.Windows.Forms.Label l_Pressure;
		private System.Windows.Forms.NumericUpDown nud_O2;
		private System.Windows.Forms.Label l_AtmosphericComposition;
		private System.Windows.Forms.Label l_O2;
		private System.Windows.Forms.Label l_CO2;
		private System.Windows.Forms.NumericUpDown nud_CO2;
		private System.Windows.Forms.Label l_N2;
		private System.Windows.Forms.NumericUpDown nud_N2;
	}
}