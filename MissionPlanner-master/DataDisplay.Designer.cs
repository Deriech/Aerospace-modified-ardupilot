namespace MissionPlanner
{
    partial class DataDisplay
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
            this.altitudeValue = new MissionPlanner.Controls.MyLabel();
            this.altitudeLabel = new MissionPlanner.Controls.MyLabel();
            this.payloadLabel = new MissionPlanner.Controls.MyLabel();
            this.payloadAltitudeLabel = new MissionPlanner.Controls.MyLabel();
            this.longitudeValue = new MissionPlanner.Controls.MyLabel();
            this.cdaAltitudeValue = new MissionPlanner.Controls.MyLabel();
            this.cdaAltitudeLabel = new MissionPlanner.Controls.MyLabel();
            this.cdaLabel = new MissionPlanner.Controls.MyLabel();
            this.waterIndicatorIcon = new System.Windows.Forms.PictureBox();
            this.pingIndicatorIcon = new System.Windows.Forms.PictureBox();
            this.latitudeLabel = new MissionPlanner.Controls.MyLabel();
            this.latitudeValue = new MissionPlanner.Controls.MyLabel();
            this.longitudeLabel = new MissionPlanner.Controls.MyLabel();
            this.groundSpeedLabel = new MissionPlanner.Controls.MyLabel();
            this.airSpeedValue = new MissionPlanner.Controls.MyLabel();
            this.airSpeedLabel = new MissionPlanner.Controls.MyLabel();
            this.groundSpeedValue = new MissionPlanner.Controls.MyLabel();
            this.payloadAltitudeValue = new MissionPlanner.Controls.MyLabel();
            this.altitudeCalibration = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.waterIndicatorIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pingIndicatorIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // altitudeValue
            // 
            this.altitudeValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F);
            this.altitudeValue.Location = new System.Drawing.Point(383, 227);
            this.altitudeValue.Name = "altitudeValue";
            this.altitudeValue.resize = false;
            this.altitudeValue.Size = new System.Drawing.Size(875, 82);
            this.altitudeValue.TabIndex = 2;
            this.altitudeValue.Text = "0.0";
            // 
            // altitudeLabel
            // 
            this.altitudeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F);
            this.altitudeLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.altitudeLabel.Location = new System.Drawing.Point(12, 227);
            this.altitudeLabel.Name = "altitudeLabel";
            this.altitudeLabel.resize = false;
            this.altitudeLabel.Size = new System.Drawing.Size(365, 73);
            this.altitudeLabel.TabIndex = 1;
            this.altitudeLabel.Text = "Altitude:";
            // 
            // payloadLabel
            // 
            this.payloadLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F);
            this.payloadLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.payloadLabel.Location = new System.Drawing.Point(12, 12);
            this.payloadLabel.Name = "payloadLabel";
            this.payloadLabel.resize = false;
            this.payloadLabel.Size = new System.Drawing.Size(574, 102);
            this.payloadLabel.TabIndex = 6;
            this.payloadLabel.Text = "12 H 2 WB";
            // 
            // payloadAltitudeLabel
            // 
            this.payloadAltitudeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F);
            this.payloadAltitudeLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.payloadAltitudeLabel.Location = new System.Drawing.Point(697, 41);
            this.payloadAltitudeLabel.Name = "payloadAltitudeLabel";
            this.payloadAltitudeLabel.resize = false;
            this.payloadAltitudeLabel.Size = new System.Drawing.Size(404, 73);
            this.payloadAltitudeLabel.TabIndex = 7;
            this.payloadAltitudeLabel.Text = "Altitude:";
            // 
            // longitudeValue
            // 
            this.longitudeValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.longitudeValue.Location = new System.Drawing.Point(362, 356);
            this.longitudeValue.Name = "longitudeValue";
            this.longitudeValue.resize = false;
            this.longitudeValue.Size = new System.Drawing.Size(387, 58);
            this.longitudeValue.TabIndex = 8;
            this.longitudeValue.Text = "0.0";
            // 
            // cdaAltitudeValue
            // 
            this.cdaAltitudeValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F);
            this.cdaAltitudeValue.Location = new System.Drawing.Point(1071, 120);
            this.cdaAltitudeValue.Name = "cdaAltitudeValue";
            this.cdaAltitudeValue.resize = false;
            this.cdaAltitudeValue.Size = new System.Drawing.Size(854, 82);
            this.cdaAltitudeValue.TabIndex = 11;
            this.cdaAltitudeValue.Text = "0.0";
            // 
            // cdaAltitudeLabel
            // 
            this.cdaAltitudeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F);
            this.cdaAltitudeLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cdaAltitudeLabel.Location = new System.Drawing.Point(697, 120);
            this.cdaAltitudeLabel.Name = "cdaAltitudeLabel";
            this.cdaAltitudeLabel.resize = false;
            this.cdaAltitudeLabel.Size = new System.Drawing.Size(365, 73);
            this.cdaAltitudeLabel.TabIndex = 10;
            this.cdaAltitudeLabel.Text = "Altitude:";
            // 
            // cdaLabel
            // 
            this.cdaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F);
            this.cdaLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cdaLabel.Location = new System.Drawing.Point(12, 120);
            this.cdaLabel.Name = "cdaLabel";
            this.cdaLabel.resize = false;
            this.cdaLabel.Size = new System.Drawing.Size(460, 101);
            this.cdaLabel.TabIndex = 9;
            this.cdaLabel.Text = "CDA";
            // 
            // waterIndicatorIcon
            // 
            this.waterIndicatorIcon.BackColor = System.Drawing.Color.Red;
            this.waterIndicatorIcon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.waterIndicatorIcon.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.waterIndicatorIcon.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.waterIndicatorIcon.Location = new System.Drawing.Point(592, 18);
            this.waterIndicatorIcon.Name = "waterIndicatorIcon";
            this.waterIndicatorIcon.Size = new System.Drawing.Size(99, 96);
            this.waterIndicatorIcon.TabIndex = 12;
            this.waterIndicatorIcon.TabStop = false;
            // 
            // pingIndicatorIcon
            // 
            this.pingIndicatorIcon.BackColor = System.Drawing.Color.Red;
            this.pingIndicatorIcon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pingIndicatorIcon.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pingIndicatorIcon.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.pingIndicatorIcon.Location = new System.Drawing.Point(592, 120);
            this.pingIndicatorIcon.Name = "pingIndicatorIcon";
            this.pingIndicatorIcon.Size = new System.Drawing.Size(99, 96);
            this.pingIndicatorIcon.TabIndex = 13;
            this.pingIndicatorIcon.TabStop = false;
            // 
            // latitudeLabel
            // 
            this.latitudeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.latitudeLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.latitudeLabel.Location = new System.Drawing.Point(12, 306);
            this.latitudeLabel.Name = "latitudeLabel";
            this.latitudeLabel.resize = false;
            this.latitudeLabel.Size = new System.Drawing.Size(387, 44);
            this.latitudeLabel.TabIndex = 14;
            this.latitudeLabel.Text = "Latitude:";
            // 
            // latitudeValue
            // 
            this.latitudeValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.latitudeValue.Location = new System.Drawing.Point(362, 311);
            this.latitudeValue.Name = "latitudeValue";
            this.latitudeValue.resize = false;
            this.latitudeValue.Size = new System.Drawing.Size(387, 53);
            this.latitudeValue.TabIndex = 15;
            this.latitudeValue.Text = "0.0";
            // 
            // longitudeLabel
            // 
            this.longitudeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.longitudeLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.longitudeLabel.Location = new System.Drawing.Point(12, 356);
            this.longitudeLabel.Name = "longitudeLabel";
            this.longitudeLabel.resize = false;
            this.longitudeLabel.Size = new System.Drawing.Size(245, 53);
            this.longitudeLabel.TabIndex = 16;
            this.longitudeLabel.Text = "Longitude:";
            this.longitudeLabel.Click += new System.EventHandler(this.longitudeLabel_Click);
            // 
            // groundSpeedLabel
            // 
            this.groundSpeedLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groundSpeedLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.groundSpeedLabel.Location = new System.Drawing.Point(12, 465);
            this.groundSpeedLabel.Name = "groundSpeedLabel";
            this.groundSpeedLabel.resize = false;
            this.groundSpeedLabel.Size = new System.Drawing.Size(344, 44);
            this.groundSpeedLabel.TabIndex = 20;
            this.groundSpeedLabel.Text = "Ground Speed:";
            // 
            // airSpeedValue
            // 
            this.airSpeedValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.airSpeedValue.Location = new System.Drawing.Point(362, 406);
            this.airSpeedValue.Name = "airSpeedValue";
            this.airSpeedValue.resize = false;
            this.airSpeedValue.Size = new System.Drawing.Size(387, 53);
            this.airSpeedValue.TabIndex = 19;
            this.airSpeedValue.Text = "0.0";
            // 
            // airSpeedLabel
            // 
            this.airSpeedLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.airSpeedLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.airSpeedLabel.Location = new System.Drawing.Point(12, 415);
            this.airSpeedLabel.Name = "airSpeedLabel";
            this.airSpeedLabel.resize = false;
            this.airSpeedLabel.Size = new System.Drawing.Size(387, 44);
            this.airSpeedLabel.TabIndex = 18;
            this.airSpeedLabel.Text = "Air Speed:";
            // 
            // groundSpeedValue
            // 
            this.groundSpeedValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groundSpeedValue.Location = new System.Drawing.Point(362, 456);
            this.groundSpeedValue.Name = "groundSpeedValue";
            this.groundSpeedValue.resize = false;
            this.groundSpeedValue.Size = new System.Drawing.Size(387, 53);
            this.groundSpeedValue.TabIndex = 17;
            this.groundSpeedValue.Text = "0.0";
            // 
            // payloadAltitudeValue
            // 
            this.payloadAltitudeValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F);
            this.payloadAltitudeValue.Location = new System.Drawing.Point(1071, 41);
            this.payloadAltitudeValue.Name = "payloadAltitudeValue";
            this.payloadAltitudeValue.resize = false;
            this.payloadAltitudeValue.Size = new System.Drawing.Size(854, 82);
            this.payloadAltitudeValue.TabIndex = 21;
            this.payloadAltitudeValue.Text = "0.0";
            // 
            // altitudeCalibration
            // 
            this.altitudeCalibration.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.altitudeCalibration.Location = new System.Drawing.Point(12, 515);
            this.altitudeCalibration.Name = "altitudeCalibration";
            this.altitudeCalibration.Size = new System.Drawing.Size(188, 33);
            this.altitudeCalibration.TabIndex = 22;
            this.altitudeCalibration.Text = "Altitude Calibration";
            this.altitudeCalibration.UseVisualStyleBackColor = true;
            this.altitudeCalibration.Click += new System.EventHandler(this.altitudeCalibration_Click);
            // 
            // DataDisplay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1585, 561);
            this.Controls.Add(this.altitudeCalibration);
            this.Controls.Add(this.groundSpeedLabel);
            this.Controls.Add(this.airSpeedValue);
            this.Controls.Add(this.airSpeedLabel);
            this.Controls.Add(this.groundSpeedValue);
            this.Controls.Add(this.longitudeLabel);
            this.Controls.Add(this.latitudeValue);
            this.Controls.Add(this.latitudeLabel);
            this.Controls.Add(this.pingIndicatorIcon);
            this.Controls.Add(this.waterIndicatorIcon);
            this.Controls.Add(this.cdaAltitudeValue);
            this.Controls.Add(this.cdaAltitudeLabel);
            this.Controls.Add(this.cdaLabel);
            this.Controls.Add(this.longitudeValue);
            this.Controls.Add(this.payloadLabel);
            this.Controls.Add(this.altitudeValue);
            this.Controls.Add(this.altitudeLabel);
            this.Controls.Add(this.payloadAltitudeValue);
            this.Controls.Add(this.payloadAltitudeLabel);
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Name = "DataDisplay";
            this.Text = "Data Aquisition System";
            this.Load += new System.EventHandler(this.DataDisplay_Load);
            ((System.ComponentModel.ISupportInitialize)(this.waterIndicatorIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pingIndicatorIcon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Controls.MyLabel altitudeValue;
        private Controls.MyLabel altitudeLabel;
        private Controls.MyLabel payloadLabel;
        private Controls.MyLabel payloadAltitudeLabel;
        private Controls.MyLabel longitudeValue;
        private Controls.MyLabel cdaAltitudeValue;
        private Controls.MyLabel cdaAltitudeLabel;
        private Controls.MyLabel cdaLabel;
        private System.Windows.Forms.PictureBox waterIndicatorIcon;
        private System.Windows.Forms.PictureBox pingIndicatorIcon;
        private Controls.MyLabel latitudeLabel;
        private Controls.MyLabel latitudeValue;
        private Controls.MyLabel longitudeLabel;
        private Controls.MyLabel groundSpeedLabel;
        private Controls.MyLabel airSpeedValue;
        private Controls.MyLabel airSpeedLabel;
        private Controls.MyLabel groundSpeedValue;
        private Controls.MyLabel payloadAltitudeValue;
        private System.Windows.Forms.Button altitudeCalibration;
    }
}