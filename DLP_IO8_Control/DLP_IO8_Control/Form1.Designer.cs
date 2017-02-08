namespace DLP_IO8_Control
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
            this.buttonStart = new System.Windows.Forms.Button();
            this.buttonStop = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.labelValue = new System.Windows.Forms.Label();
            this.cBoxSerialPort = new System.Windows.Forms.ComboBox();
            this.btnManager = new System.Windows.Forms.Button();
            this.btnConect = new System.Windows.Forms.Button();
            this.gBoxOptions = new System.Windows.Forms.GroupBox();
            this.rBtnASCII = new System.Windows.Forms.RadioButton();
            this.rBtnBinary = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.rBtnCelsius = new System.Windows.Forms.RadioButton();
            this.rBtnFarenheit = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.gBoxOptions.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonStart
            // 
            this.buttonStart.Location = new System.Drawing.Point(25, 227);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(75, 23);
            this.buttonStart.TabIndex = 0;
            this.buttonStart.Text = "Start";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // buttonStop
            // 
            this.buttonStop.Location = new System.Drawing.Point(187, 227);
            this.buttonStop.Name = "buttonStop";
            this.buttonStop.Size = new System.Drawing.Size(75, 23);
            this.buttonStop.TabIndex = 1;
            this.buttonStop.Text = "Stop";
            this.buttonStop.UseVisualStyleBackColor = true;
            this.buttonStop.Click += new System.EventHandler(this.buttonStop_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(125, 39);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(75, 23);
            this.btnRefresh.TabIndex = 2;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // labelValue
            // 
            this.labelValue.AutoSize = true;
            this.labelValue.Location = new System.Drawing.Point(48, 136);
            this.labelValue.Name = "labelValue";
            this.labelValue.Size = new System.Drawing.Size(35, 13);
            this.labelValue.TabIndex = 3;
            this.labelValue.Text = "label1";
            // 
            // cBoxSerialPort
            // 
            this.cBoxSerialPort.FormattingEnabled = true;
            this.cBoxSerialPort.Location = new System.Drawing.Point(12, 41);
            this.cBoxSerialPort.Name = "cBoxSerialPort";
            this.cBoxSerialPort.Size = new System.Drawing.Size(107, 21);
            this.cBoxSerialPort.TabIndex = 4;
            // 
            // btnManager
            // 
            this.btnManager.Location = new System.Drawing.Point(12, 12);
            this.btnManager.Name = "btnManager";
            this.btnManager.Size = new System.Drawing.Size(107, 23);
            this.btnManager.TabIndex = 5;
            this.btnManager.Text = "Open Manager";
            this.btnManager.UseVisualStyleBackColor = true;
            this.btnManager.Click += new System.EventHandler(this.btnManager_Click);
            // 
            // btnConect
            // 
            this.btnConect.Location = new System.Drawing.Point(125, 12);
            this.btnConect.Name = "btnConect";
            this.btnConect.Size = new System.Drawing.Size(75, 23);
            this.btnConect.TabIndex = 6;
            this.btnConect.Text = "Conect";
            this.btnConect.UseVisualStyleBackColor = true;
            this.btnConect.Click += new System.EventHandler(this.btnConect_Click);
            // 
            // gBoxOptions
            // 
            this.gBoxOptions.Controls.Add(this.panel2);
            this.gBoxOptions.Controls.Add(this.panel1);
            this.gBoxOptions.Controls.Add(this.label2);
            this.gBoxOptions.Controls.Add(this.label1);
            this.gBoxOptions.Location = new System.Drawing.Point(218, 12);
            this.gBoxOptions.Name = "gBoxOptions";
            this.gBoxOptions.Size = new System.Drawing.Size(229, 61);
            this.gBoxOptions.TabIndex = 7;
            this.gBoxOptions.TabStop = false;
            this.gBoxOptions.Text = "Options";
            // 
            // rBtnASCII
            // 
            this.rBtnASCII.AutoSize = true;
            this.rBtnASCII.Location = new System.Drawing.Point(4, 4);
            this.rBtnASCII.Name = "rBtnASCII";
            this.rBtnASCII.Size = new System.Drawing.Size(52, 17);
            this.rBtnASCII.TabIndex = 0;
            this.rBtnASCII.TabStop = true;
            this.rBtnASCII.Text = "ASCII";
            this.rBtnASCII.UseVisualStyleBackColor = true;
            // 
            // rBtnBinary
            // 
            this.rBtnBinary.AutoSize = true;
            this.rBtnBinary.Location = new System.Drawing.Point(66, 3);
            this.rBtnBinary.Name = "rBtnBinary";
            this.rBtnBinary.Size = new System.Drawing.Size(56, 17);
            this.rBtnBinary.TabIndex = 1;
            this.rBtnBinary.TabStop = true;
            this.rBtnBinary.Text = "Binariy";
            this.rBtnBinary.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Return Value in:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Return Value in:";
            // 
            // rBtnCelsius
            // 
            this.rBtnCelsius.AutoSize = true;
            this.rBtnCelsius.Location = new System.Drawing.Point(3, 3);
            this.rBtnCelsius.Name = "rBtnCelsius";
            this.rBtnCelsius.Size = new System.Drawing.Size(58, 17);
            this.rBtnCelsius.TabIndex = 4;
            this.rBtnCelsius.TabStop = true;
            this.rBtnCelsius.Text = "Celsius";
            this.rBtnCelsius.UseVisualStyleBackColor = true;
            // 
            // rBtnFarenheit
            // 
            this.rBtnFarenheit.AutoSize = true;
            this.rBtnFarenheit.Location = new System.Drawing.Point(63, 4);
            this.rBtnFarenheit.Name = "rBtnFarenheit";
            this.rBtnFarenheit.Size = new System.Drawing.Size(69, 17);
            this.rBtnFarenheit.TabIndex = 5;
            this.rBtnFarenheit.TabStop = true;
            this.rBtnFarenheit.Text = "Farenheit";
            this.rBtnFarenheit.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.rBtnASCII);
            this.panel1.Controls.Add(this.rBtnBinary);
            this.panel1.Location = new System.Drawing.Point(90, 10);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(131, 24);
            this.panel1.TabIndex = 8;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.rBtnCelsius);
            this.panel2.Controls.Add(this.rBtnFarenheit);
            this.panel2.Location = new System.Drawing.Point(90, 31);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(131, 24);
            this.panel2.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(541, 462);
            this.Controls.Add(this.gBoxOptions);
            this.Controls.Add(this.btnConect);
            this.Controls.Add(this.btnManager);
            this.Controls.Add(this.cBoxSerialPort);
            this.Controls.Add(this.labelValue);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.buttonStop);
            this.Controls.Add(this.buttonStart);
            this.Name = "Form1";
            this.Text = "Form1";
            this.gBoxOptions.ResumeLayout(false);
            this.gBoxOptions.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.Button buttonStop;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Label labelValue;
        private System.Windows.Forms.ComboBox cBoxSerialPort;
        private System.Windows.Forms.Button btnManager;
        private System.Windows.Forms.Button btnConect;
        private System.Windows.Forms.GroupBox gBoxOptions;
        private System.Windows.Forms.RadioButton rBtnASCII;
        private System.Windows.Forms.RadioButton rBtnBinary;
        private System.Windows.Forms.RadioButton rBtnFarenheit;
        private System.Windows.Forms.RadioButton rBtnCelsius;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
    }
}

