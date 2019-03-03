﻿using MaterialSkin;

namespace BitmexBot
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
            this.components = new System.ComponentModel.Container();
            this.btnBuy = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnSell = new System.Windows.Forms.Button();
            this.nudQty = new System.Windows.Forms.NumericUpDown();
            this.chkCancelWhileOrdering = new System.Windows.Forms.CheckBox();
            this.btnCancelOpenOrders = new System.Windows.Forms.Button();
            this.ddlOrderType = new System.Windows.Forms.ComboBox();
            this.ddlNetwork = new System.Windows.Forms.ComboBox();
            this.ddlSymbol = new System.Windows.Forms.ComboBox();
            this.ddlCandleTimes = new System.Windows.Forms.ComboBox();
            this.gbCandles = new System.Windows.Forms.GroupBox();
            this.chkUpdateCandles = new System.Windows.Forms.CheckBox();
            this.tmrCandleUpdater = new System.Windows.Forms.Timer(this.components);
            this.rdoBuy = new System.Windows.Forms.RadioButton();
            this.rdoSell = new System.Windows.Forms.RadioButton();
            this.rdoSwitch = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chkPumpDumpProtection = new System.Windows.Forms.CheckBox();
            this.chkDiversification = new System.Windows.Forms.CheckBox();
            this.label13 = new System.Windows.Forms.Label();
            this.nuDiversification = new System.Windows.Forms.NumericUpDown();
            this.lblAutoUnrealizedROEPercent = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.nudAutoMarketTakeProfitPercent = new System.Windows.Forms.NumericUpDown();
            this.chkAutoMarketTakeProfits = new System.Windows.Forms.CheckBox();
            this.ddlAutoOrderType = new System.Windows.Forms.ComboBox();
            this.nudAutoQuantity = new System.Windows.Forms.NumericUpDown();
            this.btnAutomatedTrading = new MaterialSkin.Controls.MaterialRaisedButton();
            this.tmrAutoTradeExecution = new System.Windows.Forms.Timer(this.components);
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.stsAPIValid = new System.Windows.Forms.ToolStripStatusLabel();
            this.stsAccountBalance = new System.Windows.Forms.ToolStripStatusLabel();
            this.stsOTProgress = new System.Windows.Forms.ToolStripProgressBar();
            this.btnAccountBalance = new System.Windows.Forms.Button();
            this.nudStopPercent = new System.Windows.Forms.NumericUpDown();
            this.btnManualSetStop = new System.Windows.Forms.Button();
            this.txtAPIKey = new System.Windows.Forms.TextBox();
            this.txtAPISecret = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnBuyOverTimeOrder = new System.Windows.Forms.Button();
            this.btnSellOverTimeOrder = new System.Windows.Forms.Button();
            this.tmrTradeOverTime = new System.Windows.Forms.Timer(this.components);
            this.nudOverTimeContracts = new System.Windows.Forms.NumericUpDown();
            this.nudOverTimeInterval = new System.Windows.Forms.NumericUpDown();
            this.nudOverTimeIntervalCount = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblOverTimeSummary = new System.Windows.Forms.Label();
            this.btnOverTimeStop = new System.Windows.Forms.Button();
            this.btnBulkTest = new System.Windows.Forms.Button();
            this.btnBulkShift = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblMA2 = new System.Windows.Forms.Label();
            this.nudMA2 = new System.Windows.Forms.NumericUpDown();
            this.lblMA1 = new System.Windows.Forms.Label();
            this.nudMA1 = new System.Windows.Forms.NumericUpDown();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.cbEma = new System.Windows.Forms.CheckBox();
            this.label8 = new System.Windows.Forms.Label();
            this.nuEMA2 = new System.Windows.Forms.NumericUpDown();
            this.label11 = new System.Windows.Forms.Label();
            this.nuEMA1 = new System.Windows.Forms.NumericUpDown();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.cbRSI = new System.Windows.Forms.CheckBox();
            this.label10 = new System.Windows.Forms.Label();
            this.nuRSIDown = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.nuRSIUp = new System.Windows.Forms.NumericUpDown();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.cbStochastic = new System.Windows.Forms.CheckBox();
            this.label9 = new System.Windows.Forms.Label();
            this.nuStochDown = new System.Windows.Forms.NumericUpDown();
            this.label12 = new System.Windows.Forms.Label();
            this.nuStochUp = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.nudQty)).BeginInit();
            this.gbCandles.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nuDiversification)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAutoMarketTakeProfitPercent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAutoQuantity)).BeginInit();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudStopPercent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudOverTimeContracts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudOverTimeInterval)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudOverTimeIntervalCount)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudMA2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMA1)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nuEMA2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nuEMA1)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nuRSIDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nuRSIUp)).BeginInit();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nuStochDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nuStochUp)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBuy
            // 
            this.btnBuy.BackColor = System.Drawing.Color.Blue;
            this.btnBuy.Depth = 0;
            this.btnBuy.Location = new System.Drawing.Point(16, 149);
            this.btnBuy.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnBuy.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnBuy.Name = "btnBuy";
            this.btnBuy.Primary = true;
            this.btnBuy.Size = new System.Drawing.Size(112, 35);
            this.btnBuy.TabIndex = 0;
            this.btnBuy.Text = "Buy";
            this.btnBuy.UseVisualStyleBackColor = false;
            this.btnBuy.UseWaitCursor = true;
            this.btnBuy.Click += new System.EventHandler(this.btnBuy_Click);
            // 
            // btnSell
            // 
            this.btnSell.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnSell.Location = new System.Drawing.Point(296, 149);
            this.btnSell.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSell.Name = "btnSell";
            this.btnSell.Size = new System.Drawing.Size(112, 35);
            this.btnSell.TabIndex = 1;
            this.btnSell.Text = "Sell";
            this.btnSell.UseVisualStyleBackColor = false;
            this.btnSell.UseWaitCursor = true;
            this.btnSell.Click += new System.EventHandler(this.btnSell_Click);
            // 
            // nudQty
            // 
            this.nudQty.Increment = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.nudQty.Location = new System.Drawing.Point(165, 152);
            this.nudQty.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.nudQty.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.nudQty.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudQty.Name = "nudQty";
            this.nudQty.Size = new System.Drawing.Size(100, 26);
            this.nudQty.TabIndex = 2;
            this.nudQty.UseWaitCursor = true;
            this.nudQty.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // chkCancelWhileOrdering
            // 
            this.chkCancelWhileOrdering.AutoSize = true;
            this.chkCancelWhileOrdering.Checked = true;
            this.chkCancelWhileOrdering.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkCancelWhileOrdering.Location = new System.Drawing.Point(20, 195);
            this.chkCancelWhileOrdering.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chkCancelWhileOrdering.Name = "chkCancelWhileOrdering";
            this.chkCancelWhileOrdering.Size = new System.Drawing.Size(192, 24);
            this.chkCancelWhileOrdering.TabIndex = 3;
            this.chkCancelWhileOrdering.Text = "Cancel While Ordering";
            this.chkCancelWhileOrdering.UseVisualStyleBackColor = true;
            this.chkCancelWhileOrdering.UseWaitCursor = true;
            // 
            // btnCancelOpenOrders
            // 
            this.btnCancelOpenOrders.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnCancelOpenOrders.Location = new System.Drawing.Point(296, 189);
            this.btnCancelOpenOrders.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCancelOpenOrders.Name = "btnCancelOpenOrders";
            this.btnCancelOpenOrders.Size = new System.Drawing.Size(112, 35);
            this.btnCancelOpenOrders.TabIndex = 4;
            this.btnCancelOpenOrders.Text = "Cancel";
            this.btnCancelOpenOrders.UseVisualStyleBackColor = false;
            this.btnCancelOpenOrders.UseWaitCursor = true;
            this.btnCancelOpenOrders.Click += new System.EventHandler(this.btnCancelOpenOrders_Click);
            // 
            // ddlOrderType
            // 
            this.ddlOrderType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddlOrderType.FormattingEnabled = true;
            this.ddlOrderType.Items.AddRange(new object[] {
            "Market",
            "Limit Post Only"});
            this.ddlOrderType.Location = new System.Drawing.Point(15, 109);
            this.ddlOrderType.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ddlOrderType.Name = "ddlOrderType";
            this.ddlOrderType.Size = new System.Drawing.Size(145, 28);
            this.ddlOrderType.TabIndex = 5;
            this.ddlOrderType.UseWaitCursor = true;
            // 
            // ddlNetwork
            // 
            this.ddlNetwork.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddlNetwork.FormattingEnabled = true;
            this.ddlNetwork.Items.AddRange(new object[] {
            "TestNet",
            "RealNet"});
            this.ddlNetwork.Location = new System.Drawing.Point(176, 108);
            this.ddlNetwork.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ddlNetwork.Name = "ddlNetwork";
            this.ddlNetwork.Size = new System.Drawing.Size(108, 28);
            this.ddlNetwork.TabIndex = 6;
            this.ddlNetwork.UseWaitCursor = true;
            this.ddlNetwork.SelectedIndexChanged += new System.EventHandler(this.ddlNetwork_SelectedIndexChanged);
            // 
            // ddlSymbol
            // 
            this.ddlSymbol.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddlSymbol.FormattingEnabled = true;
            this.ddlSymbol.Location = new System.Drawing.Point(298, 108);
            this.ddlSymbol.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ddlSymbol.Name = "ddlSymbol";
            this.ddlSymbol.Size = new System.Drawing.Size(108, 28);
            this.ddlSymbol.TabIndex = 7;
            this.ddlSymbol.UseWaitCursor = true;
            this.ddlSymbol.SelectedIndexChanged += new System.EventHandler(this.ddlSymbol_SelectedIndexChanged);
            // 
            // ddlCandleTimes
            // 
            this.ddlCandleTimes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddlCandleTimes.FormattingEnabled = true;
            this.ddlCandleTimes.Items.AddRange(new object[] {
            "1m",
            "5m",
            "1h",
            "1d"});
            this.ddlCandleTimes.Location = new System.Drawing.Point(9, 29);
            this.ddlCandleTimes.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ddlCandleTimes.Name = "ddlCandleTimes";
            this.ddlCandleTimes.Size = new System.Drawing.Size(98, 28);
            this.ddlCandleTimes.TabIndex = 9;
            this.ddlCandleTimes.UseWaitCursor = true;
            this.ddlCandleTimes.SelectedIndexChanged += new System.EventHandler(this.ddlCandleTimes_SelectedIndexChanged);
            // 
            // gbCandles
            // 
            this.gbCandles.Controls.Add(this.chkUpdateCandles);
            this.gbCandles.Controls.Add(this.ddlCandleTimes);
            this.gbCandles.Location = new System.Drawing.Point(20, 313);
            this.gbCandles.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbCandles.Name = "gbCandles";
            this.gbCandles.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbCandles.Size = new System.Drawing.Size(277, 95);
            this.gbCandles.TabIndex = 10;
            this.gbCandles.TabStop = false;
            this.gbCandles.Text = "Candles";
            // 
            // chkUpdateCandles
            // 
            this.chkUpdateCandles.AutoSize = true;
            this.chkUpdateCandles.Checked = true;
            this.chkUpdateCandles.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkUpdateCandles.Location = new System.Drawing.Point(115, 31);
            this.chkUpdateCandles.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chkUpdateCandles.Name = "chkUpdateCandles";
            this.chkUpdateCandles.Size = new System.Drawing.Size(161, 24);
            this.chkUpdateCandles.TabIndex = 12;
            this.chkUpdateCandles.Text = "Update Every 10s";
            this.chkUpdateCandles.UseVisualStyleBackColor = true;
            this.chkUpdateCandles.UseWaitCursor = true;
            this.chkUpdateCandles.CheckedChanged += new System.EventHandler(this.chkUpdateCandles_CheckedChanged);
            // 
            // tmrCandleUpdater
            // 
            this.tmrCandleUpdater.Interval = 10000;
            this.tmrCandleUpdater.Tick += new System.EventHandler(this.tmrCandleUpdater_Tick);
            // 
            // rdoBuy
            // 
            this.rdoBuy.AutoSize = true;
            this.rdoBuy.Checked = true;
            this.rdoBuy.Location = new System.Drawing.Point(237, 20);
            this.rdoBuy.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rdoBuy.Name = "rdoBuy";
            this.rdoBuy.Size = new System.Drawing.Size(61, 24);
            this.rdoBuy.TabIndex = 11;
            this.rdoBuy.TabStop = true;
            this.rdoBuy.Text = "Buy";
            this.rdoBuy.UseVisualStyleBackColor = true;
            this.rdoBuy.UseWaitCursor = true;
            // 
            // rdoSell
            // 
            this.rdoSell.AutoSize = true;
            this.rdoSell.Location = new System.Drawing.Point(237, 48);
            this.rdoSell.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rdoSell.Name = "rdoSell";
            this.rdoSell.Size = new System.Drawing.Size(60, 24);
            this.rdoSell.TabIndex = 12;
            this.rdoSell.Text = "Sell";
            this.rdoSell.UseVisualStyleBackColor = true;
            this.rdoSell.UseWaitCursor = true;
            // 
            // rdoSwitch
            // 
            this.rdoSwitch.AutoSize = true;
            this.rdoSwitch.Location = new System.Drawing.Point(237, 72);
            this.rdoSwitch.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rdoSwitch.Name = "rdoSwitch";
            this.rdoSwitch.Size = new System.Drawing.Size(81, 24);
            this.rdoSwitch.TabIndex = 13;
            this.rdoSwitch.Text = "Switch";
            this.rdoSwitch.UseVisualStyleBackColor = true;
            this.rdoSwitch.UseWaitCursor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chkPumpDumpProtection);
            this.groupBox1.Controls.Add(this.chkDiversification);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.nuDiversification);
            this.groupBox1.Controls.Add(this.lblAutoUnrealizedROEPercent);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.nudAutoMarketTakeProfitPercent);
            this.groupBox1.Controls.Add(this.chkAutoMarketTakeProfits);
            this.groupBox1.Controls.Add(this.ddlAutoOrderType);
            this.groupBox1.Controls.Add(this.nudAutoQuantity);
            this.groupBox1.Controls.Add(this.btnAutomatedTrading);
            this.groupBox1.Controls.Add(this.rdoSell);
            this.groupBox1.Controls.Add(this.rdoSwitch);
            this.groupBox1.Controls.Add(this.rdoBuy);
            this.groupBox1.Location = new System.Drawing.Point(1166, 80);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(521, 223);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Automated Trading";
            // 
            // chkPumpDumpProtection
            // 
            this.chkPumpDumpProtection.AutoSize = true;
            this.chkPumpDumpProtection.Location = new System.Drawing.Point(10, 181);
            this.chkPumpDumpProtection.Name = "chkPumpDumpProtection";
            this.chkPumpDumpProtection.Size = new System.Drawing.Size(226, 24);
            this.chkPumpDumpProtection.TabIndex = 27;
            this.chkPumpDumpProtection.Text = "Pump and dump protection";
            this.chkPumpDumpProtection.UseVisualStyleBackColor = true;
            // 
            // chkDiversification
            // 
            this.chkDiversification.AutoSize = true;
            this.chkDiversification.Location = new System.Drawing.Point(10, 149);
            this.chkDiversification.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chkDiversification.Name = "chkDiversification";
            this.chkDiversification.Size = new System.Drawing.Size(133, 24);
            this.chkDiversification.TabIndex = 24;
            this.chkDiversification.Text = "Diversification";
            this.chkDiversification.UseVisualStyleBackColor = true;
            this.chkDiversification.UseWaitCursor = true;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(293, 158);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(91, 20);
            this.label13.TabIndex = 23;
            this.label13.Text = "Percentage";
            this.label13.UseWaitCursor = true;
            // 
            // nuDiversification
            // 
            this.nuDiversification.DecimalPlaces = 2;
            this.nuDiversification.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.nuDiversification.Location = new System.Drawing.Point(195, 152);
            this.nuDiversification.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.nuDiversification.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.nuDiversification.Name = "nuDiversification";
            this.nuDiversification.Size = new System.Drawing.Size(90, 26);
            this.nuDiversification.TabIndex = 22;
            this.nuDiversification.UseWaitCursor = true;
            this.nuDiversification.Value = new decimal(new int[] {
            25,
            0,
            0,
            0});
            // 
            // lblAutoUnrealizedROEPercent
            // 
            this.lblAutoUnrealizedROEPercent.AutoSize = true;
            this.lblAutoUnrealizedROEPercent.Location = new System.Drawing.Point(302, 140);
            this.lblAutoUnrealizedROEPercent.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAutoUnrealizedROEPercent.Name = "lblAutoUnrealizedROEPercent";
            this.lblAutoUnrealizedROEPercent.Size = new System.Drawing.Size(0, 20);
            this.lblAutoUnrealizedROEPercent.TabIndex = 21;
            this.lblAutoUnrealizedROEPercent.UseWaitCursor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(289, 122);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(181, 20);
            this.label1.TabIndex = 20;
            this.label1.Text = "Unrealized Mark ROE %";
            this.label1.UseWaitCursor = true;
            // 
            // nudAutoMarketTakeProfitPercent
            // 
            this.nudAutoMarketTakeProfitPercent.DecimalPlaces = 2;
            this.nudAutoMarketTakeProfitPercent.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.nudAutoMarketTakeProfitPercent.Location = new System.Drawing.Point(195, 118);
            this.nudAutoMarketTakeProfitPercent.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.nudAutoMarketTakeProfitPercent.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.nudAutoMarketTakeProfitPercent.Name = "nudAutoMarketTakeProfitPercent";
            this.nudAutoMarketTakeProfitPercent.Size = new System.Drawing.Size(90, 26);
            this.nudAutoMarketTakeProfitPercent.TabIndex = 19;
            this.nudAutoMarketTakeProfitPercent.UseWaitCursor = true;
            this.nudAutoMarketTakeProfitPercent.Value = new decimal(new int[] {
            25,
            0,
            0,
            0});
            // 
            // chkAutoMarketTakeProfits
            // 
            this.chkAutoMarketTakeProfits.AutoSize = true;
            this.chkAutoMarketTakeProfits.Checked = true;
            this.chkAutoMarketTakeProfits.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkAutoMarketTakeProfits.Location = new System.Drawing.Point(10, 118);
            this.chkAutoMarketTakeProfits.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chkAutoMarketTakeProfits.Name = "chkAutoMarketTakeProfits";
            this.chkAutoMarketTakeProfits.Size = new System.Drawing.Size(185, 24);
            this.chkAutoMarketTakeProfits.TabIndex = 16;
            this.chkAutoMarketTakeProfits.Text = "Market take profits at";
            this.chkAutoMarketTakeProfits.UseVisualStyleBackColor = true;
            this.chkAutoMarketTakeProfits.UseWaitCursor = true;
            // 
            // ddlAutoOrderType
            // 
            this.ddlAutoOrderType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddlAutoOrderType.FormattingEnabled = true;
            this.ddlAutoOrderType.Items.AddRange(new object[] {
            "Market",
            "Limit Post Only"});
            this.ddlAutoOrderType.Location = new System.Drawing.Point(352, 14);
            this.ddlAutoOrderType.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ddlAutoOrderType.Name = "ddlAutoOrderType";
            this.ddlAutoOrderType.Size = new System.Drawing.Size(145, 28);
            this.ddlAutoOrderType.TabIndex = 15;
            this.ddlAutoOrderType.UseWaitCursor = true;
            // 
            // nudAutoQuantity
            // 
            this.nudAutoQuantity.Increment = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.nudAutoQuantity.Location = new System.Drawing.Point(399, 66);
            this.nudAutoQuantity.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.nudAutoQuantity.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.nudAutoQuantity.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudAutoQuantity.Name = "nudAutoQuantity";
            this.nudAutoQuantity.Size = new System.Drawing.Size(100, 26);
            this.nudAutoQuantity.TabIndex = 15;
            this.nudAutoQuantity.UseWaitCursor = true;
            this.nudAutoQuantity.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // btnAutomatedTrading
            // 
            this.btnAutomatedTrading.BackColor = System.Drawing.Color.LightGreen;
            this.btnAutomatedTrading.Depth = 0;
            this.btnAutomatedTrading.Font = new System.Drawing.Font("Book Antiqua", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAutomatedTrading.Location = new System.Drawing.Point(10, 32);
            this.btnAutomatedTrading.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAutomatedTrading.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnAutomatedTrading.Name = "btnAutomatedTrading";
            this.btnAutomatedTrading.Primary = true;
            this.btnAutomatedTrading.Size = new System.Drawing.Size(218, 77);
            this.btnAutomatedTrading.TabIndex = 14;
            this.btnAutomatedTrading.Text = "Start";
            this.btnAutomatedTrading.UseVisualStyleBackColor = false;
            this.btnAutomatedTrading.UseWaitCursor = true;
            this.btnAutomatedTrading.Click += new System.EventHandler(this.btnAutomatedTrading_Click);
            // 
            // tmrAutoTradeExecution
            // 
            this.tmrAutoTradeExecution.Interval = 5000;
            this.tmrAutoTradeExecution.Tick += new System.EventHandler(this.tmrAutoTradeExecution_Tick);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.stsAPIValid,
            this.stsAccountBalance,
            this.stsOTProgress});
            this.statusStrip1.Location = new System.Drawing.Point(0, 419);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(2, 0, 21, 0);
            this.statusStrip1.Size = new System.Drawing.Size(1700, 30);
            this.statusStrip1.TabIndex = 15;
            this.statusStrip1.Text = "statusStrip1";
            this.statusStrip1.UseWaitCursor = true;
            // 
            // stsAPIValid
            // 
            this.stsAPIValid.Name = "stsAPIValid";
            this.stsAPIValid.Size = new System.Drawing.Size(164, 25);
            this.stsAPIValid.Text = "API keys are invalid";
            // 
            // stsAccountBalance
            // 
            this.stsAccountBalance.Name = "stsAccountBalance";
            this.stsAccountBalance.Size = new System.Drawing.Size(90, 25);
            this.stsAccountBalance.Text = "Balance: 0";
            // 
            // stsOTProgress
            // 
            this.stsOTProgress.Name = "stsOTProgress";
            this.stsOTProgress.Size = new System.Drawing.Size(150, 25);
            this.stsOTProgress.Visible = false;
            // 
            // btnAccountBalance
            // 
            this.btnAccountBalance.Location = new System.Drawing.Point(1044, 203);
            this.btnAccountBalance.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAccountBalance.Name = "btnAccountBalance";
            this.btnAccountBalance.Size = new System.Drawing.Size(112, 35);
            this.btnAccountBalance.TabIndex = 16;
            this.btnAccountBalance.Text = "Update Balance";
            this.btnAccountBalance.UseVisualStyleBackColor = true;
            this.btnAccountBalance.UseWaitCursor = true;
            this.btnAccountBalance.Click += new System.EventHandler(this.btnAccountBalance_Click);
            // 
            // nudStopPercent
            // 
            this.nudStopPercent.DecimalPlaces = 2;
            this.nudStopPercent.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.nudStopPercent.Location = new System.Drawing.Point(195, 229);
            this.nudStopPercent.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.nudStopPercent.Name = "nudStopPercent";
            this.nudStopPercent.Size = new System.Drawing.Size(90, 26);
            this.nudStopPercent.TabIndex = 17;
            this.nudStopPercent.UseWaitCursor = true;
            this.nudStopPercent.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btnManualSetStop
            // 
            this.btnManualSetStop.Location = new System.Drawing.Point(296, 228);
            this.btnManualSetStop.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnManualSetStop.Name = "btnManualSetStop";
            this.btnManualSetStop.Size = new System.Drawing.Size(112, 35);
            this.btnManualSetStop.TabIndex = 18;
            this.btnManualSetStop.Text = "Set Stop";
            this.btnManualSetStop.UseVisualStyleBackColor = true;
            this.btnManualSetStop.UseWaitCursor = true;
            this.btnManualSetStop.Click += new System.EventHandler(this.btnManualSetStop_Click);
            // 
            // txtAPIKey
            // 
            this.txtAPIKey.Location = new System.Drawing.Point(1044, 111);
            this.txtAPIKey.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtAPIKey.Name = "txtAPIKey";
            this.txtAPIKey.Size = new System.Drawing.Size(110, 26);
            this.txtAPIKey.TabIndex = 19;
            this.txtAPIKey.UseSystemPasswordChar = true;
            this.txtAPIKey.UseWaitCursor = true;
            this.txtAPIKey.TextChanged += new System.EventHandler(this.txtAPIKey_TextChanged);
            // 
            // txtAPISecret
            // 
            this.txtAPISecret.Location = new System.Drawing.Point(1044, 158);
            this.txtAPISecret.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtAPISecret.Name = "txtAPISecret";
            this.txtAPISecret.Size = new System.Drawing.Size(110, 26);
            this.txtAPISecret.TabIndex = 20;
            this.txtAPISecret.UseSystemPasswordChar = true;
            this.txtAPISecret.UseWaitCursor = true;
            this.txtAPISecret.TextChanged += new System.EventHandler(this.txtAPISecret_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(998, 122);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 20);
            this.label2.TabIndex = 22;
            this.label2.Text = "Key";
            this.label2.UseWaitCursor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(978, 165);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 20);
            this.label3.TabIndex = 23;
            this.label3.Text = "Secret";
            this.label3.UseWaitCursor = true;
            // 
            // btnBuyOverTimeOrder
            // 
            this.btnBuyOverTimeOrder.Location = new System.Drawing.Point(444, 108);
            this.btnBuyOverTimeOrder.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnBuyOverTimeOrder.Name = "btnBuyOverTimeOrder";
            this.btnBuyOverTimeOrder.Size = new System.Drawing.Size(112, 35);
            this.btnBuyOverTimeOrder.TabIndex = 24;
            this.btnBuyOverTimeOrder.Text = "Buy Over Time";
            this.btnBuyOverTimeOrder.UseVisualStyleBackColor = true;
            this.btnBuyOverTimeOrder.UseWaitCursor = true;
            this.btnBuyOverTimeOrder.Click += new System.EventHandler(this.btnBuyOverTimeOrder_Click);
            // 
            // btnSellOverTimeOrder
            // 
            this.btnSellOverTimeOrder.Location = new System.Drawing.Point(584, 108);
            this.btnSellOverTimeOrder.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSellOverTimeOrder.Name = "btnSellOverTimeOrder";
            this.btnSellOverTimeOrder.Size = new System.Drawing.Size(112, 35);
            this.btnSellOverTimeOrder.TabIndex = 25;
            this.btnSellOverTimeOrder.Text = "Sell Over Time";
            this.btnSellOverTimeOrder.UseVisualStyleBackColor = true;
            this.btnSellOverTimeOrder.UseWaitCursor = true;
            this.btnSellOverTimeOrder.Click += new System.EventHandler(this.btnSellOverTimeOrder_Click);
            // 
            // tmrTradeOverTime
            // 
            this.tmrTradeOverTime.Tick += new System.EventHandler(this.tmrTradeOverTime_Tick);
            // 
            // nudOverTimeContracts
            // 
            this.nudOverTimeContracts.Location = new System.Drawing.Point(446, 185);
            this.nudOverTimeContracts.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.nudOverTimeContracts.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.nudOverTimeContracts.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudOverTimeContracts.Name = "nudOverTimeContracts";
            this.nudOverTimeContracts.Size = new System.Drawing.Size(112, 26);
            this.nudOverTimeContracts.TabIndex = 26;
            this.nudOverTimeContracts.UseWaitCursor = true;
            this.nudOverTimeContracts.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.nudOverTimeContracts.ValueChanged += new System.EventHandler(this.nudOverTimeContracts_ValueChanged);
            // 
            // nudOverTimeInterval
            // 
            this.nudOverTimeInterval.Location = new System.Drawing.Point(572, 185);
            this.nudOverTimeInterval.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.nudOverTimeInterval.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.nudOverTimeInterval.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudOverTimeInterval.Name = "nudOverTimeInterval";
            this.nudOverTimeInterval.Size = new System.Drawing.Size(112, 26);
            this.nudOverTimeInterval.TabIndex = 27;
            this.nudOverTimeInterval.UseWaitCursor = true;
            this.nudOverTimeInterval.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudOverTimeInterval.ValueChanged += new System.EventHandler(this.nudOverTimeInterval_ValueChanged);
            // 
            // nudOverTimeIntervalCount
            // 
            this.nudOverTimeIntervalCount.Location = new System.Drawing.Point(666, 185);
            this.nudOverTimeIntervalCount.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.nudOverTimeIntervalCount.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.nudOverTimeIntervalCount.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudOverTimeIntervalCount.Name = "nudOverTimeIntervalCount";
            this.nudOverTimeIntervalCount.Size = new System.Drawing.Size(112, 26);
            this.nudOverTimeIntervalCount.TabIndex = 28;
            this.nudOverTimeIntervalCount.UseWaitCursor = true;
            this.nudOverTimeIntervalCount.Value = new decimal(new int[] {
            6,
            0,
            0,
            0});
            this.nudOverTimeIntervalCount.ValueChanged += new System.EventHandler(this.nudOverTimeIntervalCount_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(441, 160);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 20);
            this.label4.TabIndex = 22;
            this.label4.Text = "Contracts Per";
            this.label4.UseWaitCursor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(568, 160);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 20);
            this.label5.TabIndex = 29;
            this.label5.Text = "Seconds";
            this.label5.UseWaitCursor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(669, 160);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 20);
            this.label6.TabIndex = 30;
            this.label6.Text = "X Times";
            this.label6.UseWaitCursor = true;
            // 
            // lblOverTimeSummary
            // 
            this.lblOverTimeSummary.AutoSize = true;
            this.lblOverTimeSummary.Location = new System.Drawing.Point(441, 217);
            this.lblOverTimeSummary.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblOverTimeSummary.Name = "lblOverTimeSummary";
            this.lblOverTimeSummary.Size = new System.Drawing.Size(151, 20);
            this.lblOverTimeSummary.TabIndex = 22;
            this.lblOverTimeSummary.Text = "Over Time Summary";
            this.lblOverTimeSummary.UseWaitCursor = true;
            // 
            // btnOverTimeStop
            // 
            this.btnOverTimeStop.Location = new System.Drawing.Point(726, 106);
            this.btnOverTimeStop.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnOverTimeStop.Name = "btnOverTimeStop";
            this.btnOverTimeStop.Size = new System.Drawing.Size(112, 35);
            this.btnOverTimeStop.TabIndex = 31;
            this.btnOverTimeStop.Text = "Stop";
            this.btnOverTimeStop.UseVisualStyleBackColor = true;
            this.btnOverTimeStop.UseWaitCursor = true;
            this.btnOverTimeStop.Click += new System.EventHandler(this.btnOverTimeStop_Click);
            // 
            // btnBulkTest
            // 
            this.btnBulkTest.Location = new System.Drawing.Point(867, 108);
            this.btnBulkTest.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnBulkTest.Name = "btnBulkTest";
            this.btnBulkTest.Size = new System.Drawing.Size(112, 35);
            this.btnBulkTest.TabIndex = 32;
            this.btnBulkTest.Text = "BulkTest";
            this.btnBulkTest.UseVisualStyleBackColor = true;
            this.btnBulkTest.UseWaitCursor = true;
            this.btnBulkTest.Click += new System.EventHandler(this.btnBulkTest_Click);
            // 
            // btnBulkShift
            // 
            this.btnBulkShift.Location = new System.Drawing.Point(867, 155);
            this.btnBulkShift.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnBulkShift.Name = "btnBulkShift";
            this.btnBulkShift.Size = new System.Drawing.Size(112, 35);
            this.btnBulkShift.TabIndex = 33;
            this.btnBulkShift.Text = "Bulk Shift";
            this.btnBulkShift.UseVisualStyleBackColor = true;
            this.btnBulkShift.UseWaitCursor = true;
            this.btnBulkShift.Click += new System.EventHandler(this.btnBulkShift_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblMA2);
            this.groupBox2.Controls.Add(this.nudMA2);
            this.groupBox2.Controls.Add(this.lblMA1);
            this.groupBox2.Controls.Add(this.nudMA1);
            this.groupBox2.Location = new System.Drawing.Point(308, 313);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Size = new System.Drawing.Size(254, 95);
            this.groupBox2.TabIndex = 34;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "MA";
            // 
            // lblMA2
            // 
            this.lblMA2.AutoSize = true;
            this.lblMA2.Location = new System.Drawing.Point(198, 38);
            this.lblMA2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMA2.Name = "lblMA2";
            this.lblMA2.Size = new System.Drawing.Size(42, 20);
            this.lblMA2.TabIndex = 20;
            this.lblMA2.Text = "MA2";
            // 
            // nudMA2
            // 
            this.nudMA2.Location = new System.Drawing.Point(130, 34);
            this.nudMA2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.nudMA2.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudMA2.Name = "nudMA2";
            this.nudMA2.Size = new System.Drawing.Size(63, 26);
            this.nudMA2.TabIndex = 19;
            this.nudMA2.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // lblMA1
            // 
            this.lblMA1.AutoSize = true;
            this.lblMA1.Location = new System.Drawing.Point(84, 38);
            this.lblMA1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMA1.Name = "lblMA1";
            this.lblMA1.Size = new System.Drawing.Size(42, 20);
            this.lblMA1.TabIndex = 18;
            this.lblMA1.Text = "MA1";
            // 
            // nudMA1
            // 
            this.nudMA1.Location = new System.Drawing.Point(15, 34);
            this.nudMA1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.nudMA1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudMA1.Name = "nudMA1";
            this.nudMA1.Size = new System.Drawing.Size(63, 26);
            this.nudMA1.TabIndex = 17;
            this.nudMA1.Value = new decimal(new int[] {
            55,
            0,
            0,
            0});
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.cbEma);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.nuEMA2);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.nuEMA1);
            this.groupBox3.Location = new System.Drawing.Point(572, 313);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox3.Size = new System.Drawing.Size(254, 95);
            this.groupBox3.TabIndex = 35;
            this.groupBox3.TabStop = false;
            // 
            // cbEma
            // 
            this.cbEma.AutoSize = true;
            this.cbEma.Location = new System.Drawing.Point(19, 5);
            this.cbEma.Name = "cbEma";
            this.cbEma.Size = new System.Drawing.Size(70, 24);
            this.cbEma.TabIndex = 22;
            this.cbEma.Text = "EMA";
            this.cbEma.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(199, 39);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 20);
            this.label8.TabIndex = 16;
            this.label8.Text = "EMA2";
            // 
            // nuEMA2
            // 
            this.nuEMA2.Location = new System.Drawing.Point(131, 35);
            this.nuEMA2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.nuEMA2.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nuEMA2.Name = "nuEMA2";
            this.nuEMA2.Size = new System.Drawing.Size(63, 26);
            this.nuEMA2.TabIndex = 15;
            this.nuEMA2.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(85, 39);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(53, 20);
            this.label11.TabIndex = 14;
            this.label11.Text = "EMA1";
            // 
            // nuEMA1
            // 
            this.nuEMA1.Location = new System.Drawing.Point(16, 35);
            this.nuEMA1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.nuEMA1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nuEMA1.Name = "nuEMA1";
            this.nuEMA1.Size = new System.Drawing.Size(63, 26);
            this.nuEMA1.TabIndex = 13;
            this.nuEMA1.Value = new decimal(new int[] {
            55,
            0,
            0,
            0});
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.cbRSI);
            this.groupBox4.Controls.Add(this.label10);
            this.groupBox4.Controls.Add(this.nuRSIDown);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Controls.Add(this.nuRSIUp);
            this.groupBox4.Location = new System.Drawing.Point(835, 313);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox4.Size = new System.Drawing.Size(254, 95);
            this.groupBox4.TabIndex = 36;
            this.groupBox4.TabStop = false;
            // 
            // cbRSI
            // 
            this.cbRSI.AutoSize = true;
            this.cbRSI.Location = new System.Drawing.Point(21, 5);
            this.cbRSI.Name = "cbRSI";
            this.cbRSI.Size = new System.Drawing.Size(63, 24);
            this.cbRSI.TabIndex = 23;
            this.cbRSI.Text = "RSI";
            this.cbRSI.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(194, 38);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(50, 20);
            this.label10.TabIndex = 22;
            this.label10.Text = "Down";
            // 
            // nuRSIDown
            // 
            this.nuRSIDown.Location = new System.Drawing.Point(128, 34);
            this.nuRSIDown.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.nuRSIDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nuRSIDown.Name = "nuRSIDown";
            this.nuRSIDown.Size = new System.Drawing.Size(63, 26);
            this.nuRSIDown.TabIndex = 21;
            this.nuRSIDown.Value = new decimal(new int[] {
            14,
            0,
            0,
            0});
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(92, 38);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(30, 20);
            this.label7.TabIndex = 20;
            this.label7.Text = "Up";
            // 
            // nuRSIUp
            // 
            this.nuRSIUp.Location = new System.Drawing.Point(21, 34);
            this.nuRSIUp.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.nuRSIUp.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nuRSIUp.Name = "nuRSIUp";
            this.nuRSIUp.Size = new System.Drawing.Size(63, 26);
            this.nuRSIUp.TabIndex = 19;
            this.nuRSIUp.Value = new decimal(new int[] {
            14,
            0,
            0,
            0});
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.cbStochastic);
            this.groupBox5.Controls.Add(this.label9);
            this.groupBox5.Controls.Add(this.nuStochDown);
            this.groupBox5.Controls.Add(this.label12);
            this.groupBox5.Controls.Add(this.nuStochUp);
            this.groupBox5.Location = new System.Drawing.Point(1100, 313);
            this.groupBox5.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox5.Size = new System.Drawing.Size(254, 95);
            this.groupBox5.TabIndex = 37;
            this.groupBox5.TabStop = false;
            // 
            // cbStochastic
            // 
            this.cbStochastic.AutoSize = true;
            this.cbStochastic.Location = new System.Drawing.Point(13, 5);
            this.cbStochastic.Name = "cbStochastic";
            this.cbStochastic.Size = new System.Drawing.Size(110, 24);
            this.cbStochastic.TabIndex = 27;
            this.cbStochastic.Text = "Stochastic";
            this.cbStochastic.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(191, 38);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(50, 20);
            this.label9.TabIndex = 26;
            this.label9.Text = "Down";
            // 
            // nuStochDown
            // 
            this.nuStochDown.Location = new System.Drawing.Point(125, 34);
            this.nuStochDown.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.nuStochDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nuStochDown.Name = "nuStochDown";
            this.nuStochDown.Size = new System.Drawing.Size(63, 26);
            this.nuStochDown.TabIndex = 25;
            this.nuStochDown.Value = new decimal(new int[] {
            14,
            0,
            0,
            0});
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(84, 38);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(30, 20);
            this.label12.TabIndex = 24;
            this.label12.Text = "Up";
            // 
            // nuStochUp
            // 
            this.nuStochUp.Location = new System.Drawing.Point(13, 34);
            this.nuStochUp.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.nuStochUp.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nuStochUp.Name = "nuStochUp";
            this.nuStochUp.Size = new System.Drawing.Size(63, 26);
            this.nuStochUp.TabIndex = 23;
            this.nuStochUp.Value = new decimal(new int[] {
            14,
            0,
            0,
            0});
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1700, 449);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnBulkShift);
            this.Controls.Add(this.btnBulkTest);
            this.Controls.Add(this.btnOverTimeStop);
            this.Controls.Add(this.lblOverTimeSummary);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.nudOverTimeIntervalCount);
            this.Controls.Add(this.nudOverTimeInterval);
            this.Controls.Add(this.nudOverTimeContracts);
            this.Controls.Add(this.btnSellOverTimeOrder);
            this.Controls.Add(this.btnBuyOverTimeOrder);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtAPISecret);
            this.Controls.Add(this.txtAPIKey);
            this.Controls.Add(this.btnManualSetStop);
            this.Controls.Add(this.nudStopPercent);
            this.Controls.Add(this.btnAccountBalance);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gbCandles);
            this.Controls.Add(this.ddlSymbol);
            this.Controls.Add(this.ddlNetwork);
            this.Controls.Add(this.ddlOrderType);
            this.Controls.Add(this.btnCancelOpenOrders);
            this.Controls.Add(this.chkCancelWhileOrdering);
            this.Controls.Add(this.nudQty);
            this.Controls.Add(this.btnSell);
            this.Controls.Add(this.btnBuy);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Sizable = false;
            ((System.ComponentModel.ISupportInitialize)(this.nudQty)).EndInit();
            this.gbCandles.ResumeLayout(false);
            this.gbCandles.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nuDiversification)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAutoMarketTakeProfitPercent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAutoQuantity)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudStopPercent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudOverTimeContracts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudOverTimeInterval)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudOverTimeIntervalCount)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudMA2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMA1)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nuEMA2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nuEMA1)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nuRSIDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nuRSIUp)).EndInit();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nuStochDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nuStochUp)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MaterialSkin.Controls.MaterialRaisedButton btnBuy;
        private System.Windows.Forms.Button btnSell;
        private System.Windows.Forms.NumericUpDown nudQty;
        private System.Windows.Forms.CheckBox chkCancelWhileOrdering;
        private System.Windows.Forms.Button btnCancelOpenOrders;
        private System.Windows.Forms.ComboBox ddlOrderType;
        private System.Windows.Forms.ComboBox ddlNetwork;
        private System.Windows.Forms.ComboBox ddlSymbol;
        private System.Windows.Forms.ComboBox ddlCandleTimes;
        private System.Windows.Forms.GroupBox gbCandles;
        private System.Windows.Forms.Timer tmrCandleUpdater;
        private System.Windows.Forms.CheckBox chkUpdateCandles;
        private System.Windows.Forms.RadioButton rdoBuy;
        private System.Windows.Forms.RadioButton rdoSell;
        private System.Windows.Forms.RadioButton rdoSwitch;
        private System.Windows.Forms.GroupBox groupBox1;
        private MaterialSkin.Controls.MaterialRaisedButton btnAutomatedTrading;
        private System.Windows.Forms.ComboBox ddlAutoOrderType;
        private System.Windows.Forms.NumericUpDown nudAutoQuantity;
        private System.Windows.Forms.Timer tmrAutoTradeExecution;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel stsAPIValid;
        private System.Windows.Forms.ToolStripStatusLabel stsAccountBalance;
        private System.Windows.Forms.Button btnAccountBalance;
        private System.Windows.Forms.NumericUpDown nudStopPercent;
        private System.Windows.Forms.Button btnManualSetStop;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown nudAutoMarketTakeProfitPercent;
        private System.Windows.Forms.CheckBox chkAutoMarketTakeProfits;
        private System.Windows.Forms.Label lblAutoUnrealizedROEPercent;
        private System.Windows.Forms.TextBox txtAPIKey;
        private System.Windows.Forms.TextBox txtAPISecret;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnBuyOverTimeOrder;
        private System.Windows.Forms.Button btnSellOverTimeOrder;
        private System.Windows.Forms.Timer tmrTradeOverTime;
        private System.Windows.Forms.NumericUpDown nudOverTimeContracts;
        private System.Windows.Forms.NumericUpDown nudOverTimeInterval;
        private System.Windows.Forms.NumericUpDown nudOverTimeIntervalCount;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblOverTimeSummary;
        private System.Windows.Forms.ToolStripProgressBar stsOTProgress;
        private System.Windows.Forms.Button btnOverTimeStop;
        private System.Windows.Forms.Button btnBulkTest;
        private System.Windows.Forms.Button btnBulkShift;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblMA2;
        private System.Windows.Forms.NumericUpDown nudMA2;
        private System.Windows.Forms.Label lblMA1;
        private System.Windows.Forms.NumericUpDown nudMA1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.CheckBox cbEma;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown nuEMA2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.NumericUpDown nuEMA1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.CheckBox cbRSI;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.NumericUpDown nuRSIDown;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown nuRSIUp;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.CheckBox cbStochastic;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.NumericUpDown nuStochDown;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.NumericUpDown nuStochUp;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.NumericUpDown nuDiversification;
        private System.Windows.Forms.CheckBox chkDiversification;
        private System.Windows.Forms.CheckBox chkPumpDumpProtection;
    }
}

