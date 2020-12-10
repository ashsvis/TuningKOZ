namespace TuningKOZ
{
    partial class MainForm
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.riserTuningLink = new TuningKOZ.RiserTuningLinkControl();
            this.riserTuningPlc = new TuningKOZ.RiserTuningPlcControl();
            this.riserTuningAdc = new TuningKOZ.RiserTuningAdcControl();
            this.riserTuningAlarmLevel = new TuningKOZ.RiserTuningAlarmLevelControl();
            this.riserTuningAnalogLevel = new TuningKOZ.RiserTuningAnalogLevelControl();
            this.modbusSerialPort1 = new TuningKOZ.View.ModbusSerialPort(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.cbPort = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbBaudRate = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbParity = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbSlaveID = new System.Windows.Forms.ComboBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.tabPage5.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Location = new System.Drawing.Point(14, 55);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(480, 503);
            this.tabControl1.TabIndex = 2;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.riserTuningLink);
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(458, 475);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Параметры связи";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.riserTuningPlc);
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(463, 478);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "PLC";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.riserTuningAdc);
            this.tabPage3.Location = new System.Drawing.Point(4, 24);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(472, 475);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "ADC";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.riserTuningAlarmLevel);
            this.tabPage4.Location = new System.Drawing.Point(4, 24);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(463, 478);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Аварийный уровень";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.riserTuningAnalogLevel);
            this.tabPage5.Location = new System.Drawing.Point(4, 24);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(463, 478);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Аналоговый уровень";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // riserTuningLink
            // 
            this.riserTuningLink.DataFromStorage = new int[0];
            this.riserTuningLink.Dock = System.Windows.Forms.DockStyle.Fill;
            this.riserTuningLink.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.riserTuningLink.Location = new System.Drawing.Point(3, 3);
            this.riserTuningLink.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.riserTuningLink.Name = "riserTuningLink";
            this.riserTuningLink.NodeType = 0;
            this.riserTuningLink.Size = new System.Drawing.Size(452, 469);
            this.riserTuningLink.TabIndex = 0;
            // 
            // riserTuningPlc
            // 
            this.riserTuningPlc.DataFromStorage = new int[0];
            this.riserTuningPlc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.riserTuningPlc.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.riserTuningPlc.IpAddress = null;
            this.riserTuningPlc.IpPort = 0;
            this.riserTuningPlc.Location = new System.Drawing.Point(3, 3);
            this.riserTuningPlc.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.riserTuningPlc.Name = "riserTuningPlc";
            this.riserTuningPlc.NodeAddr = 0;
            this.riserTuningPlc.NodeType = 0;
            this.riserTuningPlc.Size = new System.Drawing.Size(457, 472);
            this.riserTuningPlc.TabIndex = 0;
            // 
            // riserTuningAdc
            // 
            this.riserTuningAdc.DataFromStorage = new int[0];
            this.riserTuningAdc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.riserTuningAdc.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.riserTuningAdc.IpAddress = null;
            this.riserTuningAdc.IpPort = 0;
            this.riserTuningAdc.Location = new System.Drawing.Point(3, 3);
            this.riserTuningAdc.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.riserTuningAdc.Name = "riserTuningAdc";
            this.riserTuningAdc.NodeAddr = 0;
            this.riserTuningAdc.NodeType = 0;
            this.riserTuningAdc.Size = new System.Drawing.Size(466, 469);
            this.riserTuningAdc.TabIndex = 0;
            // 
            // riserTuningAlarmLevel
            // 
            this.riserTuningAlarmLevel.DataFromStorage = new int[0];
            this.riserTuningAlarmLevel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.riserTuningAlarmLevel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.riserTuningAlarmLevel.IpAddress = null;
            this.riserTuningAlarmLevel.IpPort = 0;
            this.riserTuningAlarmLevel.Location = new System.Drawing.Point(3, 3);
            this.riserTuningAlarmLevel.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.riserTuningAlarmLevel.Name = "riserTuningAlarmLevel";
            this.riserTuningAlarmLevel.NodeAddr = 0;
            this.riserTuningAlarmLevel.NodeType = 0;
            this.riserTuningAlarmLevel.Size = new System.Drawing.Size(457, 472);
            this.riserTuningAlarmLevel.TabIndex = 0;
            // 
            // riserTuningAnalogLevel
            // 
            this.riserTuningAnalogLevel.DataFromStorage = new int[0];
            this.riserTuningAnalogLevel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.riserTuningAnalogLevel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.riserTuningAnalogLevel.IpAddress = null;
            this.riserTuningAnalogLevel.IpPort = 0;
            this.riserTuningAnalogLevel.Location = new System.Drawing.Point(3, 3);
            this.riserTuningAnalogLevel.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.riserTuningAnalogLevel.Name = "riserTuningAnalogLevel";
            this.riserTuningAnalogLevel.NodeAddr = 0;
            this.riserTuningAnalogLevel.NodeType = 0;
            this.riserTuningAnalogLevel.Size = new System.Drawing.Size(457, 472);
            this.riserTuningAnalogLevel.TabIndex = 0;
            // 
            // modbusSerialPort1
            // 
            this.modbusSerialPort1.Address = 0;
            this.modbusSerialPort1.DataCount = 61;
            this.modbusSerialPort1.Func = 3;
            this.modbusSerialPort1.Node = 247;
            this.modbusSerialPort1.ReadTimeout = 5000;
            this.modbusSerialPort1.RtsEnable = true;
            this.modbusSerialPort1.StopBits = System.IO.Ports.StopBits.Two;
            this.modbusSerialPort1.WriteTimeout = 5000;
            this.modbusSerialPort1.ModbusDataReceived += new TuningKOZ.View.ModbusEventHandler(this.modbusSerialPort1_ModbusDataReceived);
            this.modbusSerialPort1.ModbusErrorReceived += new TuningKOZ.View.ModbusErrorHandler(this.modbusSerialPort1_ModbusErrorReceived);
            this.modbusSerialPort1.ModbusCommandOk += new System.EventHandler(this.modbusSerialPort1_ModbusCommandOk);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Порт:";
            // 
            // cbPort
            // 
            this.cbPort.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPort.FormattingEnabled = true;
            this.cbPort.Location = new System.Drawing.Point(59, 12);
            this.cbPort.Name = "cbPort";
            this.cbPort.Size = new System.Drawing.Size(65, 23);
            this.cbPort.TabIndex = 0;
            this.cbPort.SelectionChangeCommitted += new System.EventHandler(this.cbPort_SelectionChangeCommitted);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(130, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Скорость:";
            // 
            // cbBaudRate
            // 
            this.cbBaudRate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbBaudRate.FormattingEnabled = true;
            this.cbBaudRate.Location = new System.Drawing.Point(198, 12);
            this.cbBaudRate.Name = "cbBaudRate";
            this.cbBaudRate.Size = new System.Drawing.Size(68, 23);
            this.cbBaudRate.TabIndex = 1;
            this.cbBaudRate.SelectionChangeCommitted += new System.EventHandler(this.cbBaudRate_SelectionChangeCommitted);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(272, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 15);
            this.label3.TabIndex = 1;
            this.label3.Text = "Паритет:";
            // 
            // cbParity
            // 
            this.cbParity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbParity.FormattingEnabled = true;
            this.cbParity.Location = new System.Drawing.Point(333, 12);
            this.cbParity.Name = "cbParity";
            this.cbParity.Size = new System.Drawing.Size(58, 23);
            this.cbParity.TabIndex = 1;
            this.cbParity.SelectionChangeCommitted += new System.EventHandler(this.cbParity_SelectionChangeCommitted);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(397, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 15);
            this.label4.TabIndex = 1;
            this.label4.Text = "Адрес:";
            // 
            // cbSlaveID
            // 
            this.cbSlaveID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSlaveID.FormattingEnabled = true;
            this.cbSlaveID.Location = new System.Drawing.Point(446, 12);
            this.cbSlaveID.Name = "cbSlaveID";
            this.cbSlaveID.Size = new System.Drawing.Size(48, 23);
            this.cbSlaveID.TabIndex = 1;
            this.cbSlaveID.SelectionChangeCommitted += new System.EventHandler(this.cbSlaveID_SelectionChangeCommitted);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(506, 570);
            this.Controls.Add(this.cbSlaveID);
            this.Controls.Add(this.cbParity);
            this.Controls.Add(this.cbBaudRate);
            this.Controls.Add(this.cbPort);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Утилита настройки контроллера ООО \"КОЗ\"";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            this.tabPage5.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private RiserTuningLinkControl riserTuningLink;
        private RiserTuningPlcControl riserTuningPlc;
        private System.Windows.Forms.TabPage tabPage3;
        private RiserTuningAdcControl riserTuningAdc;
        private System.Windows.Forms.TabPage tabPage4;
        private RiserTuningAlarmLevelControl riserTuningAlarmLevel;
        private System.Windows.Forms.TabPage tabPage5;
        private RiserTuningAnalogLevelControl riserTuningAnalogLevel;
        private View.ModbusSerialPort modbusSerialPort1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbPort;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbBaudRate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbParity;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbSlaveID;
    }
}

