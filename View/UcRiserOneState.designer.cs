namespace TuningKOZ
{
    partial class UcRiserOneState
    {
        /// <summary> 
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Обязательный метод для поддержки конструктора - не изменяйте 
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tlpLeftToRight = new System.Windows.Forms.TableLayoutPanel();
            this.lbTextRight = new System.Windows.Forms.Label();
            this.lbText = new System.Windows.Forms.Label();
            this.pbLamp = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.tlpLeftToRight.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLamp)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.tlpLeftToRight, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(289, 22);
            this.tableLayoutPanel1.TabIndex = 4;
            // 
            // tlpLeftToRight
            // 
            this.tlpLeftToRight.ColumnCount = 3;
            this.tlpLeftToRight.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpLeftToRight.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tlpLeftToRight.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpLeftToRight.Controls.Add(this.lbTextRight, 0, 0);
            this.tlpLeftToRight.Controls.Add(this.lbText, 2, 0);
            this.tlpLeftToRight.Controls.Add(this.pbLamp, 1, 0);
            this.tlpLeftToRight.Dock = System.Windows.Forms.DockStyle.Top;
            this.tlpLeftToRight.Location = new System.Drawing.Point(0, 0);
            this.tlpLeftToRight.Margin = new System.Windows.Forms.Padding(0);
            this.tlpLeftToRight.Name = "tlpLeftToRight";
            this.tlpLeftToRight.RowCount = 2;
            this.tlpLeftToRight.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpLeftToRight.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpLeftToRight.Size = new System.Drawing.Size(289, 22);
            this.tlpLeftToRight.TabIndex = 2;
            // 
            // lbTextRight
            // 
            this.lbTextRight.AutoEllipsis = true;
            this.lbTextRight.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbTextRight.Location = new System.Drawing.Point(4, 0);
            this.lbTextRight.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbTextRight.Name = "lbTextRight";
            this.lbTextRight.Size = new System.Drawing.Size(127, 22);
            this.lbTextRight.TabIndex = 1;
            this.lbTextRight.Text = "Некоторый текст";
            this.lbTextRight.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbText
            // 
            this.lbText.AutoEllipsis = true;
            this.lbText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbText.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbText.Location = new System.Drawing.Point(169, 0);
            this.lbText.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbText.Name = "lbText";
            this.lbText.Size = new System.Drawing.Size(128, 22);
            this.lbText.TabIndex = 1;
            this.lbText.Text = "Некоторый текст";
            this.lbText.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pbLamp
            // 
            this.pbLamp.Enabled = false;
            this.pbLamp.Location = new System.Drawing.Point(135, 2);
            this.pbLamp.Margin = new System.Windows.Forms.Padding(0, 2, 0, 0);
            this.pbLamp.Name = "pbLamp";
            this.pbLamp.Size = new System.Drawing.Size(18, 19);
            this.pbLamp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbLamp.TabIndex = 0;
            this.pbLamp.TabStop = false;
            this.pbLamp.Paint += new System.Windows.Forms.PaintEventHandler(this.pbLamp_Paint);
            // 
            // UcRiserOneState
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "UcRiserOneState";
            this.Size = new System.Drawing.Size(289, 24);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tlpLeftToRight.ResumeLayout(false);
            this.tlpLeftToRight.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLamp)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tlpLeftToRight;
        private System.Windows.Forms.Label lbTextRight;
        private System.Windows.Forms.Label lbText;
        private System.Windows.Forms.PictureBox pbLamp;
    }
}
