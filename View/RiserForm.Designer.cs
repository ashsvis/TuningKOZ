namespace TuningKOZ.View
{
    partial class RiserForm
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
            this.chboxSelected = new System.Windows.Forms.CheckBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.riserControl = new TuningKOZ.View.RiserControl(this.components);
            this.SuspendLayout();
            // 
            // chboxSelected
            // 
            this.chboxSelected.AutoSize = true;
            this.chboxSelected.Location = new System.Drawing.Point(8, 62);
            this.chboxSelected.Name = "chboxSelected";
            this.chboxSelected.Size = new System.Drawing.Size(15, 14);
            this.chboxSelected.TabIndex = 1;
            this.chboxSelected.UseVisualStyleBackColor = true;
            // 
            // btnStart
            // 
            this.btnStart.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnStart.Location = new System.Drawing.Point(1, 78);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(54, 23);
            this.btnStart.TabIndex = 2;
            this.btnStart.Text = "Старт";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnStop
            // 
            this.btnStop.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnStop.Location = new System.Drawing.Point(94, 78);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(54, 23);
            this.btnStop.TabIndex = 2;
            this.btnStop.Text = "Стоп";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // riserControl
            // 
            this.riserControl.Location = new System.Drawing.Point(1, 1);
            this.riserControl.Name = "riserControl";
            this.riserControl.Size = new System.Drawing.Size(148, 101);
            this.riserControl.TabIndex = 0;
            this.riserControl.Text = "riserControl1";
            this.riserControl.DoubleClick += new System.EventHandler(this.riserControl_DoubleClick);
            // 
            // RiserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(149, 102);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.chboxSelected);
            this.Controls.Add(this.riserControl);
            this.DataBindings.Add(new System.Windows.Forms.Binding("Location", global::TuningKOZ.Properties.Settings.Default, "RiserFormLocation", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Location = global::TuningKOZ.Properties.Settings.Default.RiserFormLocation;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "RiserForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Панель стояка налива";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.RiserForm_FormClosing);
            this.Load += new System.EventHandler(this.RiserForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private RiserControl riserControl;
        private System.Windows.Forms.CheckBox chboxSelected;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnStop;
    }
}