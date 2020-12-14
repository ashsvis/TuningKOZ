namespace TuningKOZ.View
{
    partial class WorkDiagramForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WorkDiagramForm));
            this.riserWorkDiagram = new TuningKOZ.RiserWorkDiagramControl();
            this.SuspendLayout();
            // 
            // riserWorkDiagram
            // 
            this.riserWorkDiagram.BackColor = System.Drawing.Color.White;
            this.riserWorkDiagram.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("riserWorkDiagram.BackgroundImage")));
            this.riserWorkDiagram.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.riserWorkDiagram.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.riserWorkDiagram.Location = new System.Drawing.Point(0, 0);
            this.riserWorkDiagram.Margin = new System.Windows.Forms.Padding(4);
            this.riserWorkDiagram.Name = "riserWorkDiagram";
            this.riserWorkDiagram.NodeType = 0;
            this.riserWorkDiagram.Size = new System.Drawing.Size(1296, 609);
            this.riserWorkDiagram.TabIndex = 0;
            // 
            // WorkDiagramForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1297, 610);
            this.Controls.Add(this.riserWorkDiagram);
            this.DataBindings.Add(new System.Windows.Forms.Binding("Location", global::TuningKOZ.Properties.Settings.Default, "WorkDuagramFormLocation", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Location = global::TuningKOZ.Properties.Settings.Default.WorkDuagramFormLocation;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "WorkDiagramForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Диаграмма работы стояка";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.WorkDiagramForm_FormClosing);
            this.Load += new System.EventHandler(this.WorkDiagramForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private RiserWorkDiagramControl riserWorkDiagram;
    }
}