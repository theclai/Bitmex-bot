using MaterialSkin;

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
            this.rdoSwitch = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chkStoploss = new System.Windows.Forms.CheckBox();
            this.label17 = new System.Windows.Forms.Label();
            this.nuStoploss = new System.Windows.Forms.NumericUpDown();
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.chkMA = new System.Windows.Forms.CheckBox();
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
            this.nuRsiSell = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.nuRsiBuy = new System.Windows.Forms.NumericUpDown();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.cbStochastic = new System.Windows.Forms.CheckBox();
            this.label9 = new System.Windows.Forms.Label();
            this.nuStochSell = new System.Windows.Forms.NumericUpDown();
            this.label12 = new System.Windows.Forms.Label();
            this.nuStochBuy = new System.Windows.Forms.NumericUpDown();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.ddlPumpDumpTime = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.nuPumpPercentage = new System.Windows.Forms.NumericUpDown();
            this.label14 = new System.Windows.Forms.Label();
            this.chkPumpdump = new System.Windows.Forms.CheckBox();
            this.lblBuildVersion = new System.Windows.Forms.Label();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.lblLeverageResult = new System.Windows.Forms.Label();
            this.btnLeverage = new System.Windows.Forms.Button();
            this.label16 = new System.Windows.Forms.Label();
            this.nuLeverageLevel = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.nudQty)).BeginInit();
            this.gbCandles.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nuStoploss)).BeginInit();
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
            ((System.ComponentModel.ISupportInitialize)(this.nuRsiSell)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nuRsiBuy)).BeginInit();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nuStochSell)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nuStochBuy)).BeginInit();
            this.groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nuPumpPercentage)).BeginInit();
            this.groupBox7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nuLeverageLevel)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBuy
            // 
            this.btnBuy.BackColor = System.Drawing.Color.Blue;
            this.btnBuy.Depth = 0;
            this.btnBuy.Location = new System.Drawing.Point(11, 139);
            this.btnBuy.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnBuy.Name = "btnBuy";
            this.btnBuy.Primary = true;
            this.btnBuy.Size = new System.Drawing.Size(75, 23);
            this.btnBuy.TabIndex = 0;
            this.btnBuy.Text = "Buy";
            this.btnBuy.UseVisualStyleBackColor = false;
            this.btnBuy.UseWaitCursor = true;
            this.btnBuy.Click += new System.EventHandler(this.btnBuy_Click);
            // 
            // btnSell
            // 
            this.btnSell.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnSell.Location = new System.Drawing.Point(197, 139);
            this.btnSell.Name = "btnSell";
            this.btnSell.Size = new System.Drawing.Size(75, 23);
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
            this.nudQty.Location = new System.Drawing.Point(123, 139);
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
            this.nudQty.Size = new System.Drawing.Size(67, 20);
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
            this.chkCancelWhileOrdering.Location = new System.Drawing.Point(13, 169);
            this.chkCancelWhileOrdering.Name = "chkCancelWhileOrdering";
            this.chkCancelWhileOrdering.Size = new System.Drawing.Size(132, 17);
            this.chkCancelWhileOrdering.TabIndex = 3;
            this.chkCancelWhileOrdering.Text = "Cancel While Ordering";
            this.chkCancelWhileOrdering.UseVisualStyleBackColor = true;
            this.chkCancelWhileOrdering.UseWaitCursor = true;
            // 
            // btnCancelOpenOrders
            // 
            this.btnCancelOpenOrders.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnCancelOpenOrders.Location = new System.Drawing.Point(197, 165);
            this.btnCancelOpenOrders.Name = "btnCancelOpenOrders";
            this.btnCancelOpenOrders.Size = new System.Drawing.Size(75, 23);
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
            this.ddlOrderType.Location = new System.Drawing.Point(10, 105);
            this.ddlOrderType.Name = "ddlOrderType";
            this.ddlOrderType.Size = new System.Drawing.Size(98, 21);
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
            this.ddlNetwork.Location = new System.Drawing.Point(117, 105);
            this.ddlNetwork.Name = "ddlNetwork";
            this.ddlNetwork.Size = new System.Drawing.Size(73, 21);
            this.ddlNetwork.TabIndex = 6;
            this.ddlNetwork.UseWaitCursor = true;
            this.ddlNetwork.SelectedIndexChanged += new System.EventHandler(this.ddlNetwork_SelectedIndexChanged);
            // 
            // ddlSymbol
            // 
            this.ddlSymbol.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddlSymbol.FormattingEnabled = true;
            this.ddlSymbol.Location = new System.Drawing.Point(199, 105);
            this.ddlSymbol.Name = "ddlSymbol";
            this.ddlSymbol.Size = new System.Drawing.Size(73, 21);
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
            this.ddlCandleTimes.Location = new System.Drawing.Point(6, 19);
            this.ddlCandleTimes.Name = "ddlCandleTimes";
            this.ddlCandleTimes.Size = new System.Drawing.Size(67, 21);
            this.ddlCandleTimes.TabIndex = 9;
            this.ddlCandleTimes.UseWaitCursor = true;
            this.ddlCandleTimes.SelectedIndexChanged += new System.EventHandler(this.ddlCandleTimes_SelectedIndexChanged);
            // 
            // gbCandles
            // 
            this.gbCandles.Controls.Add(this.chkUpdateCandles);
            this.gbCandles.Controls.Add(this.ddlCandleTimes);
            this.gbCandles.Location = new System.Drawing.Point(215, 247);
            this.gbCandles.Name = "gbCandles";
            this.gbCandles.Size = new System.Drawing.Size(212, 62);
            this.gbCandles.TabIndex = 10;
            this.gbCandles.TabStop = false;
            this.gbCandles.Text = "Candles";
            // 
            // chkUpdateCandles
            // 
            this.chkUpdateCandles.AutoSize = true;
            this.chkUpdateCandles.Checked = true;
            this.chkUpdateCandles.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkUpdateCandles.Location = new System.Drawing.Point(90, 21);
            this.chkUpdateCandles.Name = "chkUpdateCandles";
            this.chkUpdateCandles.Size = new System.Drawing.Size(111, 17);
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
            // rdoSwitch
            // 
            this.rdoSwitch.AutoSize = true;
            this.rdoSwitch.Checked = true;
            this.rdoSwitch.Location = new System.Drawing.Point(158, 47);
            this.rdoSwitch.Name = "rdoSwitch";
            this.rdoSwitch.Size = new System.Drawing.Size(57, 17);
            this.rdoSwitch.TabIndex = 13;
            this.rdoSwitch.TabStop = true;
            this.rdoSwitch.Text = "Switch";
            this.rdoSwitch.UseVisualStyleBackColor = true;
            this.rdoSwitch.UseWaitCursor = true;
            this.rdoSwitch.Visible = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chkStoploss);
            this.groupBox1.Controls.Add(this.label17);
            this.groupBox1.Controls.Add(this.nuStoploss);
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
            this.groupBox1.Controls.Add(this.rdoSwitch);
            this.groupBox1.Location = new System.Drawing.Point(588, 103);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(375, 162);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Automated Trading";
            // 
            // chkStoploss
            // 
            this.chkStoploss.AutoSize = true;
            this.chkStoploss.Location = new System.Drawing.Point(5, 109);
            this.chkStoploss.Name = "chkStoploss";
            this.chkStoploss.Size = new System.Drawing.Size(66, 17);
            this.chkStoploss.TabIndex = 27;
            this.chkStoploss.Text = "Stoploss";
            this.chkStoploss.UseVisualStyleBackColor = true;
            this.chkStoploss.UseWaitCursor = true;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(232, 105);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(15, 13);
            this.label17.TabIndex = 26;
            this.label17.Text = "%";
            this.label17.UseWaitCursor = true;
            // 
            // nuStoploss
            // 
            this.nuStoploss.DecimalPlaces = 2;
            this.nuStoploss.Location = new System.Drawing.Point(157, 109);
            this.nuStoploss.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nuStoploss.Name = "nuStoploss";
            this.nuStoploss.Size = new System.Drawing.Size(68, 20);
            this.nuStoploss.TabIndex = 25;
            this.nuStoploss.UseWaitCursor = true;
            this.nuStoploss.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            // 
            // chkDiversification
            // 
            this.chkDiversification.AutoSize = true;
            this.chkDiversification.Location = new System.Drawing.Point(5, 136);
            this.chkDiversification.Name = "chkDiversification";
            this.chkDiversification.Size = new System.Drawing.Size(92, 17);
            this.chkDiversification.TabIndex = 24;
            this.chkDiversification.Text = "Diversification";
            this.chkDiversification.UseVisualStyleBackColor = true;
            this.chkDiversification.UseWaitCursor = true;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(233, 127);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(15, 13);
            this.label13.TabIndex = 23;
            this.label13.Text = "%";
            this.label13.UseWaitCursor = true;
            // 
            // nuDiversification
            // 
            this.nuDiversification.DecimalPlaces = 2;
            this.nuDiversification.Location = new System.Drawing.Point(157, 136);
            this.nuDiversification.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nuDiversification.Name = "nuDiversification";
            this.nuDiversification.Size = new System.Drawing.Size(68, 20);
            this.nuDiversification.TabIndex = 22;
            this.nuDiversification.UseWaitCursor = true;
            this.nuDiversification.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // lblAutoUnrealizedROEPercent
            // 
            this.lblAutoUnrealizedROEPercent.AutoSize = true;
            this.lblAutoUnrealizedROEPercent.Location = new System.Drawing.Point(197, 91);
            this.lblAutoUnrealizedROEPercent.Name = "lblAutoUnrealizedROEPercent";
            this.lblAutoUnrealizedROEPercent.Size = new System.Drawing.Size(0, 13);
            this.lblAutoUnrealizedROEPercent.TabIndex = 21;
            this.lblAutoUnrealizedROEPercent.UseWaitCursor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(232, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 13);
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
            this.nudAutoMarketTakeProfitPercent.Location = new System.Drawing.Point(157, 85);
            this.nudAutoMarketTakeProfitPercent.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.nudAutoMarketTakeProfitPercent.Name = "nudAutoMarketTakeProfitPercent";
            this.nudAutoMarketTakeProfitPercent.Size = new System.Drawing.Size(68, 20);
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
            this.chkAutoMarketTakeProfits.Location = new System.Drawing.Point(5, 84);
            this.chkAutoMarketTakeProfits.Name = "chkAutoMarketTakeProfits";
            this.chkAutoMarketTakeProfits.Size = new System.Drawing.Size(126, 17);
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
            this.ddlAutoOrderType.Location = new System.Drawing.Point(236, 21);
            this.ddlAutoOrderType.Name = "ddlAutoOrderType";
            this.ddlAutoOrderType.Size = new System.Drawing.Size(98, 21);
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
            this.nudAutoQuantity.Location = new System.Drawing.Point(266, 53);
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
            this.nudAutoQuantity.Size = new System.Drawing.Size(67, 20);
            this.nudAutoQuantity.TabIndex = 15;
            this.nudAutoQuantity.UseWaitCursor = true;
            this.nudAutoQuantity.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // btnAutomatedTrading
            // 
            this.btnAutomatedTrading.BackColor = System.Drawing.Color.LightGreen;
            this.btnAutomatedTrading.Depth = 0;
            this.btnAutomatedTrading.Font = new System.Drawing.Font("Book Antiqua", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAutomatedTrading.Location = new System.Drawing.Point(7, 21);
            this.btnAutomatedTrading.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnAutomatedTrading.Name = "btnAutomatedTrading";
            this.btnAutomatedTrading.Primary = true;
            this.btnAutomatedTrading.Size = new System.Drawing.Size(145, 50);
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
            this.statusStrip1.Location = new System.Drawing.Point(0, 418);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(987, 22);
            this.statusStrip1.TabIndex = 15;
            this.statusStrip1.Text = "statusStrip1";
            this.statusStrip1.UseWaitCursor = true;
            // 
            // stsAPIValid
            // 
            this.stsAPIValid.Name = "stsAPIValid";
            this.stsAPIValid.Size = new System.Drawing.Size(108, 17);
            this.stsAPIValid.Text = "API keys are invalid";
            // 
            // stsAccountBalance
            // 
            this.stsAccountBalance.Name = "stsAccountBalance";
            this.stsAccountBalance.Size = new System.Drawing.Size(60, 17);
            this.stsAccountBalance.Text = "Balance: 0";
            // 
            // stsOTProgress
            // 
            this.stsOTProgress.Name = "stsOTProgress";
            this.stsOTProgress.Size = new System.Drawing.Size(100, 16);
            this.stsOTProgress.Visible = false;
            // 
            // btnAccountBalance
            // 
            this.btnAccountBalance.Location = new System.Drawing.Point(481, 306);
            this.btnAccountBalance.Name = "btnAccountBalance";
            this.btnAccountBalance.Size = new System.Drawing.Size(97, 23);
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
            this.nudStopPercent.Location = new System.Drawing.Point(127, 191);
            this.nudStopPercent.Name = "nudStopPercent";
            this.nudStopPercent.Size = new System.Drawing.Size(60, 20);
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
            this.btnManualSetStop.Location = new System.Drawing.Point(197, 191);
            this.btnManualSetStop.Name = "btnManualSetStop";
            this.btnManualSetStop.Size = new System.Drawing.Size(75, 23);
            this.btnManualSetStop.TabIndex = 18;
            this.btnManualSetStop.Text = "Set Stop";
            this.btnManualSetStop.UseVisualStyleBackColor = true;
            this.btnManualSetStop.UseWaitCursor = true;
            this.btnManualSetStop.Click += new System.EventHandler(this.btnManualSetStop_Click);
            // 
            // txtAPIKey
            // 
            this.txtAPIKey.Location = new System.Drawing.Point(481, 247);
            this.txtAPIKey.Name = "txtAPIKey";
            this.txtAPIKey.Size = new System.Drawing.Size(97, 20);
            this.txtAPIKey.TabIndex = 19;
            this.txtAPIKey.UseSystemPasswordChar = true;
            this.txtAPIKey.UseWaitCursor = true;
            this.txtAPIKey.TextChanged += new System.EventHandler(this.txtAPIKey_TextChanged);
            // 
            // txtAPISecret
            // 
            this.txtAPISecret.Location = new System.Drawing.Point(481, 277);
            this.txtAPISecret.Name = "txtAPISecret";
            this.txtAPISecret.Size = new System.Drawing.Size(97, 20);
            this.txtAPISecret.TabIndex = 20;
            this.txtAPISecret.UseSystemPasswordChar = true;
            this.txtAPISecret.UseWaitCursor = true;
            this.txtAPISecret.TextChanged += new System.EventHandler(this.txtAPISecret_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(451, 254);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 13);
            this.label2.TabIndex = 22;
            this.label2.Text = "Key";
            this.label2.UseWaitCursor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(437, 282);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 23;
            this.label3.Text = "Secret";
            this.label3.UseWaitCursor = true;
            // 
            // btnBuyOverTimeOrder
            // 
            this.btnBuyOverTimeOrder.Location = new System.Drawing.Point(296, 105);
            this.btnBuyOverTimeOrder.Name = "btnBuyOverTimeOrder";
            this.btnBuyOverTimeOrder.Size = new System.Drawing.Size(75, 23);
            this.btnBuyOverTimeOrder.TabIndex = 24;
            this.btnBuyOverTimeOrder.Text = "Buy Over Time";
            this.btnBuyOverTimeOrder.UseVisualStyleBackColor = true;
            this.btnBuyOverTimeOrder.UseWaitCursor = true;
            this.btnBuyOverTimeOrder.Click += new System.EventHandler(this.btnBuyOverTimeOrder_Click);
            // 
            // btnSellOverTimeOrder
            // 
            this.btnSellOverTimeOrder.Location = new System.Drawing.Point(389, 105);
            this.btnSellOverTimeOrder.Name = "btnSellOverTimeOrder";
            this.btnSellOverTimeOrder.Size = new System.Drawing.Size(75, 23);
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
            this.nudOverTimeContracts.Location = new System.Drawing.Point(297, 163);
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
            this.nudOverTimeContracts.Size = new System.Drawing.Size(75, 20);
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
            this.nudOverTimeInterval.Location = new System.Drawing.Point(381, 163);
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
            this.nudOverTimeInterval.Size = new System.Drawing.Size(75, 20);
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
            this.nudOverTimeIntervalCount.Location = new System.Drawing.Point(444, 163);
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
            this.nudOverTimeIntervalCount.Size = new System.Drawing.Size(75, 20);
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
            this.label4.Location = new System.Drawing.Point(294, 147);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 13);
            this.label4.TabIndex = 22;
            this.label4.Text = "Contracts Per";
            this.label4.UseWaitCursor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(379, 147);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 29;
            this.label5.Text = "Seconds";
            this.label5.UseWaitCursor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(446, 147);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 13);
            this.label6.TabIndex = 30;
            this.label6.Text = "X Times";
            this.label6.UseWaitCursor = true;
            // 
            // lblOverTimeSummary
            // 
            this.lblOverTimeSummary.AutoSize = true;
            this.lblOverTimeSummary.Location = new System.Drawing.Point(299, 199);
            this.lblOverTimeSummary.Name = "lblOverTimeSummary";
            this.lblOverTimeSummary.Size = new System.Drawing.Size(102, 13);
            this.lblOverTimeSummary.TabIndex = 22;
            this.lblOverTimeSummary.Text = "Over Time Summary";
            this.lblOverTimeSummary.UseWaitCursor = true;
            // 
            // btnOverTimeStop
            // 
            this.btnOverTimeStop.Location = new System.Drawing.Point(484, 104);
            this.btnOverTimeStop.Name = "btnOverTimeStop";
            this.btnOverTimeStop.Size = new System.Drawing.Size(75, 23);
            this.btnOverTimeStop.TabIndex = 31;
            this.btnOverTimeStop.Text = "Stop";
            this.btnOverTimeStop.UseVisualStyleBackColor = true;
            this.btnOverTimeStop.UseWaitCursor = true;
            this.btnOverTimeStop.Click += new System.EventHandler(this.btnOverTimeStop_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.chkMA);
            this.groupBox2.Controls.Add(this.lblMA2);
            this.groupBox2.Controls.Add(this.nudMA2);
            this.groupBox2.Controls.Add(this.lblMA1);
            this.groupBox2.Controls.Add(this.nudMA1);
            this.groupBox2.Location = new System.Drawing.Point(588, 270);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(177, 62);
            this.groupBox2.TabIndex = 34;
            this.groupBox2.TabStop = false;
            // 
            // chkMA
            // 
            this.chkMA.AutoSize = true;
            this.chkMA.Location = new System.Drawing.Point(5, 0);
            this.chkMA.Margin = new System.Windows.Forms.Padding(2);
            this.chkMA.Name = "chkMA";
            this.chkMA.Size = new System.Drawing.Size(42, 17);
            this.chkMA.TabIndex = 23;
            this.chkMA.Text = "MA";
            this.chkMA.UseVisualStyleBackColor = true;
            // 
            // lblMA2
            // 
            this.lblMA2.AutoSize = true;
            this.lblMA2.Location = new System.Drawing.Point(135, 25);
            this.lblMA2.Name = "lblMA2";
            this.lblMA2.Size = new System.Drawing.Size(29, 13);
            this.lblMA2.TabIndex = 20;
            this.lblMA2.Text = "MA2";
            // 
            // nudMA2
            // 
            this.nudMA2.Location = new System.Drawing.Point(89, 22);
            this.nudMA2.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudMA2.Name = "nudMA2";
            this.nudMA2.Size = new System.Drawing.Size(42, 20);
            this.nudMA2.TabIndex = 19;
            this.nudMA2.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // lblMA1
            // 
            this.lblMA1.AutoSize = true;
            this.lblMA1.Location = new System.Drawing.Point(53, 24);
            this.lblMA1.Name = "lblMA1";
            this.lblMA1.Size = new System.Drawing.Size(29, 13);
            this.lblMA1.TabIndex = 18;
            this.lblMA1.Text = "MA1";
            // 
            // nudMA1
            // 
            this.nudMA1.Location = new System.Drawing.Point(5, 22);
            this.nudMA1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudMA1.Name = "nudMA1";
            this.nudMA1.Size = new System.Drawing.Size(42, 20);
            this.nudMA1.TabIndex = 17;
            this.nudMA1.Value = new decimal(new int[] {
            3,
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
            this.groupBox3.Location = new System.Drawing.Point(782, 270);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(182, 64);
            this.groupBox3.TabIndex = 35;
            this.groupBox3.TabStop = false;
            // 
            // cbEma
            // 
            this.cbEma.AutoSize = true;
            this.cbEma.Location = new System.Drawing.Point(11, 1);
            this.cbEma.Margin = new System.Windows.Forms.Padding(2);
            this.cbEma.Name = "cbEma";
            this.cbEma.Size = new System.Drawing.Size(49, 17);
            this.cbEma.TabIndex = 22;
            this.cbEma.Text = "EMA";
            this.cbEma.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(90, 42);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(36, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "EMA2";
            // 
            // nuEMA2
            // 
            this.nuEMA2.Location = new System.Drawing.Point(91, 18);
            this.nuEMA2.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nuEMA2.Name = "nuEMA2";
            this.nuEMA2.Size = new System.Drawing.Size(42, 20);
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
            this.label11.Location = new System.Drawing.Point(9, 42);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(36, 13);
            this.label11.TabIndex = 14;
            this.label11.Text = "EMA1";
            // 
            // nuEMA1
            // 
            this.nuEMA1.Location = new System.Drawing.Point(11, 19);
            this.nuEMA1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nuEMA1.Name = "nuEMA1";
            this.nuEMA1.Size = new System.Drawing.Size(42, 20);
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
            this.groupBox4.Controls.Add(this.nuRsiSell);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Controls.Add(this.nuRsiBuy);
            this.groupBox4.Location = new System.Drawing.Point(588, 338);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(177, 77);
            this.groupBox4.TabIndex = 36;
            this.groupBox4.TabStop = false;
            // 
            // cbRSI
            // 
            this.cbRSI.AutoSize = true;
            this.cbRSI.Location = new System.Drawing.Point(5, 0);
            this.cbRSI.Margin = new System.Windows.Forms.Padding(2);
            this.cbRSI.Name = "cbRSI";
            this.cbRSI.Size = new System.Drawing.Size(44, 17);
            this.cbRSI.TabIndex = 23;
            this.cbRSI.Text = "RSI";
            this.cbRSI.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(83, 48);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(53, 13);
            this.label10.TabIndex = 22;
            this.label10.Text = "Sell Level";
            // 
            // nuRsiSell
            // 
            this.nuRsiSell.Location = new System.Drawing.Point(87, 19);
            this.nuRsiSell.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nuRsiSell.Name = "nuRsiSell";
            this.nuRsiSell.Size = new System.Drawing.Size(42, 20);
            this.nuRsiSell.TabIndex = 21;
            this.nuRsiSell.Value = new decimal(new int[] {
            70,
            0,
            0,
            0});
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(5, 48);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 13);
            this.label7.TabIndex = 20;
            this.label7.Text = "Buy Level";
            // 
            // nuRsiBuy
            // 
            this.nuRsiBuy.Location = new System.Drawing.Point(5, 21);
            this.nuRsiBuy.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nuRsiBuy.Name = "nuRsiBuy";
            this.nuRsiBuy.Size = new System.Drawing.Size(42, 20);
            this.nuRsiBuy.TabIndex = 19;
            this.nuRsiBuy.Value = new decimal(new int[] {
            30,
            0,
            0,
            0});
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.cbStochastic);
            this.groupBox5.Controls.Add(this.label9);
            this.groupBox5.Controls.Add(this.nuStochSell);
            this.groupBox5.Controls.Add(this.label12);
            this.groupBox5.Controls.Add(this.nuStochBuy);
            this.groupBox5.Location = new System.Drawing.Point(782, 338);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(182, 77);
            this.groupBox5.TabIndex = 37;
            this.groupBox5.TabStop = false;
            // 
            // cbStochastic
            // 
            this.cbStochastic.AutoSize = true;
            this.cbStochastic.Location = new System.Drawing.Point(9, 1);
            this.cbStochastic.Margin = new System.Windows.Forms.Padding(2);
            this.cbStochastic.Name = "cbStochastic";
            this.cbStochastic.Size = new System.Drawing.Size(76, 17);
            this.cbStochastic.TabIndex = 27;
            this.cbStochastic.Text = "Stochastic";
            this.cbStochastic.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(90, 51);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 13);
            this.label9.TabIndex = 26;
            this.label9.Text = "Sell Level";
            // 
            // nuStochSell
            // 
            this.nuStochSell.Location = new System.Drawing.Point(91, 23);
            this.nuStochSell.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nuStochSell.Name = "nuStochSell";
            this.nuStochSell.Size = new System.Drawing.Size(42, 20);
            this.nuStochSell.TabIndex = 25;
            this.nuStochSell.Value = new decimal(new int[] {
            80,
            0,
            0,
            0});
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(9, 52);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(54, 13);
            this.label12.TabIndex = 24;
            this.label12.Text = "Buy Level";
            // 
            // nuStochBuy
            // 
            this.nuStochBuy.Location = new System.Drawing.Point(9, 22);
            this.nuStochBuy.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nuStochBuy.Name = "nuStochBuy";
            this.nuStochBuy.Size = new System.Drawing.Size(42, 20);
            this.nuStochBuy.TabIndex = 23;
            this.nuStochBuy.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.ddlPumpDumpTime);
            this.groupBox6.Controls.Add(this.label15);
            this.groupBox6.Controls.Add(this.nuPumpPercentage);
            this.groupBox6.Controls.Add(this.label14);
            this.groupBox6.Controls.Add(this.chkPumpdump);
            this.groupBox6.Location = new System.Drawing.Point(215, 329);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(211, 62);
            this.groupBox6.TabIndex = 38;
            this.groupBox6.TabStop = false;
            // 
            // ddlPumpDumpTime
            // 
            this.ddlPumpDumpTime.FormattingEnabled = true;
            this.ddlPumpDumpTime.Items.AddRange(new object[] {
            "1",
            "4"});
            this.ddlPumpDumpTime.Location = new System.Drawing.Point(12, 29);
            this.ddlPumpDumpTime.Name = "ddlPumpDumpTime";
            this.ddlPumpDumpTime.Size = new System.Drawing.Size(67, 21);
            this.ddlPumpDumpTime.TabIndex = 32;
            this.ddlPumpDumpTime.UseWaitCursor = true;
            this.ddlPumpDumpTime.SelectedIndex = 0;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(182, 28);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(15, 13);
            this.label15.TabIndex = 31;
            this.label15.Text = "%";
            // 
            // nuPumpPercentage
            // 
            this.nuPumpPercentage.DecimalPlaces = 2;
            this.nuPumpPercentage.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.nuPumpPercentage.Location = new System.Drawing.Point(117, 27);
            this.nuPumpPercentage.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.nuPumpPercentage.Name = "nuPumpPercentage";
            this.nuPumpPercentage.Size = new System.Drawing.Size(60, 20);
            this.nuPumpPercentage.TabIndex = 30;
            this.nuPumpPercentage.UseWaitCursor = true;
            this.nuPumpPercentage.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(83, 29);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(30, 13);
            this.label14.TabIndex = 29;
            this.label14.Text = "Hour";
            // 
            // chkPumpdump
            // 
            this.chkPumpdump.AutoSize = true;
            this.chkPumpdump.Location = new System.Drawing.Point(12, 3);
            this.chkPumpdump.Margin = new System.Windows.Forms.Padding(2);
            this.chkPumpdump.Name = "chkPumpdump";
            this.chkPumpdump.Size = new System.Drawing.Size(153, 17);
            this.chkPumpdump.TabIndex = 27;
            this.chkPumpdump.Text = "Pump and dump protection";
            this.chkPumpdump.UseVisualStyleBackColor = true;
            // 
            // lblBuildVersion
            // 
            this.lblBuildVersion.AutoSize = true;
            this.lblBuildVersion.Location = new System.Drawing.Point(926, 554);
            this.lblBuildVersion.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblBuildVersion.Name = "lblBuildVersion";
            this.lblBuildVersion.Size = new System.Drawing.Size(0, 13);
            this.lblBuildVersion.TabIndex = 40;
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.lblLeverageResult);
            this.groupBox7.Controls.Add(this.btnLeverage);
            this.groupBox7.Controls.Add(this.label16);
            this.groupBox7.Controls.Add(this.nuLeverageLevel);
            this.groupBox7.Location = new System.Drawing.Point(13, 247);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(187, 144);
            this.groupBox7.TabIndex = 41;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Leverage";
            // 
            // lblLeverageResult
            // 
            this.lblLeverageResult.AutoSize = true;
            this.lblLeverageResult.Location = new System.Drawing.Point(5, 122);
            this.lblLeverageResult.Name = "lblLeverageResult";
            this.lblLeverageResult.Size = new System.Drawing.Size(0, 13);
            this.lblLeverageResult.TabIndex = 33;
            // 
            // btnLeverage
            // 
            this.btnLeverage.Location = new System.Drawing.Point(99, 17);
            this.btnLeverage.Name = "btnLeverage";
            this.btnLeverage.Size = new System.Drawing.Size(75, 23);
            this.btnLeverage.TabIndex = 32;
            this.btnLeverage.Text = "Ok";
            this.btnLeverage.UseVisualStyleBackColor = true;
            this.btnLeverage.UseWaitCursor = true;
            this.btnLeverage.Click += new System.EventHandler(this.btnLeverage_Click);
            // 
            // label16
            // 
            this.label16.Location = new System.Drawing.Point(5, 43);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(176, 71);
            this.label16.TabIndex = 25;
            this.label16.Text = "Leverage value. Send a number between 1 and 100 to enable isolated margin with a " +
    "fixed leverage. Send 0 to enable cross margin.";
            this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // nuLeverageLevel
            // 
            this.nuLeverageLevel.Location = new System.Drawing.Point(8, 20);
            this.nuLeverageLevel.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nuLeverageLevel.Name = "nuLeverageLevel";
            this.nuLeverageLevel.Size = new System.Drawing.Size(76, 20);
            this.nuLeverageLevel.TabIndex = 19;
            this.nuLeverageLevel.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(987, 440);
            this.Controls.Add(this.groupBox7);
            this.Controls.Add(this.lblBuildVersion);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
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
            this.Name = "Form1";
            this.Sizable = false;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudQty)).EndInit();
            this.gbCandles.ResumeLayout(false);
            this.gbCandles.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nuStoploss)).EndInit();
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
            ((System.ComponentModel.ISupportInitialize)(this.nuRsiSell)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nuRsiBuy)).EndInit();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nuStochSell)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nuStochBuy)).EndInit();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nuPumpPercentage)).EndInit();
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nuLeverageLevel)).EndInit();
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
        private System.Windows.Forms.RadioButton rdoSwitch;
        private System.Windows.Forms.GroupBox groupBox1;
        private MaterialSkin.Controls.MaterialRaisedButton btnAutomatedTrading;
        private System.Windows.Forms.ComboBox ddlAutoOrderType;
        private System.Windows.Forms.NumericUpDown nudAutoQuantity;
        private System.Windows.Forms.Timer tmrAutoTradeExecution;
        private System.Windows.Forms.StatusStrip statusStrip1;
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
        private System.Windows.Forms.NumericUpDown nuRsiSell;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown nuRsiBuy;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.CheckBox cbStochastic;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.NumericUpDown nuStochSell;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.NumericUpDown nuStochBuy;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.NumericUpDown nuDiversification;
        private System.Windows.Forms.CheckBox chkDiversification;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.NumericUpDown nuPumpPercentage;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.CheckBox chkPumpdump;
        private System.Windows.Forms.ComboBox ddlPumpDumpTime;
        private System.Windows.Forms.ToolStripStatusLabel stsAPIValid;
        private System.Windows.Forms.Label lblBuildVersion;
        private System.Windows.Forms.CheckBox chkMA;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.Button btnLeverage;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.NumericUpDown nuLeverageLevel;
        private System.Windows.Forms.CheckBox chkStoploss;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.NumericUpDown nuStoploss;
        private System.Windows.Forms.Label lblLeverageResult;
    }
}

