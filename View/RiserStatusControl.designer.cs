﻿namespace TuningKOZ
{
    partial class RiserStatusControl
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
            this.components = new System.ComponentModel.Container();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.flowLayoutPanel4 = new System.Windows.Forms.FlowLayoutPanel();
            this.commandOpenBigValve = new TuningKOZ.UcRiserOneState();
            this.commandOpenSmallValve = new TuningKOZ.UcRiserOneState();
            this.flowLayoutPanel5 = new System.Windows.Forms.FlowLayoutPanel();
            this.commandGreenLampOn = new TuningKOZ.UcRiserOneState();
            this.commandBlueLampOn = new TuningKOZ.UcRiserOneState();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.lbAnalogLevel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.lbAutomatState = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.lbStopCount = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.flowLayoutPanel6 = new System.Windows.Forms.FlowLayoutPanel();
            this.stopKind0 = new TuningKOZ.UcRiserOneState();
            this.stopKind1 = new TuningKOZ.UcRiserOneState();
            this.stopKind2 = new TuningKOZ.UcRiserOneState();
            this.stopKind3 = new TuningKOZ.UcRiserOneState();
            this.stopKind4 = new TuningKOZ.UcRiserOneState();
            this.stopKind5 = new TuningKOZ.UcRiserOneState();
            this.stopKind6 = new TuningKOZ.UcRiserOneState();
            this.stopKind7 = new TuningKOZ.UcRiserOneState();
            this.stopKind8 = new TuningKOZ.UcRiserOneState();
            this.stopKind9 = new TuningKOZ.UcRiserOneState();
            this.stopKind10 = new TuningKOZ.UcRiserOneState();
            this.stopKind11 = new TuningKOZ.UcRiserOneState();
            this.stopKind12 = new TuningKOZ.UcRiserOneState();
            this.stopKind13 = new TuningKOZ.UcRiserOneState();
            this.stopKind14 = new TuningKOZ.UcRiserOneState();
            this.stopKind15 = new TuningKOZ.UcRiserOneState();
            this.label1 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.stateLevelError = new TuningKOZ.UcRiserOneState();
            this.stateGroundError = new TuningKOZ.UcRiserOneState();
            this.stateBigValveError = new TuningKOZ.UcRiserOneState();
            this.stateReadyError = new TuningKOZ.UcRiserOneState();
            this.stateStopButton = new TuningKOZ.UcRiserOneState();
            this.stateAnalogLevelMin = new TuningKOZ.UcRiserOneState();
            this.stateAnalogLevelMax = new TuningKOZ.UcRiserOneState();
            this.stateAlarmLevelMin = new TuningKOZ.UcRiserOneState();
            this.stateAlarmLevelMax = new TuningKOZ.UcRiserOneState();
            this.stateAlarmLevel = new TuningKOZ.UcRiserOneState();
            this.stateHandButton = new TuningKOZ.UcRiserOneState();
            this.stateCheckLevel = new TuningKOZ.UcRiserOneState();
            this.stateCheckGround = new TuningKOZ.UcRiserOneState();
            this.stateWorkPosition = new TuningKOZ.UcRiserOneState();
            this.stateReady = new TuningKOZ.UcRiserOneState();
            this.stateStartButton = new TuningKOZ.UcRiserOneState();
            this.stateBigValve = new TuningKOZ.UcRiserOneState();
            this.stateSmallValve = new TuningKOZ.UcRiserOneState();
            this.stateSmallValveError = new TuningKOZ.UcRiserOneState();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.flowLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.flowLayoutPanel4.SuspendLayout();
            this.flowLayoutPanel5.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.flowLayoutPanel6.SuspendLayout();
            this.tableLayoutPanel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.label2);
            this.flowLayoutPanel1.Controls.Add(this.tableLayoutPanel2);
            this.flowLayoutPanel1.Controls.Add(this.tableLayoutPanel3);
            this.flowLayoutPanel1.Controls.Add(this.tableLayoutPanel4);
            this.flowLayoutPanel1.Controls.Add(this.tableLayoutPanel5);
            this.flowLayoutPanel1.Controls.Add(this.label7);
            this.flowLayoutPanel1.Controls.Add(this.flowLayoutPanel6);
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.flowLayoutPanel1.Location = new System.Drawing.Point(2, 260);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(482, 527);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(474, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "Сигналы PLC  выходные";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.flowLayoutPanel4, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.flowLayoutPanel5, 1, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 27);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(472, 58);
            this.tableLayoutPanel2.TabIndex = 3;
            // 
            // flowLayoutPanel4
            // 
            this.flowLayoutPanel4.Controls.Add(this.commandOpenBigValve);
            this.flowLayoutPanel4.Controls.Add(this.commandOpenSmallValve);
            this.flowLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel4.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel4.Location = new System.Drawing.Point(3, 3);
            this.flowLayoutPanel4.Name = "flowLayoutPanel4";
            this.flowLayoutPanel4.Size = new System.Drawing.Size(230, 52);
            this.flowLayoutPanel4.TabIndex = 0;
            // 
            // commandOpenBigValve
            // 
            this.commandOpenBigValve.Caption = "большой клапан";
            this.commandOpenBigValve.CaptionAtRight = false;
            this.commandOpenBigValve.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.commandOpenBigValve.LampColorNone = System.Drawing.Color.Gray;
            this.commandOpenBigValve.LampColorOff = System.Drawing.SystemColors.Control;
            this.commandOpenBigValve.LampColorOn = System.Drawing.Color.Lime;
            this.commandOpenBigValve.Location = new System.Drawing.Point(7, 0);
            this.commandOpenBigValve.Margin = new System.Windows.Forms.Padding(7, 0, 0, 0);
            this.commandOpenBigValve.Name = "commandOpenBigValve";
            this.commandOpenBigValve.Size = new System.Drawing.Size(223, 23);
            this.commandOpenBigValve.State = null;
            this.commandOpenBigValve.TabIndex = 0;
            // 
            // commandOpenSmallValve
            // 
            this.commandOpenSmallValve.Caption = "малый клапан";
            this.commandOpenSmallValve.CaptionAtRight = false;
            this.commandOpenSmallValve.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.commandOpenSmallValve.LampColorNone = System.Drawing.Color.Gray;
            this.commandOpenSmallValve.LampColorOff = System.Drawing.SystemColors.Control;
            this.commandOpenSmallValve.LampColorOn = System.Drawing.Color.Lime;
            this.commandOpenSmallValve.Location = new System.Drawing.Point(7, 23);
            this.commandOpenSmallValve.Margin = new System.Windows.Forms.Padding(7, 0, 0, 0);
            this.commandOpenSmallValve.Name = "commandOpenSmallValve";
            this.commandOpenSmallValve.Size = new System.Drawing.Size(223, 23);
            this.commandOpenSmallValve.State = null;
            this.commandOpenSmallValve.TabIndex = 0;
            // 
            // flowLayoutPanel5
            // 
            this.flowLayoutPanel5.Controls.Add(this.commandGreenLampOn);
            this.flowLayoutPanel5.Controls.Add(this.commandBlueLampOn);
            this.flowLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel5.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel5.Location = new System.Drawing.Point(239, 3);
            this.flowLayoutPanel5.Name = "flowLayoutPanel5";
            this.flowLayoutPanel5.Size = new System.Drawing.Size(230, 52);
            this.flowLayoutPanel5.TabIndex = 0;
            // 
            // commandGreenLampOn
            // 
            this.commandGreenLampOn.Caption = "зеленая лампа";
            this.commandGreenLampOn.CaptionAtRight = false;
            this.commandGreenLampOn.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.commandGreenLampOn.LampColorNone = System.Drawing.Color.Gray;
            this.commandGreenLampOn.LampColorOff = System.Drawing.SystemColors.Control;
            this.commandGreenLampOn.LampColorOn = System.Drawing.Color.Lime;
            this.commandGreenLampOn.Location = new System.Drawing.Point(0, 0);
            this.commandGreenLampOn.Margin = new System.Windows.Forms.Padding(0);
            this.commandGreenLampOn.Name = "commandGreenLampOn";
            this.commandGreenLampOn.Size = new System.Drawing.Size(227, 23);
            this.commandGreenLampOn.State = null;
            this.commandGreenLampOn.TabIndex = 0;
            // 
            // commandBlueLampOn
            // 
            this.commandBlueLampOn.Caption = "синяя лампа";
            this.commandBlueLampOn.CaptionAtRight = false;
            this.commandBlueLampOn.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.commandBlueLampOn.LampColorNone = System.Drawing.Color.Gray;
            this.commandBlueLampOn.LampColorOff = System.Drawing.SystemColors.Control;
            this.commandBlueLampOn.LampColorOn = System.Drawing.Color.Blue;
            this.commandBlueLampOn.Location = new System.Drawing.Point(0, 23);
            this.commandBlueLampOn.Margin = new System.Windows.Forms.Padding(0);
            this.commandBlueLampOn.Name = "commandBlueLampOn";
            this.commandBlueLampOn.Size = new System.Drawing.Size(227, 23);
            this.commandBlueLampOn.State = null;
            this.commandBlueLampOn.TabIndex = 0;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.lbAnalogLevel, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.label3, 0, 0);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 91);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(474, 24);
            this.tableLayoutPanel3.TabIndex = 4;
            // 
            // lbAnalogLevel
            // 
            this.lbAnalogLevel.AutoSize = true;
            this.lbAnalogLevel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbAnalogLevel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbAnalogLevel.ForeColor = System.Drawing.Color.Red;
            this.lbAnalogLevel.Location = new System.Drawing.Point(240, 0);
            this.lbAnalogLevel.Name = "lbAnalogLevel";
            this.lbAnalogLevel.Size = new System.Drawing.Size(231, 24);
            this.lbAnalogLevel.TabIndex = 1;
            this.lbAnalogLevel.Text = "------";
            this.lbAnalogLevel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(3, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(231, 24);
            this.label3.TabIndex = 0;
            this.label3.Text = "Уровень (мм)";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 2;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Controls.Add(this.lbAutomatState, 1, 0);
            this.tableLayoutPanel4.Controls.Add(this.label5, 0, 0);
            this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 121);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(474, 24);
            this.tableLayoutPanel4.TabIndex = 5;
            // 
            // lbAutomatState
            // 
            this.lbAutomatState.AutoSize = true;
            this.lbAutomatState.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbAutomatState.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbAutomatState.ForeColor = System.Drawing.Color.Red;
            this.lbAutomatState.Location = new System.Drawing.Point(240, 0);
            this.lbAutomatState.Name = "lbAutomatState";
            this.lbAutomatState.Size = new System.Drawing.Size(231, 24);
            this.lbAutomatState.TabIndex = 1;
            this.lbAutomatState.Text = "------";
            this.lbAutomatState.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(3, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(231, 24);
            this.label5.TabIndex = 0;
            this.label5.Text = "Состояние PLC";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 2;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.Controls.Add(this.lbStopCount, 1, 0);
            this.tableLayoutPanel5.Controls.Add(this.label6, 0, 0);
            this.tableLayoutPanel5.Location = new System.Drawing.Point(3, 151);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 1;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(474, 24);
            this.tableLayoutPanel5.TabIndex = 6;
            // 
            // lbStopCount
            // 
            this.lbStopCount.AutoSize = true;
            this.lbStopCount.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbStopCount.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbStopCount.ForeColor = System.Drawing.Color.Red;
            this.lbStopCount.Location = new System.Drawing.Point(240, 0);
            this.lbStopCount.Name = "lbStopCount";
            this.lbStopCount.Size = new System.Drawing.Size(231, 24);
            this.lbStopCount.TabIndex = 1;
            this.lbStopCount.Text = "------";
            this.lbStopCount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(3, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(231, 24);
            this.label6.TabIndex = 0;
            this.label6.Text = "Счетчик остановов";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(3, 178);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(474, 24);
            this.label7.TabIndex = 7;
            this.label7.Text = "Причины последнего останова";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // flowLayoutPanel6
            // 
            this.flowLayoutPanel6.AutoScroll = true;
            this.flowLayoutPanel6.Controls.Add(this.stopKind0);
            this.flowLayoutPanel6.Controls.Add(this.stopKind1);
            this.flowLayoutPanel6.Controls.Add(this.stopKind2);
            this.flowLayoutPanel6.Controls.Add(this.stopKind3);
            this.flowLayoutPanel6.Controls.Add(this.stopKind4);
            this.flowLayoutPanel6.Controls.Add(this.stopKind5);
            this.flowLayoutPanel6.Controls.Add(this.stopKind6);
            this.flowLayoutPanel6.Controls.Add(this.stopKind7);
            this.flowLayoutPanel6.Controls.Add(this.stopKind8);
            this.flowLayoutPanel6.Controls.Add(this.stopKind9);
            this.flowLayoutPanel6.Controls.Add(this.stopKind10);
            this.flowLayoutPanel6.Controls.Add(this.stopKind11);
            this.flowLayoutPanel6.Controls.Add(this.stopKind12);
            this.flowLayoutPanel6.Controls.Add(this.stopKind13);
            this.flowLayoutPanel6.Controls.Add(this.stopKind14);
            this.flowLayoutPanel6.Controls.Add(this.stopKind15);
            this.flowLayoutPanel6.Location = new System.Drawing.Point(3, 205);
            this.flowLayoutPanel6.Name = "flowLayoutPanel6";
            this.flowLayoutPanel6.Size = new System.Drawing.Size(474, 68);
            this.flowLayoutPanel6.TabIndex = 8;
            // 
            // stopKind0
            // 
            this.stopKind0.Caption = "сигнализатор аварийный";
            this.stopKind0.CaptionAtRight = false;
            this.flowLayoutPanel6.SetFlowBreak(this.stopKind0, true);
            this.stopKind0.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Bold);
            this.stopKind0.LampColorNone = System.Drawing.Color.Gray;
            this.stopKind0.LampColorOff = System.Drawing.SystemColors.Control;
            this.stopKind0.LampColorOn = System.Drawing.Color.Red;
            this.stopKind0.Location = new System.Drawing.Point(7, 0);
            this.stopKind0.Margin = new System.Windows.Forms.Padding(7, 0, 0, 0);
            this.stopKind0.Name = "stopKind0";
            this.stopKind0.Size = new System.Drawing.Size(446, 23);
            this.stopKind0.State = null;
            this.stopKind0.TabIndex = 0;
            // 
            // stopKind1
            // 
            this.stopKind1.Caption = "кнопка Стоп";
            this.stopKind1.CaptionAtRight = false;
            this.flowLayoutPanel6.SetFlowBreak(this.stopKind1, true);
            this.stopKind1.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Bold);
            this.stopKind1.LampColorNone = System.Drawing.Color.Gray;
            this.stopKind1.LampColorOff = System.Drawing.SystemColors.Control;
            this.stopKind1.LampColorOn = System.Drawing.Color.Red;
            this.stopKind1.Location = new System.Drawing.Point(7, 23);
            this.stopKind1.Margin = new System.Windows.Forms.Padding(7, 0, 0, 0);
            this.stopKind1.Name = "stopKind1";
            this.stopKind1.Size = new System.Drawing.Size(446, 23);
            this.stopKind1.State = null;
            this.stopKind1.TabIndex = 0;
            // 
            // stopKind2
            // 
            this.stopKind2.AutoSize = true;
            this.stopKind2.Caption = "неисправность цепи готовности";
            this.stopKind2.CaptionAtRight = false;
            this.flowLayoutPanel6.SetFlowBreak(this.stopKind2, true);
            this.stopKind2.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Bold);
            this.stopKind2.LampColorNone = System.Drawing.Color.Gray;
            this.stopKind2.LampColorOff = System.Drawing.SystemColors.Control;
            this.stopKind2.LampColorOn = System.Drawing.Color.Red;
            this.stopKind2.Location = new System.Drawing.Point(7, 46);
            this.stopKind2.Margin = new System.Windows.Forms.Padding(7, 0, 0, 0);
            this.stopKind2.Name = "stopKind2";
            this.stopKind2.Size = new System.Drawing.Size(0, 23);
            this.stopKind2.State = null;
            this.stopKind2.TabIndex = 0;
            // 
            // stopKind3
            // 
            this.stopKind3.AutoSize = true;
            this.stopKind3.Caption = "неисправность сигнализатора уровня";
            this.stopKind3.CaptionAtRight = false;
            this.flowLayoutPanel6.SetFlowBreak(this.stopKind3, true);
            this.stopKind3.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Bold);
            this.stopKind3.LampColorNone = System.Drawing.Color.Gray;
            this.stopKind3.LampColorOff = System.Drawing.SystemColors.Control;
            this.stopKind3.LampColorOn = System.Drawing.Color.Red;
            this.stopKind3.Location = new System.Drawing.Point(7, 69);
            this.stopKind3.Margin = new System.Windows.Forms.Padding(7, 0, 0, 0);
            this.stopKind3.Name = "stopKind3";
            this.stopKind3.Size = new System.Drawing.Size(0, 23);
            this.stopKind3.State = null;
            this.stopKind3.TabIndex = 0;
            // 
            // stopKind4
            // 
            this.stopKind4.AutoSize = true;
            this.stopKind4.Caption = "истекло время работы без связи";
            this.stopKind4.CaptionAtRight = false;
            this.flowLayoutPanel6.SetFlowBreak(this.stopKind4, true);
            this.stopKind4.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Bold);
            this.stopKind4.LampColorNone = System.Drawing.Color.Gray;
            this.stopKind4.LampColorOff = System.Drawing.SystemColors.Control;
            this.stopKind4.LampColorOn = System.Drawing.Color.Red;
            this.stopKind4.Location = new System.Drawing.Point(7, 92);
            this.stopKind4.Margin = new System.Windows.Forms.Padding(7, 0, 0, 0);
            this.stopKind4.Name = "stopKind4";
            this.stopKind4.Size = new System.Drawing.Size(0, 23);
            this.stopKind4.State = null;
            this.stopKind4.TabIndex = 0;
            // 
            // stopKind5
            // 
            this.stopKind5.AutoSize = true;
            this.stopKind5.Caption = "заземление отсутствует";
            this.stopKind5.CaptionAtRight = false;
            this.flowLayoutPanel6.SetFlowBreak(this.stopKind5, true);
            this.stopKind5.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Bold);
            this.stopKind5.LampColorNone = System.Drawing.Color.Gray;
            this.stopKind5.LampColorOff = System.Drawing.SystemColors.Control;
            this.stopKind5.LampColorOn = System.Drawing.Color.Red;
            this.stopKind5.Location = new System.Drawing.Point(7, 115);
            this.stopKind5.Margin = new System.Windows.Forms.Padding(7, 0, 0, 0);
            this.stopKind5.Name = "stopKind5";
            this.stopKind5.Size = new System.Drawing.Size(0, 23);
            this.stopKind5.State = null;
            this.stopKind5.TabIndex = 0;
            // 
            // stopKind6
            // 
            this.stopKind6.AutoSize = true;
            this.stopKind6.Caption = "ошибка клапана большого прохода";
            this.stopKind6.CaptionAtRight = false;
            this.flowLayoutPanel6.SetFlowBreak(this.stopKind6, true);
            this.stopKind6.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Bold);
            this.stopKind6.LampColorNone = System.Drawing.Color.Gray;
            this.stopKind6.LampColorOff = System.Drawing.SystemColors.Control;
            this.stopKind6.LampColorOn = System.Drawing.Color.Red;
            this.stopKind6.Location = new System.Drawing.Point(7, 138);
            this.stopKind6.Margin = new System.Windows.Forms.Padding(7, 0, 0, 0);
            this.stopKind6.Name = "stopKind6";
            this.stopKind6.Size = new System.Drawing.Size(0, 23);
            this.stopKind6.State = null;
            this.stopKind6.TabIndex = 0;
            // 
            // stopKind7
            // 
            this.stopKind7.AutoSize = true;
            this.stopKind7.Caption = "ошибка клапана малого прохода";
            this.stopKind7.CaptionAtRight = false;
            this.flowLayoutPanel6.SetFlowBreak(this.stopKind7, true);
            this.stopKind7.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Bold);
            this.stopKind7.LampColorNone = System.Drawing.Color.Gray;
            this.stopKind7.LampColorOff = System.Drawing.SystemColors.Control;
            this.stopKind7.LampColorOn = System.Drawing.Color.Red;
            this.stopKind7.Location = new System.Drawing.Point(7, 161);
            this.stopKind7.Margin = new System.Windows.Forms.Padding(7, 0, 0, 0);
            this.stopKind7.Name = "stopKind7";
            this.stopKind7.Size = new System.Drawing.Size(0, 23);
            this.stopKind7.State = null;
            this.stopKind7.TabIndex = 0;
            // 
            // stopKind8
            // 
            this.stopKind8.AutoSize = true;
            this.stopKind8.Caption = "ток сигнализатора уровня минимальный (обрыв)";
            this.stopKind8.CaptionAtRight = false;
            this.flowLayoutPanel6.SetFlowBreak(this.stopKind8, true);
            this.stopKind8.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Bold);
            this.stopKind8.LampColorNone = System.Drawing.Color.Gray;
            this.stopKind8.LampColorOff = System.Drawing.SystemColors.Control;
            this.stopKind8.LampColorOn = System.Drawing.Color.Red;
            this.stopKind8.Location = new System.Drawing.Point(7, 184);
            this.stopKind8.Margin = new System.Windows.Forms.Padding(7, 0, 0, 0);
            this.stopKind8.Name = "stopKind8";
            this.stopKind8.Size = new System.Drawing.Size(0, 23);
            this.stopKind8.State = null;
            this.stopKind8.TabIndex = 0;
            // 
            // stopKind9
            // 
            this.stopKind9.AutoSize = true;
            this.stopKind9.Caption = "ток сигнализатора уровня максимальный (к.з.)";
            this.stopKind9.CaptionAtRight = false;
            this.flowLayoutPanel6.SetFlowBreak(this.stopKind9, true);
            this.stopKind9.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Bold);
            this.stopKind9.LampColorNone = System.Drawing.Color.Gray;
            this.stopKind9.LampColorOff = System.Drawing.SystemColors.Control;
            this.stopKind9.LampColorOn = System.Drawing.Color.Red;
            this.stopKind9.Location = new System.Drawing.Point(7, 207);
            this.stopKind9.Margin = new System.Windows.Forms.Padding(7, 0, 0, 0);
            this.stopKind9.Name = "stopKind9";
            this.stopKind9.Size = new System.Drawing.Size(0, 23);
            this.stopKind9.State = null;
            this.stopKind9.TabIndex = 0;
            // 
            // stopKind10
            // 
            this.stopKind10.AutoSize = true;
            this.stopKind10.Caption = "ток аварийного сигнализатора уровня минимальный (обрыв)";
            this.stopKind10.CaptionAtRight = false;
            this.flowLayoutPanel6.SetFlowBreak(this.stopKind10, true);
            this.stopKind10.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Bold);
            this.stopKind10.LampColorNone = System.Drawing.Color.Gray;
            this.stopKind10.LampColorOff = System.Drawing.SystemColors.Control;
            this.stopKind10.LampColorOn = System.Drawing.Color.Red;
            this.stopKind10.Location = new System.Drawing.Point(7, 230);
            this.stopKind10.Margin = new System.Windows.Forms.Padding(7, 0, 0, 0);
            this.stopKind10.Name = "stopKind10";
            this.stopKind10.Size = new System.Drawing.Size(0, 23);
            this.stopKind10.State = null;
            this.stopKind10.TabIndex = 0;
            // 
            // stopKind11
            // 
            this.stopKind11.AutoSize = true;
            this.stopKind11.Caption = "ток аварийного сигнализатора уровня максимальный (к.з.)";
            this.stopKind11.CaptionAtRight = false;
            this.flowLayoutPanel6.SetFlowBreak(this.stopKind11, true);
            this.stopKind11.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Bold);
            this.stopKind11.LampColorNone = System.Drawing.Color.Gray;
            this.stopKind11.LampColorOff = System.Drawing.SystemColors.Control;
            this.stopKind11.LampColorOn = System.Drawing.Color.Red;
            this.stopKind11.Location = new System.Drawing.Point(7, 253);
            this.stopKind11.Margin = new System.Windows.Forms.Padding(7, 0, 0, 0);
            this.stopKind11.Name = "stopKind11";
            this.stopKind11.Size = new System.Drawing.Size(0, 23);
            this.stopKind11.State = null;
            this.stopKind11.TabIndex = 0;
            // 
            // stopKind12
            // 
            this.stopKind12.AutoSize = true;
            this.stopKind12.Caption = "сработал датчик рабочего положения";
            this.stopKind12.CaptionAtRight = false;
            this.flowLayoutPanel6.SetFlowBreak(this.stopKind12, true);
            this.stopKind12.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Bold);
            this.stopKind12.LampColorNone = System.Drawing.Color.Gray;
            this.stopKind12.LampColorOff = System.Drawing.SystemColors.Control;
            this.stopKind12.LampColorOn = System.Drawing.Color.Red;
            this.stopKind12.Location = new System.Drawing.Point(7, 276);
            this.stopKind12.Margin = new System.Windows.Forms.Padding(7, 0, 0, 0);
            this.stopKind12.Name = "stopKind12";
            this.stopKind12.Size = new System.Drawing.Size(0, 23);
            this.stopKind12.State = null;
            this.stopKind12.TabIndex = 0;
            // 
            // stopKind13
            // 
            this.stopKind13.AutoSize = true;
            this.stopKind13.Caption = "автоматическое завершение налива (по заданию)";
            this.stopKind13.CaptionAtRight = false;
            this.flowLayoutPanel6.SetFlowBreak(this.stopKind13, true);
            this.stopKind13.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Bold);
            this.stopKind13.LampColorNone = System.Drawing.Color.Gray;
            this.stopKind13.LampColorOff = System.Drawing.SystemColors.Control;
            this.stopKind13.LampColorOn = System.Drawing.Color.Lime;
            this.stopKind13.Location = new System.Drawing.Point(7, 299);
            this.stopKind13.Margin = new System.Windows.Forms.Padding(7, 0, 0, 0);
            this.stopKind13.Name = "stopKind13";
            this.stopKind13.Size = new System.Drawing.Size(0, 23);
            this.stopKind13.State = null;
            this.stopKind13.TabIndex = 0;
            // 
            // stopKind14
            // 
            this.stopKind14.AutoSize = true;
            this.stopKind14.Caption = "дистанционное завершение налива";
            this.stopKind14.CaptionAtRight = false;
            this.flowLayoutPanel6.SetFlowBreak(this.stopKind14, true);
            this.stopKind14.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Bold);
            this.stopKind14.LampColorNone = System.Drawing.Color.Gray;
            this.stopKind14.LampColorOff = System.Drawing.SystemColors.Control;
            this.stopKind14.LampColorOn = System.Drawing.Color.Red;
            this.stopKind14.Location = new System.Drawing.Point(7, 322);
            this.stopKind14.Margin = new System.Windows.Forms.Padding(7, 0, 0, 0);
            this.stopKind14.Name = "stopKind14";
            this.stopKind14.Size = new System.Drawing.Size(0, 23);
            this.stopKind14.State = null;
            this.stopKind14.TabIndex = 0;
            // 
            // stopKind15
            // 
            this.stopKind15.AutoSize = true;
            this.stopKind15.Caption = "неверное завершение налива";
            this.stopKind15.CaptionAtRight = false;
            this.flowLayoutPanel6.SetFlowBreak(this.stopKind15, true);
            this.stopKind15.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Bold);
            this.stopKind15.LampColorNone = System.Drawing.Color.Gray;
            this.stopKind15.LampColorOff = System.Drawing.SystemColors.Control;
            this.stopKind15.LampColorOn = System.Drawing.Color.Red;
            this.stopKind15.Location = new System.Drawing.Point(7, 345);
            this.stopKind15.Margin = new System.Windows.Forms.Padding(7, 0, 0, 0);
            this.stopKind15.Name = "stopKind15";
            this.stopKind15.Size = new System.Drawing.Size(0, 23);
            this.stopKind15.State = null;
            this.stopKind15.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel6.SetColumnSpan(this.label1, 2);
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(471, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Сигналы PLC  входные";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel6
            // 
            this.tableLayoutPanel6.ColumnCount = 2;
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel6.Controls.Add(this.stateLevelError, 1, 11);
            this.tableLayoutPanel6.Controls.Add(this.stateGroundError, 1, 10);
            this.tableLayoutPanel6.Controls.Add(this.stateBigValveError, 1, 8);
            this.tableLayoutPanel6.Controls.Add(this.stateReadyError, 1, 7);
            this.tableLayoutPanel6.Controls.Add(this.stateStopButton, 1, 6);
            this.tableLayoutPanel6.Controls.Add(this.stateAnalogLevelMin, 1, 5);
            this.tableLayoutPanel6.Controls.Add(this.stateAnalogLevelMax, 1, 4);
            this.tableLayoutPanel6.Controls.Add(this.stateAlarmLevelMin, 1, 3);
            this.tableLayoutPanel6.Controls.Add(this.stateAlarmLevelMax, 1, 2);
            this.tableLayoutPanel6.Controls.Add(this.stateAlarmLevel, 1, 1);
            this.tableLayoutPanel6.Controls.Add(this.stateHandButton, 0, 8);
            this.tableLayoutPanel6.Controls.Add(this.stateCheckLevel, 0, 7);
            this.tableLayoutPanel6.Controls.Add(this.stateCheckGround, 0, 6);
            this.tableLayoutPanel6.Controls.Add(this.stateWorkPosition, 0, 5);
            this.tableLayoutPanel6.Controls.Add(this.stateReady, 0, 4);
            this.tableLayoutPanel6.Controls.Add(this.stateStartButton, 0, 1);
            this.tableLayoutPanel6.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel6.Controls.Add(this.stateBigValve, 0, 2);
            this.tableLayoutPanel6.Controls.Add(this.stateSmallValve, 0, 3);
            this.tableLayoutPanel6.Controls.Add(this.stateSmallValveError, 1, 9);
            this.tableLayoutPanel6.Location = new System.Drawing.Point(5, 77);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            this.tableLayoutPanel6.RowCount = 12;
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.333333F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.333333F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.333333F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.333333F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.333333F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.333333F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.333333F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.333333F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.333333F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.333333F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.333333F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.333333F));
            this.tableLayoutPanel6.Size = new System.Drawing.Size(477, 250);
            this.tableLayoutPanel6.TabIndex = 1;
            // 
            // stateLevelError
            // 
            this.stateLevelError.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.stateLevelError.Caption = "сигнал. уровня не исправен";
            this.stateLevelError.CaptionAtRight = false;
            this.stateLevelError.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.stateLevelError.LampColorNone = System.Drawing.Color.Gray;
            this.stateLevelError.LampColorOff = System.Drawing.SystemColors.Control;
            this.stateLevelError.LampColorOn = System.Drawing.Color.Red;
            this.stateLevelError.Location = new System.Drawing.Point(238, 220);
            this.stateLevelError.Margin = new System.Windows.Forms.Padding(0);
            this.stateLevelError.Name = "stateLevelError";
            this.stateLevelError.Size = new System.Drawing.Size(229, 30);
            this.stateLevelError.State = null;
            this.stateLevelError.TabIndex = 0;
            // 
            // stateGroundError
            // 
            this.stateGroundError.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.stateGroundError.Caption = "заземление отсутствует";
            this.stateGroundError.CaptionAtRight = false;
            this.stateGroundError.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.stateGroundError.LampColorNone = System.Drawing.Color.Gray;
            this.stateGroundError.LampColorOff = System.Drawing.SystemColors.Control;
            this.stateGroundError.LampColorOn = System.Drawing.Color.Red;
            this.stateGroundError.Location = new System.Drawing.Point(238, 200);
            this.stateGroundError.Margin = new System.Windows.Forms.Padding(0);
            this.stateGroundError.Name = "stateGroundError";
            this.stateGroundError.Size = new System.Drawing.Size(226, 20);
            this.stateGroundError.State = null;
            this.stateGroundError.TabIndex = 0;
            // 
            // stateBigValveError
            // 
            this.stateBigValveError.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.stateBigValveError.Caption = "ошибка большого клапана";
            this.stateBigValveError.CaptionAtRight = false;
            this.stateBigValveError.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.stateBigValveError.LampColorNone = System.Drawing.Color.Gray;
            this.stateBigValveError.LampColorOff = System.Drawing.SystemColors.Control;
            this.stateBigValveError.LampColorOn = System.Drawing.Color.Red;
            this.stateBigValveError.Location = new System.Drawing.Point(238, 160);
            this.stateBigValveError.Margin = new System.Windows.Forms.Padding(0);
            this.stateBigValveError.Name = "stateBigValveError";
            this.stateBigValveError.Size = new System.Drawing.Size(226, 20);
            this.stateBigValveError.State = null;
            this.stateBigValveError.TabIndex = 0;
            // 
            // stateReadyError
            // 
            this.stateReadyError.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.stateReadyError.Caption = "цепь готовности неисправна";
            this.stateReadyError.CaptionAtRight = false;
            this.stateReadyError.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.stateReadyError.LampColorNone = System.Drawing.Color.Gray;
            this.stateReadyError.LampColorOff = System.Drawing.SystemColors.Control;
            this.stateReadyError.LampColorOn = System.Drawing.Color.Red;
            this.stateReadyError.Location = new System.Drawing.Point(238, 140);
            this.stateReadyError.Margin = new System.Windows.Forms.Padding(0);
            this.stateReadyError.Name = "stateReadyError";
            this.stateReadyError.Size = new System.Drawing.Size(226, 20);
            this.stateReadyError.State = null;
            this.stateReadyError.TabIndex = 0;
            // 
            // stateStopButton
            // 
            this.stateStopButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.stateStopButton.Caption = "кнопка Стоп";
            this.stateStopButton.CaptionAtRight = false;
            this.stateStopButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.stateStopButton.LampColorNone = System.Drawing.Color.Gray;
            this.stateStopButton.LampColorOff = System.Drawing.SystemColors.Control;
            this.stateStopButton.LampColorOn = System.Drawing.Color.Red;
            this.stateStopButton.Location = new System.Drawing.Point(238, 120);
            this.stateStopButton.Margin = new System.Windows.Forms.Padding(0);
            this.stateStopButton.Name = "stateStopButton";
            this.stateStopButton.Size = new System.Drawing.Size(226, 20);
            this.stateStopButton.State = null;
            this.stateStopButton.TabIndex = 0;
            // 
            // stateAnalogLevelMin
            // 
            this.stateAnalogLevelMin.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.stateAnalogLevelMin.Caption = "сигнализатор уровня min";
            this.stateAnalogLevelMin.CaptionAtRight = false;
            this.stateAnalogLevelMin.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.stateAnalogLevelMin.LampColorNone = System.Drawing.Color.Gray;
            this.stateAnalogLevelMin.LampColorOff = System.Drawing.SystemColors.Control;
            this.stateAnalogLevelMin.LampColorOn = System.Drawing.Color.Red;
            this.stateAnalogLevelMin.Location = new System.Drawing.Point(238, 100);
            this.stateAnalogLevelMin.Margin = new System.Windows.Forms.Padding(0);
            this.stateAnalogLevelMin.Name = "stateAnalogLevelMin";
            this.stateAnalogLevelMin.Size = new System.Drawing.Size(226, 20);
            this.stateAnalogLevelMin.State = null;
            this.stateAnalogLevelMin.TabIndex = 0;
            // 
            // stateAnalogLevelMax
            // 
            this.stateAnalogLevelMax.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.stateAnalogLevelMax.Caption = "сигнализатор уровня max";
            this.stateAnalogLevelMax.CaptionAtRight = false;
            this.stateAnalogLevelMax.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.stateAnalogLevelMax.LampColorNone = System.Drawing.Color.Gray;
            this.stateAnalogLevelMax.LampColorOff = System.Drawing.SystemColors.Control;
            this.stateAnalogLevelMax.LampColorOn = System.Drawing.Color.Red;
            this.stateAnalogLevelMax.Location = new System.Drawing.Point(238, 80);
            this.stateAnalogLevelMax.Margin = new System.Windows.Forms.Padding(0);
            this.stateAnalogLevelMax.Name = "stateAnalogLevelMax";
            this.stateAnalogLevelMax.Size = new System.Drawing.Size(198, 20);
            this.stateAnalogLevelMax.State = null;
            this.stateAnalogLevelMax.TabIndex = 0;
            // 
            // stateAlarmLevelMin
            // 
            this.stateAlarmLevelMin.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.stateAlarmLevelMin.Caption = "сигнализатор аварийный min";
            this.stateAlarmLevelMin.CaptionAtRight = false;
            this.stateAlarmLevelMin.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.stateAlarmLevelMin.LampColorNone = System.Drawing.Color.Gray;
            this.stateAlarmLevelMin.LampColorOff = System.Drawing.SystemColors.Control;
            this.stateAlarmLevelMin.LampColorOn = System.Drawing.Color.Red;
            this.stateAlarmLevelMin.Location = new System.Drawing.Point(238, 60);
            this.stateAlarmLevelMin.Margin = new System.Windows.Forms.Padding(0);
            this.stateAlarmLevelMin.Name = "stateAlarmLevelMin";
            this.stateAlarmLevelMin.Size = new System.Drawing.Size(226, 20);
            this.stateAlarmLevelMin.State = null;
            this.stateAlarmLevelMin.TabIndex = 0;
            // 
            // stateAlarmLevelMax
            // 
            this.stateAlarmLevelMax.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.stateAlarmLevelMax.Caption = "сигнализатор аварийный max";
            this.stateAlarmLevelMax.CaptionAtRight = false;
            this.stateAlarmLevelMax.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.stateAlarmLevelMax.LampColorNone = System.Drawing.Color.Gray;
            this.stateAlarmLevelMax.LampColorOff = System.Drawing.SystemColors.Control;
            this.stateAlarmLevelMax.LampColorOn = System.Drawing.Color.Red;
            this.stateAlarmLevelMax.Location = new System.Drawing.Point(238, 40);
            this.stateAlarmLevelMax.Margin = new System.Windows.Forms.Padding(0);
            this.stateAlarmLevelMax.Name = "stateAlarmLevelMax";
            this.stateAlarmLevelMax.Size = new System.Drawing.Size(229, 20);
            this.stateAlarmLevelMax.State = null;
            this.stateAlarmLevelMax.TabIndex = 0;
            // 
            // stateAlarmLevel
            // 
            this.stateAlarmLevel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.stateAlarmLevel.Caption = "сигнализатор аварийный";
            this.stateAlarmLevel.CaptionAtRight = false;
            this.stateAlarmLevel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.stateAlarmLevel.LampColorNone = System.Drawing.Color.Gray;
            this.stateAlarmLevel.LampColorOff = System.Drawing.SystemColors.Control;
            this.stateAlarmLevel.LampColorOn = System.Drawing.Color.Red;
            this.stateAlarmLevel.Location = new System.Drawing.Point(238, 20);
            this.stateAlarmLevel.Margin = new System.Windows.Forms.Padding(0);
            this.stateAlarmLevel.Name = "stateAlarmLevel";
            this.stateAlarmLevel.Size = new System.Drawing.Size(226, 20);
            this.stateAlarmLevel.State = null;
            this.stateAlarmLevel.TabIndex = 0;
            // 
            // stateHandButton
            // 
            this.stateHandButton.Caption = "кнопка Автономно";
            this.stateHandButton.CaptionAtRight = false;
            this.stateHandButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.stateHandButton.LampColorNone = System.Drawing.Color.Gray;
            this.stateHandButton.LampColorOff = System.Drawing.SystemColors.Control;
            this.stateHandButton.LampColorOn = System.Drawing.Color.Blue;
            this.stateHandButton.Location = new System.Drawing.Point(7, 160);
            this.stateHandButton.Margin = new System.Windows.Forms.Padding(7, 0, 0, 0);
            this.stateHandButton.Name = "stateHandButton";
            this.stateHandButton.Size = new System.Drawing.Size(223, 20);
            this.stateHandButton.State = null;
            this.stateHandButton.TabIndex = 0;
            // 
            // stateCheckLevel
            // 
            this.stateCheckLevel.Caption = "контроль уровнемера";
            this.stateCheckLevel.CaptionAtRight = false;
            this.stateCheckLevel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.stateCheckLevel.LampColorNone = System.Drawing.Color.Gray;
            this.stateCheckLevel.LampColorOff = System.Drawing.SystemColors.Control;
            this.stateCheckLevel.LampColorOn = System.Drawing.Color.Red;
            this.stateCheckLevel.Location = new System.Drawing.Point(7, 140);
            this.stateCheckLevel.Margin = new System.Windows.Forms.Padding(7, 0, 0, 0);
            this.stateCheckLevel.Name = "stateCheckLevel";
            this.stateCheckLevel.Size = new System.Drawing.Size(223, 20);
            this.stateCheckLevel.State = null;
            this.stateCheckLevel.TabIndex = 0;
            // 
            // stateCheckGround
            // 
            this.stateCheckGround.Caption = "контроль заземления";
            this.stateCheckGround.CaptionAtRight = false;
            this.stateCheckGround.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.stateCheckGround.LampColorNone = System.Drawing.Color.Gray;
            this.stateCheckGround.LampColorOff = System.Drawing.SystemColors.Control;
            this.stateCheckGround.LampColorOn = System.Drawing.Color.Red;
            this.stateCheckGround.Location = new System.Drawing.Point(7, 120);
            this.stateCheckGround.Margin = new System.Windows.Forms.Padding(7, 0, 0, 0);
            this.stateCheckGround.Name = "stateCheckGround";
            this.stateCheckGround.Size = new System.Drawing.Size(223, 20);
            this.stateCheckGround.State = null;
            this.stateCheckGround.TabIndex = 0;
            // 
            // stateWorkPosition
            // 
            this.stateWorkPosition.Caption = "конечник рабочего положения";
            this.stateWorkPosition.CaptionAtRight = false;
            this.stateWorkPosition.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.stateWorkPosition.LampColorNone = System.Drawing.Color.Gray;
            this.stateWorkPosition.LampColorOff = System.Drawing.SystemColors.Control;
            this.stateWorkPosition.LampColorOn = System.Drawing.Color.Lime;
            this.stateWorkPosition.Location = new System.Drawing.Point(7, 100);
            this.stateWorkPosition.Margin = new System.Windows.Forms.Padding(7, 0, 0, 0);
            this.stateWorkPosition.Name = "stateWorkPosition";
            this.stateWorkPosition.Size = new System.Drawing.Size(223, 20);
            this.stateWorkPosition.State = null;
            this.stateWorkPosition.TabIndex = 0;
            // 
            // stateReady
            // 
            this.stateReady.Caption = "цепь готовности";
            this.stateReady.CaptionAtRight = false;
            this.stateReady.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.stateReady.LampColorNone = System.Drawing.Color.Gray;
            this.stateReady.LampColorOff = System.Drawing.SystemColors.Control;
            this.stateReady.LampColorOn = System.Drawing.Color.Lime;
            this.stateReady.Location = new System.Drawing.Point(7, 80);
            this.stateReady.Margin = new System.Windows.Forms.Padding(7, 0, 0, 0);
            this.stateReady.Name = "stateReady";
            this.stateReady.Size = new System.Drawing.Size(224, 20);
            this.stateReady.State = null;
            this.stateReady.TabIndex = 0;
            // 
            // stateStartButton
            // 
            this.stateStartButton.Caption = "кнопка Пуск";
            this.stateStartButton.CaptionAtRight = false;
            this.stateStartButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.stateStartButton.LampColorNone = System.Drawing.Color.Gray;
            this.stateStartButton.LampColorOff = System.Drawing.SystemColors.Control;
            this.stateStartButton.LampColorOn = System.Drawing.Color.Red;
            this.stateStartButton.Location = new System.Drawing.Point(7, 20);
            this.stateStartButton.Margin = new System.Windows.Forms.Padding(7, 0, 0, 0);
            this.stateStartButton.Name = "stateStartButton";
            this.stateStartButton.Size = new System.Drawing.Size(223, 20);
            this.stateStartButton.State = null;
            this.stateStartButton.TabIndex = 0;
            // 
            // stateBigValve
            // 
            this.stateBigValve.Caption = "конечник большого клапана";
            this.stateBigValve.CaptionAtRight = false;
            this.stateBigValve.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.stateBigValve.LampColorNone = System.Drawing.Color.Gray;
            this.stateBigValve.LampColorOff = System.Drawing.SystemColors.Control;
            this.stateBigValve.LampColorOn = System.Drawing.Color.Lime;
            this.stateBigValve.Location = new System.Drawing.Point(7, 40);
            this.stateBigValve.Margin = new System.Windows.Forms.Padding(7, 0, 0, 0);
            this.stateBigValve.Name = "stateBigValve";
            this.stateBigValve.Size = new System.Drawing.Size(223, 20);
            this.stateBigValve.State = null;
            this.stateBigValve.TabIndex = 0;
            // 
            // stateSmallValve
            // 
            this.stateSmallValve.Caption = "конечник малого клапана";
            this.stateSmallValve.CaptionAtRight = false;
            this.stateSmallValve.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.stateSmallValve.LampColorNone = System.Drawing.Color.Gray;
            this.stateSmallValve.LampColorOff = System.Drawing.SystemColors.Control;
            this.stateSmallValve.LampColorOn = System.Drawing.Color.Lime;
            this.stateSmallValve.Location = new System.Drawing.Point(7, 60);
            this.stateSmallValve.Margin = new System.Windows.Forms.Padding(7, 0, 0, 0);
            this.stateSmallValve.Name = "stateSmallValve";
            this.stateSmallValve.Size = new System.Drawing.Size(223, 20);
            this.stateSmallValve.State = null;
            this.stateSmallValve.TabIndex = 0;
            // 
            // stateSmallValveError
            // 
            this.stateSmallValveError.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.stateSmallValveError.Caption = "ошибка малого клапана";
            this.stateSmallValveError.CaptionAtRight = false;
            this.stateSmallValveError.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.stateSmallValveError.LampColorNone = System.Drawing.Color.Gray;
            this.stateSmallValveError.LampColorOff = System.Drawing.SystemColors.Control;
            this.stateSmallValveError.LampColorOn = System.Drawing.Color.Red;
            this.stateSmallValveError.Location = new System.Drawing.Point(238, 180);
            this.stateSmallValveError.Margin = new System.Windows.Forms.Padding(0);
            this.stateSmallValveError.Name = "stateSmallValveError";
            this.stateSmallValveError.Size = new System.Drawing.Size(226, 20);
            this.stateSmallValveError.State = null;
            this.stateSmallValveError.TabIndex = 0;
            // 
            // listBox1
            // 
            this.listBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBox1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 15;
            this.listBox1.Location = new System.Drawing.Point(5, 7);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(233, 45);
            this.listBox1.TabIndex = 2;
            this.listBox1.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.listBox1_DrawItem);
            // 
            // RiserStatusControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.tableLayoutPanel6);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "RiserStatusControl";
            this.Size = new System.Drawing.Size(488, 581);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel4.ResumeLayout(false);
            this.flowLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel5.PerformLayout();
            this.flowLayoutPanel6.ResumeLayout(false);
            this.flowLayoutPanel6.PerformLayout();
            this.tableLayoutPanel6.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel4;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel5;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label lbAnalogLevel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Label lbAutomatState;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.Label lbStopCount;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel6;
        private UcRiserOneState stateStartButton;
        private UcRiserOneState stateBigValve;
        private UcRiserOneState stateSmallValve;
        private UcRiserOneState stateReady;
        private UcRiserOneState stateWorkPosition;
        private UcRiserOneState stateCheckGround;
        private UcRiserOneState stateCheckLevel;
        private UcRiserOneState stateHandButton;
        private UcRiserOneState stateAlarmLevel;
        private UcRiserOneState stateAlarmLevelMax;
        private UcRiserOneState stateAlarmLevelMin;
        private UcRiserOneState stateAnalogLevelMax;
        private UcRiserOneState stateAnalogLevelMin;
        private UcRiserOneState stateStopButton;
        private UcRiserOneState stateReadyError;
        private UcRiserOneState stateBigValveError;
        private UcRiserOneState stateSmallValveError;
        private UcRiserOneState stateGroundError;
        private UcRiserOneState stateLevelError;
        private UcRiserOneState commandOpenBigValve;
        private UcRiserOneState commandOpenSmallValve;
        private UcRiserOneState commandGreenLampOn;
        private UcRiserOneState commandBlueLampOn;
        private UcRiserOneState stopKind0;
        private UcRiserOneState stopKind1;
        private UcRiserOneState stopKind2;
        private UcRiserOneState stopKind3;
        private UcRiserOneState stopKind4;
        private UcRiserOneState stopKind5;
        private UcRiserOneState stopKind6;
        private UcRiserOneState stopKind7;
        private UcRiserOneState stopKind8;
        private UcRiserOneState stopKind9;
        private UcRiserOneState stopKind10;
        private UcRiserOneState stopKind11;
        private UcRiserOneState stopKind12;
        private UcRiserOneState stopKind13;
        private UcRiserOneState stopKind14;
        private UcRiserOneState stopKind15;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel6;
        private System.Windows.Forms.ListBox listBox1;
    }
}
