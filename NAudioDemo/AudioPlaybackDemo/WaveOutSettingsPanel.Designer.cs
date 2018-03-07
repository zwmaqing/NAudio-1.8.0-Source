namespace NAudioDemo.AudioPlaybackDemo
{
    partial class WaveOutSettingsPanel
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.comboBoxWaveOutDevice = new System.Windows.Forms.ComboBox();
            this.comboBoxCallback = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // comboBoxWaveOutDevice
            // 
            this.comboBoxWaveOutDevice.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxWaveOutDevice.FormattingEnabled = true;
            this.comboBoxWaveOutDevice.Location = new System.Drawing.Point(7, 31);
            this.comboBoxWaveOutDevice.Name = "comboBoxWaveOutDevice";
            this.comboBoxWaveOutDevice.Size = new System.Drawing.Size(243, 20);
            this.comboBoxWaveOutDevice.TabIndex = 19;
            // 
            // comboBoxCallback
            // 
            this.comboBoxCallback.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCallback.FormattingEnabled = true;
            this.comboBoxCallback.Location = new System.Drawing.Point(129, 6);
            this.comboBoxCallback.Name = "comboBoxCallback";
            this.comboBoxCallback.Size = new System.Drawing.Size(121, 20);
            this.comboBoxCallback.TabIndex = 20;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 12);
            this.label1.TabIndex = 21;
            this.label1.Text = "Callback Mechanism:";
            // 
            // WaveOutSettingsPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxCallback);
            this.Controls.Add(this.comboBoxWaveOutDevice);
            this.Name = "WaveOutSettingsPanel";
            this.Size = new System.Drawing.Size(253, 70);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxWaveOutDevice;
        private System.Windows.Forms.ComboBox comboBoxCallback;
        private System.Windows.Forms.Label label1;
    }
}
