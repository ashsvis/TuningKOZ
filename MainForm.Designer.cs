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
            this.timerFetch = new System.Windows.Forms.Timer(this.components);
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.riserTuningLink = new TuningKOZ.RiserTuningLinkControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.riserTuningPlc = new TuningKOZ.RiserTuningPlcControl();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.riserTuningAdc = new TuningKOZ.RiserTuningAdcControl();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.riserTuningAlarmLevel = new TuningKOZ.RiserTuningAlarmLevelControl();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.riserTuningAnalogLevel = new TuningKOZ.RiserTuningAnalogLevelControl();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.riserStatus = new TuningKOZ.RiserStatusControl();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.tabPage5.SuspendLayout();
            this.tabPage6.SuspendLayout();
            this.SuspendLayout();
            // 
            // timerFetch
            // 
            this.timerFetch.Interval = 1000;
            this.timerFetch.Tick += new System.EventHandler(this.timerFetch_Tick);
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
            this.tabControl1.Controls.Add(this.tabPage6);
            this.tabControl1.Location = new System.Drawing.Point(14, 14);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(662, 640);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.riserTuningLink);
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(654, 612);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Параметры связи";
            this.tabPage1.UseVisualStyleBackColor = true;
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
            this.riserTuningLink.Size = new System.Drawing.Size(648, 606);
            this.riserTuningLink.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.riserTuningPlc);
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(654, 612);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "PLC";
            this.tabPage2.UseVisualStyleBackColor = true;
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
            this.riserTuningPlc.Size = new System.Drawing.Size(648, 606);
            this.riserTuningPlc.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.riserTuningAdc);
            this.tabPage3.Location = new System.Drawing.Point(4, 24);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(654, 612);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "ADC";
            this.tabPage3.UseVisualStyleBackColor = true;
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
            this.riserTuningAdc.Size = new System.Drawing.Size(648, 606);
            this.riserTuningAdc.TabIndex = 0;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.riserTuningAlarmLevel);
            this.tabPage4.Location = new System.Drawing.Point(4, 24);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(654, 612);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Аварийный уровень";
            this.tabPage4.UseVisualStyleBackColor = true;
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
            this.riserTuningAlarmLevel.Size = new System.Drawing.Size(648, 606);
            this.riserTuningAlarmLevel.TabIndex = 0;
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.riserTuningAnalogLevel);
            this.tabPage5.Location = new System.Drawing.Point(4, 24);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(654, 612);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Аналоговый уровень";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // riserTuningAnalogLevel
            // 
            this.riserTuningAnalogLevel.DataFromStorage = new int[0];
            this.riserTuningAnalogLevel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.riserTuningAnalogLevel.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.riserTuningAnalogLevel.IpAddress = null;
            this.riserTuningAnalogLevel.IpPort = 0;
            this.riserTuningAnalogLevel.Location = new System.Drawing.Point(3, 3);
            this.riserTuningAnalogLevel.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.riserTuningAnalogLevel.Name = "riserTuningAnalogLevel";
            this.riserTuningAnalogLevel.NodeAddr = 0;
            this.riserTuningAnalogLevel.NodeType = 0;
            this.riserTuningAnalogLevel.Size = new System.Drawing.Size(648, 606);
            this.riserTuningAnalogLevel.TabIndex = 0;
            // 
            // tabPage6
            // 
            this.tabPage6.Controls.Add(this.riserStatus);
            this.tabPage6.Location = new System.Drawing.Point(4, 24);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage6.Size = new System.Drawing.Size(654, 612);
            this.tabPage6.TabIndex = 5;
            this.tabPage6.Text = "Статус";
            this.tabPage6.UseVisualStyleBackColor = true;
            // 
            // riserStatus
            // 
            this.riserStatus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.riserStatus.Font = new System.Drawing.Font("Courier New", 9.75F);
            this.riserStatus.Location = new System.Drawing.Point(3, 3);
            this.riserStatus.Margin = new System.Windows.Forms.Padding(4);
            this.riserStatus.Name = "riserStatus";
            this.riserStatus.NodeType = 0;
            this.riserStatus.Size = new System.Drawing.Size(648, 606);
            this.riserStatus.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(690, 667);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Утилита настройки контроллера ООО \"КОЗ\"";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            this.tabPage5.ResumeLayout(false);
            this.tabPage6.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer timerFetch;
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
        private System.Windows.Forms.TabPage tabPage6;
        private RiserStatusControl riserStatus;
    }
}

