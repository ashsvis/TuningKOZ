﻿namespace TuningKOZ
{
	partial class RiserTuningAlarmLevelControl
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the control.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.btnEEPROM = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.lbHR2C = new System.Windows.Forms.Label();
            this.lbHR25 = new System.Windows.Forms.Label();
            this.lbHR2D = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.lbHR2E = new System.Windows.Forms.Label();
            this.btnRestore = new System.Windows.Forms.Button();
            this.lbHR2F = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lbHR14_8 = new System.Windows.Forms.Label();
            this.lbHR14_9 = new System.Windows.Forms.Label();
            this.lbHR21 = new System.Windows.Forms.Label();
            this.lbHR20 = new System.Windows.Forms.Label();
            this.edHR2C = new System.Windows.Forms.TextBox();
            this.edHR2D = new System.Windows.Forms.TextBox();
            this.edHR2E = new System.Windows.Forms.TextBox();
            this.edHR2F = new System.Windows.Forms.TextBox();
            this.edHR21 = new System.Windows.Forms.TextBox();
            this.edHR20 = new System.Windows.Forms.TextBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.cbHR14_8 = new System.Windows.Forms.ComboBox();
            this.cbHR14_9 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCopy = new System.Windows.Forms.Button();
            this.btnCopyFromStorage = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoEllipsis = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(4, 0);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(269, 22);
            this.label3.TabIndex = 3;
            this.label3.Text = "Заводской номер:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.AutoEllipsis = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(4, 27);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(269, 22);
            this.label4.TabIndex = 3;
            this.label4.Text = "Ток на выходе сигнализатора (мА):";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            this.label5.AutoEllipsis = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(4, 49);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(269, 22);
            this.label5.TabIndex = 3;
            this.label5.Text = "Порог переключения (мкА):";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label6
            // 
            this.label6.AutoEllipsis = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(4, 76);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(269, 22);
            this.label6.TabIndex = 3;
            this.label6.Text = "Гистерезис переключения (мкА):";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(340, 7);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 19);
            this.label1.TabIndex = 5;
            this.label1.Text = "R";
            // 
            // label7
            // 
            this.label7.AutoEllipsis = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(4, 103);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(269, 22);
            this.label7.TabIndex = 3;
            this.label7.Text = "Задержка переключения  (мс):";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label8
            // 
            this.label8.AutoEllipsis = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(4, 130);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(269, 22);
            this.label8.TabIndex = 3;
            this.label8.Text = "Инверсия токового сигнала:";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label9
            // 
            this.label9.AutoEllipsis = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(4, 157);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(269, 22);
            this.label9.TabIndex = 3;
            this.label9.Text = "Инверсия релейного сигнала:";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label12
            // 
            this.label12.AutoEllipsis = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label12.Location = new System.Drawing.Point(4, 184);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(269, 22);
            this.label12.TabIndex = 3;
            this.label12.Text = "контроль исправности";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnEEPROM
            // 
            this.btnEEPROM.Enabled = false;
            this.btnEEPROM.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnEEPROM.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnEEPROM.Location = new System.Drawing.Point(176, 3);
            this.btnEEPROM.Margin = new System.Windows.Forms.Padding(10, 3, 10, 3);
            this.btnEEPROM.Name = "btnEEPROM";
            this.btnEEPROM.Size = new System.Drawing.Size(94, 32);
            this.btnEEPROM.TabIndex = 10;
            this.btnEEPROM.Text = "EEPROM";
            this.btnEEPROM.UseVisualStyleBackColor = true;
            this.btnEEPROM.Click += new System.EventHandler(this.BtnEepromClick);
            // 
            // label13
            // 
            this.label13.AutoEllipsis = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label13.Location = new System.Drawing.Point(4, 206);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(269, 22);
            this.label13.TabIndex = 3;
            this.label13.Text = "Минимальный ток (мкА):";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label14
            // 
            this.label14.AutoEllipsis = true;
            this.label14.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label14.Location = new System.Drawing.Point(4, 233);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(269, 22);
            this.label14.TabIndex = 3;
            this.label14.Text = "Максимальный ток (мкА):";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbHR2C
            // 
            this.lbHR2C.AutoEllipsis = true;
            this.lbHR2C.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbHR2C.Location = new System.Drawing.Point(281, 0);
            this.lbHR2C.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbHR2C.Name = "lbHR2C";
            this.lbHR2C.Size = new System.Drawing.Size(126, 22);
            this.lbHR2C.TabIndex = 3;
            this.lbHR2C.Text = "------";
            this.lbHR2C.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbHR25
            // 
            this.lbHR25.AutoEllipsis = true;
            this.lbHR25.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbHR25.Location = new System.Drawing.Point(281, 27);
            this.lbHR25.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbHR25.Name = "lbHR25";
            this.lbHR25.Size = new System.Drawing.Size(126, 22);
            this.lbHR25.TabIndex = 3;
            this.lbHR25.Text = "------";
            this.lbHR25.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbHR2D
            // 
            this.lbHR2D.AutoEllipsis = true;
            this.lbHR2D.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbHR2D.Location = new System.Drawing.Point(281, 49);
            this.lbHR2D.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbHR2D.Name = "lbHR2D";
            this.lbHR2D.Size = new System.Drawing.Size(126, 22);
            this.lbHR2D.TabIndex = 3;
            this.lbHR2D.Text = "------";
            this.lbHR2D.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnSave
            // 
            this.btnSave.Enabled = false;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSave.Location = new System.Drawing.Point(290, 3);
            this.btnSave.Margin = new System.Windows.Forms.Padding(10, 3, 10, 3);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(135, 32);
            this.btnSave.TabIndex = 11;
            this.btnSave.Text = "Установить";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.BtnSaveClick);
            // 
            // lbHR2E
            // 
            this.lbHR2E.AutoEllipsis = true;
            this.lbHR2E.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbHR2E.Location = new System.Drawing.Point(281, 76);
            this.lbHR2E.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbHR2E.Name = "lbHR2E";
            this.lbHR2E.Size = new System.Drawing.Size(126, 22);
            this.lbHR2E.TabIndex = 3;
            this.lbHR2E.Text = "------";
            this.lbHR2E.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnRestore
            // 
            this.btnRestore.Enabled = false;
            this.btnRestore.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnRestore.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnRestore.Location = new System.Drawing.Point(10, 3);
            this.btnRestore.Margin = new System.Windows.Forms.Padding(10, 3, 10, 3);
            this.btnRestore.Name = "btnRestore";
            this.btnRestore.Size = new System.Drawing.Size(146, 32);
            this.btnRestore.TabIndex = 9;
            this.btnRestore.Text = "Восстановить";
            this.btnRestore.UseVisualStyleBackColor = true;
            this.btnRestore.Click += new System.EventHandler(this.BtnRestoreClick);
            // 
            // lbHR2F
            // 
            this.lbHR2F.AutoEllipsis = true;
            this.lbHR2F.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbHR2F.Location = new System.Drawing.Point(281, 103);
            this.lbHR2F.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbHR2F.Name = "lbHR2F";
            this.lbHR2F.Size = new System.Drawing.Size(126, 22);
            this.lbHR2F.TabIndex = 3;
            this.lbHR2F.Text = "------";
            this.lbHR2F.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label6, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.label7, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.label8, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.label9, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.label12, 0, 7);
            this.tableLayoutPanel1.Controls.Add(this.label13, 0, 8);
            this.tableLayoutPanel1.Controls.Add(this.label14, 0, 9);
            this.tableLayoutPanel1.Controls.Add(this.lbHR2C, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.lbHR25, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.lbHR2D, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.lbHR2E, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.lbHR2F, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.lbHR14_8, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.lbHR14_9, 1, 6);
            this.tableLayoutPanel1.Controls.Add(this.lbHR21, 1, 8);
            this.tableLayoutPanel1.Controls.Add(this.lbHR20, 1, 9);
            this.tableLayoutPanel1.Controls.Add(this.edHR2C, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.edHR2D, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.edHR2E, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.edHR2F, 2, 4);
            this.tableLayoutPanel1.Controls.Add(this.edHR21, 2, 8);
            this.tableLayoutPanel1.Controls.Add(this.edHR20, 2, 9);
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel1, 0, 11);
            this.tableLayoutPanel1.Controls.Add(this.cbHR14_8, 2, 5);
            this.tableLayoutPanel1.Controls.Add(this.cbHR14_9, 2, 6);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(4, 36);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 12;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 6F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 22F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(596, 308);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // lbHR14_8
            // 
            this.lbHR14_8.AutoEllipsis = true;
            this.lbHR14_8.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbHR14_8.Location = new System.Drawing.Point(281, 130);
            this.lbHR14_8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbHR14_8.Name = "lbHR14_8";
            this.lbHR14_8.Size = new System.Drawing.Size(126, 22);
            this.lbHR14_8.TabIndex = 3;
            this.lbHR14_8.Text = "------";
            this.lbHR14_8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbHR14_9
            // 
            this.lbHR14_9.AutoEllipsis = true;
            this.lbHR14_9.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbHR14_9.Location = new System.Drawing.Point(281, 157);
            this.lbHR14_9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbHR14_9.Name = "lbHR14_9";
            this.lbHR14_9.Size = new System.Drawing.Size(126, 22);
            this.lbHR14_9.TabIndex = 3;
            this.lbHR14_9.Text = "------";
            this.lbHR14_9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbHR21
            // 
            this.lbHR21.AutoEllipsis = true;
            this.lbHR21.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbHR21.Location = new System.Drawing.Point(281, 206);
            this.lbHR21.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbHR21.Name = "lbHR21";
            this.lbHR21.Size = new System.Drawing.Size(126, 22);
            this.lbHR21.TabIndex = 3;
            this.lbHR21.Text = "------";
            this.lbHR21.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbHR20
            // 
            this.lbHR20.AutoEllipsis = true;
            this.lbHR20.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbHR20.Location = new System.Drawing.Point(281, 233);
            this.lbHR20.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbHR20.Name = "lbHR20";
            this.lbHR20.Size = new System.Drawing.Size(126, 22);
            this.lbHR20.TabIndex = 3;
            this.lbHR20.Text = "------";
            this.lbHR20.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // edHR2C
            // 
            this.edHR2C.Location = new System.Drawing.Point(411, 1);
            this.edHR2C.Margin = new System.Windows.Forms.Padding(0, 1, 0, 0);
            this.edHR2C.Name = "edHR2C";
            this.edHR2C.Size = new System.Drawing.Size(132, 26);
            this.edHR2C.TabIndex = 1;
            this.edHR2C.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // edHR2D
            // 
            this.edHR2D.Location = new System.Drawing.Point(411, 50);
            this.edHR2D.Margin = new System.Windows.Forms.Padding(0, 1, 0, 0);
            this.edHR2D.Name = "edHR2D";
            this.edHR2D.Size = new System.Drawing.Size(132, 26);
            this.edHR2D.TabIndex = 2;
            this.edHR2D.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // edHR2E
            // 
            this.edHR2E.Location = new System.Drawing.Point(411, 77);
            this.edHR2E.Margin = new System.Windows.Forms.Padding(0, 1, 0, 0);
            this.edHR2E.Name = "edHR2E";
            this.edHR2E.Size = new System.Drawing.Size(132, 26);
            this.edHR2E.TabIndex = 3;
            this.edHR2E.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // edHR2F
            // 
            this.edHR2F.Location = new System.Drawing.Point(411, 104);
            this.edHR2F.Margin = new System.Windows.Forms.Padding(0, 1, 0, 0);
            this.edHR2F.Name = "edHR2F";
            this.edHR2F.Size = new System.Drawing.Size(132, 26);
            this.edHR2F.TabIndex = 4;
            this.edHR2F.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // edHR21
            // 
            this.edHR21.Location = new System.Drawing.Point(411, 207);
            this.edHR21.Margin = new System.Windows.Forms.Padding(0, 1, 0, 0);
            this.edHR21.Name = "edHR21";
            this.edHR21.Size = new System.Drawing.Size(132, 26);
            this.edHR21.TabIndex = 7;
            this.edHR21.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // edHR20
            // 
            this.edHR20.Location = new System.Drawing.Point(411, 234);
            this.edHR20.Margin = new System.Windows.Forms.Padding(0, 1, 0, 0);
            this.edHR20.Name = "edHR20";
            this.edHR20.Size = new System.Drawing.Size(132, 26);
            this.edHR20.TabIndex = 8;
            this.edHR20.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.flowLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.flowLayoutPanel1, 3);
            this.flowLayoutPanel1.Controls.Add(this.btnRestore);
            this.flowLayoutPanel1.Controls.Add(this.btnEEPROM);
            this.flowLayoutPanel1.Controls.Add(this.btnSave);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(80, 269);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(435, 38);
            this.flowLayoutPanel1.TabIndex = 9;
            // 
            // cbHR14_8
            // 
            this.cbHR14_8.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbHR14_8.FormattingEnabled = true;
            this.cbHR14_8.Items.AddRange(new object[] {
            "Отключена",
            "Включена"});
            this.cbHR14_8.Location = new System.Drawing.Point(411, 131);
            this.cbHR14_8.Margin = new System.Windows.Forms.Padding(0, 1, 0, 0);
            this.cbHR14_8.Name = "cbHR14_8";
            this.cbHR14_8.Size = new System.Drawing.Size(132, 26);
            this.cbHR14_8.TabIndex = 5;
            // 
            // cbHR14_9
            // 
            this.cbHR14_9.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbHR14_9.FormattingEnabled = true;
            this.cbHR14_9.Items.AddRange(new object[] {
            "Отключена",
            "Включена"});
            this.cbHR14_9.Location = new System.Drawing.Point(411, 158);
            this.cbHR14_9.Margin = new System.Windows.Forms.Padding(0, 1, 0, 0);
            this.cbHR14_9.Name = "cbHR14_9";
            this.cbHR14_9.Size = new System.Drawing.Size(132, 26);
            this.cbHR14_9.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(514, 7);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 19);
            this.label2.TabIndex = 7;
            this.label2.Text = "W";
            // 
            // btnCopy
            // 
            this.btnCopy.Enabled = false;
            this.btnCopy.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnCopy.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnCopy.Location = new System.Drawing.Point(368, 3);
            this.btnCopy.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnCopy.Name = "btnCopy";
            this.btnCopy.Size = new System.Drawing.Size(139, 26);
            this.btnCopy.TabIndex = 1;
            this.btnCopy.Text = "копировать>>>";
            this.btnCopy.UseVisualStyleBackColor = true;
            this.btnCopy.Click += new System.EventHandler(this.BtnCopyClick);
            // 
            // btnCopyFromStorage
            // 
            this.btnCopyFromStorage.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnCopyFromStorage.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnCopyFromStorage.Location = new System.Drawing.Point(111, 3);
            this.btnCopyFromStorage.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnCopyFromStorage.Name = "btnCopyFromStorage";
            this.btnCopyFromStorage.Size = new System.Drawing.Size(221, 26);
            this.btnCopyFromStorage.TabIndex = 0;
            this.btnCopyFromStorage.TabStop = false;
            this.btnCopyFromStorage.Text = "копировать из архива>>>";
            this.btnCopyFromStorage.UseVisualStyleBackColor = true;
            this.btnCopyFromStorage.Visible = false;
            this.btnCopyFromStorage.Click += new System.EventHandler(this.BtnCopyFromStorageClick);
            // 
            // RiserTuningAlarmLevelControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnCopyFromStorage);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnCopy);
            this.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "RiserTuningAlarmLevelControl";
            this.Size = new System.Drawing.Size(551, 348);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

		}
        private System.Windows.Forms.Button btnCopyFromStorage;
		private System.Windows.Forms.Button btnCopy;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
		private System.Windows.Forms.ComboBox cbHR14_9;
		private System.Windows.Forms.TextBox edHR20;
		private System.Windows.Forms.TextBox edHR21;
		private System.Windows.Forms.ComboBox cbHR14_8;
		private System.Windows.Forms.TextBox edHR2F;
		private System.Windows.Forms.TextBox edHR2E;
		private System.Windows.Forms.TextBox edHR2D;
		private System.Windows.Forms.TextBox edHR2C;
		private System.Windows.Forms.Label lbHR20;
		private System.Windows.Forms.Label lbHR21;
		private System.Windows.Forms.Label lbHR14_9;
		private System.Windows.Forms.Label lbHR14_8;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		private System.Windows.Forms.Label lbHR2F;
		private System.Windows.Forms.Button btnRestore;
		private System.Windows.Forms.Label lbHR2E;
		private System.Windows.Forms.Button btnSave;
		private System.Windows.Forms.Label lbHR2D;
        private System.Windows.Forms.Label lbHR25;
		private System.Windows.Forms.Label lbHR2C;
		private System.Windows.Forms.Label label14;
		private System.Windows.Forms.Label label13;
		private System.Windows.Forms.Button btnEEPROM;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
	}
}
