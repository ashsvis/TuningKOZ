namespace TuningKOZ.View
{
    partial class StatusForm
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
            this.riserStatus = new TuningKOZ.RiserStatusControl();
            this.SuspendLayout();
            // 
            // riserStatus
            // 
            this.riserStatus.Font = new System.Drawing.Font("Courier New", 9.75F);
            this.riserStatus.Location = new System.Drawing.Point(1, 1);
            this.riserStatus.Margin = new System.Windows.Forms.Padding(4);
            this.riserStatus.Name = "riserStatus";
            this.riserStatus.NodeType = 0;
            this.riserStatus.Size = new System.Drawing.Size(459, 594);
            this.riserStatus.TabIndex = 0;
            // 
            // StatusForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(459, 598);
            this.Controls.Add(this.riserStatus);
            this.DataBindings.Add(new System.Windows.Forms.Binding("Location", global::TuningKOZ.Properties.Settings.Default, "StatusFormLocation", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Location = global::TuningKOZ.Properties.Settings.Default.StatusFormLocation;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "StatusForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Статус стояка";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.StatusForm_FormClosing);
            this.Load += new System.EventHandler(this.StatusForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private RiserStatusControl riserStatus;
    }
}