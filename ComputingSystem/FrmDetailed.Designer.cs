namespace ComputingSystem
{
    partial class FrmDetailed 
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tbCPU = new System.Windows.Forms.TextBox();
            this.tbDevice = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.nudIntensity = new System.Windows.Forms.NumericUpDown();
            this.nudBurstMax = new System.Windows.Forms.NumericUpDown();
            this.cbRamSize = new System.Windows.Forms.ComboBox();
            this.nudAddrSpaceMin = new System.Windows.Forms.NumericUpDown();
            this.nudAddrSpaceMax = new System.Windows.Forms.NumericUpDown();
            this.lbCPUQueue = new System.Windows.Forms.ListBox();
            this.lbDeviceQueue = new System.Windows.Forms.ListBox();
            this.pnlSettings = new System.Windows.Forms.Panel();
            this.autoMode = new System.Windows.Forms.RadioButton();
            this.rbManual = new System.Windows.Forms.RadioButton();
            this.btnSessionEnd = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.btnWork = new System.Windows.Forms.Button();
            this.lblTime = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.nudBurstMin = new System.Windows.Forms.NumericUpDown();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.lblFreeMemValue = new System.Windows.Forms.Label();
            this.lblOccupiedMemValue = new System.Windows.Forms.Label();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.nudIntensity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudBurstMax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAddrSpaceMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAddrSpaceMax)).BeginInit();
            this.pnlSettings.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudBurstMin)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbCPU
            // 
            this.tbCPU.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbCPU.Location = new System.Drawing.Point(3, 27);
            this.tbCPU.Name = "tbCPU";
            this.tbCPU.ReadOnly = true;
            this.tbCPU.Size = new System.Drawing.Size(391, 23);
            this.tbCPU.TabIndex = 2;
            // 
            // tbDevice
            // 
            this.tbDevice.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbDevice.Location = new System.Drawing.Point(400, 27);
            this.tbDevice.Name = "tbDevice";
            this.tbDevice.ReadOnly = true;
            this.tbDevice.Size = new System.Drawing.Size(391, 23);
            this.tbDevice.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 46);
            this.label1.TabIndex = 20;
            this.label1.Text = "Интенсивность поступления процессов";
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Location = new System.Drawing.Point(137, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 63);
            this.label2.TabIndex = 21;
            this.label2.Text = "Минимальное значение промежутка работы на ЦП";
            // 
            // label3
            // 
            this.label3.Dock = System.Windows.Forms.DockStyle.Top;
            this.label3.Location = new System.Drawing.Point(271, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 63);
            this.label3.TabIndex = 22;
            this.label3.Text = "Максимальное значение промежутка работы на ЦП";
            // 
            // label4
            // 
            this.label4.Dock = System.Windows.Forms.DockStyle.Top;
            this.label4.Location = new System.Drawing.Point(405, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(128, 46);
            this.label4.TabIndex = 23;
            this.label4.Text = "Размер оперативной памяти";
            // 
            // label5
            // 
            this.label5.Dock = System.Windows.Forms.DockStyle.Top;
            this.label5.Location = new System.Drawing.Point(539, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(121, 62);
            this.label5.TabIndex = 24;
            this.label5.Text = "Минимальный размер адресного пространства процесса ";
            // 
            // label6
            // 
            this.label6.Dock = System.Windows.Forms.DockStyle.Top;
            this.label6.Location = new System.Drawing.Point(666, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(125, 62);
            this.label6.TabIndex = 25;
            this.label6.Text = "Максимальный размер адресного пространства процесса ";
            // 
            // label7
            // 
            this.label7.Dock = System.Windows.Forms.DockStyle.Top;
            this.label7.Location = new System.Drawing.Point(3, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(391, 15);
            this.label7.TabIndex = 26;
            this.label7.Text = "Центральный процессор";
            // 
            // label8
            // 
            this.label8.Dock = System.Windows.Forms.DockStyle.Top;
            this.label8.Location = new System.Drawing.Point(400, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(391, 15);
            this.label8.TabIndex = 27;
            this.label8.Text = "Внешнее устройство";
            // 
            // label9
            // 
            this.label9.Dock = System.Windows.Forms.DockStyle.Top;
            this.label9.Location = new System.Drawing.Point(3, 62);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(391, 16);
            this.label9.TabIndex = 28;
            this.label9.Text = "Очередь к центральному процессору";
            // 
            // label10
            // 
            this.label10.Dock = System.Windows.Forms.DockStyle.Top;
            this.label10.Location = new System.Drawing.Point(400, 62);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(391, 16);
            this.label10.TabIndex = 29;
            this.label10.Text = "Очередь к внешнему устройству";
            // 
            // label11
            // 
            this.label11.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label11.Location = new System.Drawing.Point(3, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(192, 15);
            this.label11.TabIndex = 30;
            this.label11.Text = "Оперативная память";
            // 
            // label12
            // 
            this.label12.Dock = System.Windows.Forms.DockStyle.Top;
            this.label12.Location = new System.Drawing.Point(3, 15);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(192, 13);
            this.label12.TabIndex = 31;
            this.label12.Text = "Размер свободной памяти:";
            // 
            // label13
            // 
            this.label13.Dock = System.Windows.Forms.DockStyle.Top;
            this.label13.Location = new System.Drawing.Point(399, 15);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(192, 36);
            this.label13.TabIndex = 32;
            this.label13.Text = "Размер памяти, занятой процессами:";
            // 
            // nudIntensity
            // 
            this.nudIntensity.DecimalPlaces = 1;
            this.nudIntensity.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nudIntensity.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.nudIntensity.Location = new System.Drawing.Point(3, 71);
            this.nudIntensity.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudIntensity.Name = "nudIntensity";
            this.nudIntensity.Size = new System.Drawing.Size(128, 23);
            this.nudIntensity.TabIndex = 21;
            this.nudIntensity.Value = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            // 
            // nudBurstMax
            // 
            this.nudBurstMax.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nudBurstMax.Location = new System.Drawing.Point(271, 71);
            this.nudBurstMax.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudBurstMax.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.nudBurstMax.Name = "nudBurstMax";
            this.nudBurstMax.Size = new System.Drawing.Size(128, 23);
            this.nudBurstMax.TabIndex = 23;
            this.nudBurstMax.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
            // 
            // cbRamSize
            // 
            this.cbRamSize.AutoCompleteCustomSource.AddRange(new string[] {
            "32000",
            "64000"});
            this.cbRamSize.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbRamSize.FormattingEnabled = true;
            this.cbRamSize.Items.AddRange(new object[] {
            "32000",
            "64000"});
            this.cbRamSize.Location = new System.Drawing.Point(405, 71);
            this.cbRamSize.Name = "cbRamSize";
            this.cbRamSize.Size = new System.Drawing.Size(128, 23);
            this.cbRamSize.TabIndex = 24;
            // 
            // nudAddrSpaceMin
            // 
            this.nudAddrSpaceMin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nudAddrSpaceMin.Location = new System.Drawing.Point(539, 71);
            this.nudAddrSpaceMin.Name = "nudAddrSpaceMin";
            this.nudAddrSpaceMin.Size = new System.Drawing.Size(121, 23);
            this.nudAddrSpaceMin.TabIndex = 24;
            this.nudAddrSpaceMin.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // nudAddrSpaceMax
            // 
            this.nudAddrSpaceMax.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nudAddrSpaceMax.Location = new System.Drawing.Point(666, 71);
            this.nudAddrSpaceMax.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.nudAddrSpaceMax.Name = "nudAddrSpaceMax";
            this.nudAddrSpaceMax.Size = new System.Drawing.Size(125, 23);
            this.nudAddrSpaceMax.TabIndex = 25;
            this.nudAddrSpaceMax.Value = new decimal(new int[] {
            250,
            0,
            0,
            0});
            // 
            // lbCPUQueue
            // 
            this.lbCPUQueue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbCPUQueue.FormattingEnabled = true;
            this.lbCPUQueue.ItemHeight = 15;
            this.lbCPUQueue.Location = new System.Drawing.Point(3, 88);
            this.lbCPUQueue.Name = "lbCPUQueue";
            this.lbCPUQueue.Size = new System.Drawing.Size(391, 160);
            this.lbCPUQueue.TabIndex = 30;
            // 
            // lbDeviceQueue
            // 
            this.lbDeviceQueue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbDeviceQueue.FormattingEnabled = true;
            this.lbDeviceQueue.ItemHeight = 15;
            this.lbDeviceQueue.Location = new System.Drawing.Point(400, 88);
            this.lbDeviceQueue.Name = "lbDeviceQueue";
            this.lbDeviceQueue.Size = new System.Drawing.Size(391, 160);
            this.lbDeviceQueue.TabIndex = 31;
            // 
            // pnlSettings
            // 
            this.pnlSettings.AutoSize = true;
            this.pnlSettings.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlSettings.Controls.Add(this.autoMode);
            this.pnlSettings.Controls.Add(this.rbManual);
            this.pnlSettings.Controls.Add(this.btnSessionEnd);
            this.pnlSettings.Controls.Add(this.label14);
            this.pnlSettings.Controls.Add(this.btnWork);
            this.pnlSettings.Controls.Add(this.lblTime);
            this.pnlSettings.Controls.Add(this.btnStart);
            this.pnlSettings.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlSettings.Location = new System.Drawing.Point(0, 400);
            this.pnlSettings.Name = "pnlSettings";
            this.pnlSettings.Size = new System.Drawing.Size(794, 64);
            this.pnlSettings.TabIndex = 33;
            // 
            // autoMode
            // 
            this.autoMode.AutoSize = true;
            this.autoMode.Location = new System.Drawing.Point(166, 37);
            this.autoMode.Name = "autoMode";
            this.autoMode.Size = new System.Drawing.Size(117, 19);
            this.autoMode.TabIndex = 16;
            this.autoMode.Text = "Автоматический";
            this.autoMode.UseVisualStyleBackColor = true;
            // 
            // rbManual
            // 
            this.rbManual.AutoSize = true;
            this.rbManual.Checked = true;
            this.rbManual.Location = new System.Drawing.Point(94, 38);
            this.rbManual.Name = "rbManual";
            this.rbManual.Size = new System.Drawing.Size(66, 19);
            this.rbManual.TabIndex = 15;
            this.rbManual.TabStop = true;
            this.rbManual.Text = "Ручной";
            this.rbManual.UseVisualStyleBackColor = true;
            // 
            // btnSessionEnd
            // 
            this.btnSessionEnd.Location = new System.Drawing.Point(651, 15);
            this.btnSessionEnd.Name = "btnSessionEnd";
            this.btnSessionEnd.Size = new System.Drawing.Size(129, 42);
            this.btnSessionEnd.TabIndex = 13;
            this.btnSessionEnd.Text = "Завершение сеанса";
            this.btnSessionEnd.UseVisualStyleBackColor = true;
            this.btnSessionEnd.Click += new System.EventHandler(this.btnSessionEnd_Click);
            // 
            // label14
            // 
            this.label14.Location = new System.Drawing.Point(94, 14);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(91, 19);
            this.label14.TabIndex = 33;
            this.label14.Text = "Режим работы";
            // 
            // btnWork
            // 
            this.btnWork.Location = new System.Drawing.Point(515, 15);
            this.btnWork.Name = "btnWork";
            this.btnWork.Size = new System.Drawing.Size(130, 42);
            this.btnWork.TabIndex = 12;
            this.btnWork.Text = "Рабочий такт";
            this.btnWork.UseVisualStyleBackColor = true;
            this.btnWork.Click += new System.EventHandler(this.btnWork_Click);
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Location = new System.Drawing.Point(34, 28);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(13, 15);
            this.lblTime.TabIndex = 34;
            this.lblTime.Text = "0";
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(364, 15);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(145, 41);
            this.btnStart.TabIndex = 11;
            this.btnStart.Text = "Сохранение настроек";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 6;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 17F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 17F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 17F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 17F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16F));
            this.tableLayoutPanel1.Controls.Add(this.nudAddrSpaceMax, 5, 1);
            this.tableLayoutPanel1.Controls.Add(this.nudAddrSpaceMin, 4, 1);
            this.tableLayoutPanel1.Controls.Add(this.label6, 5, 0);
            this.tableLayoutPanel1.Controls.Add(this.label5, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.cbRamSize, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.nudBurstMax, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.label4, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.label3, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.nudIntensity, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.nudBurstMin, 1, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 71.76471F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 28.23529F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(794, 95);
            this.tableLayoutPanel1.TabIndex = 46;
            // 
            // nudBurstMin
            // 
            this.nudBurstMin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nudBurstMin.Location = new System.Drawing.Point(137, 71);
            this.nudBurstMin.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudBurstMin.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudBurstMin.Name = "nudBurstMin";
            this.nudBurstMin.Size = new System.Drawing.Size(128, 23);
            this.nudBurstMin.TabIndex = 24;
            this.nudBurstMin.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 4;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.Controls.Add(this.label12, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.label11, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.label13, 2, 1);
            this.tableLayoutPanel2.Controls.Add(this.lblFreeMemValue, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.lblOccupiedMemValue, 3, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 349);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 29.41176F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 70.58823F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(794, 51);
            this.tableLayoutPanel2.TabIndex = 47;
            // 
            // lblFreeMemValue
            // 
            this.lblFreeMemValue.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblFreeMemValue.AutoSize = true;
            this.lblFreeMemValue.Location = new System.Drawing.Point(290, 25);
            this.lblFreeMemValue.Name = "lblFreeMemValue";
            this.lblFreeMemValue.Size = new System.Drawing.Size(13, 15);
            this.lblFreeMemValue.TabIndex = 33;
            this.lblFreeMemValue.Text = "0";
            // 
            // lblOccupiedMemValue
            // 
            this.lblOccupiedMemValue.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblOccupiedMemValue.AutoSize = true;
            this.lblOccupiedMemValue.Location = new System.Drawing.Point(687, 25);
            this.lblOccupiedMemValue.Name = "lblOccupiedMemValue";
            this.lblOccupiedMemValue.Size = new System.Drawing.Size(13, 15);
            this.lblOccupiedMemValue.TabIndex = 34;
            this.lblOccupiedMemValue.Text = "0";
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.lbDeviceQueue, 1, 3);
            this.tableLayoutPanel3.Controls.Add(this.lbCPUQueue, 0, 3);
            this.tableLayoutPanel3.Controls.Add(this.tbDevice, 1, 1);
            this.tableLayoutPanel3.Controls.Add(this.label9, 0, 2);
            this.tableLayoutPanel3.Controls.Add(this.label8, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.tbCPU, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.label7, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.label10, 1, 2);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(0, 95);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 4;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.82906F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15.38461F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.40171F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 65.38461F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(794, 251);
            this.tableLayoutPanel3.TabIndex = 48;
            // 
            // FrmDetailed
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(794, 464);
            this.Controls.Add(this.tableLayoutPanel3);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.pnlSettings);
            this.Name = "FrmDetailed";
            this.Text = "Системное программное обеспечение: курсовая работа";
            ((System.ComponentModel.ISupportInitialize)(this.nudIntensity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudBurstMax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAddrSpaceMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAddrSpaceMax)).EndInit();
            this.pnlSettings.ResumeLayout(false);
            this.pnlSettings.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nudBurstMin)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox tbCPU;
        private System.Windows.Forms.TextBox tbDevice;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox cbRamSize;
        private System.Windows.Forms.ListBox lbCPUQueue;
        private System.Windows.Forms.ListBox lbDeviceQueue;
        private System.Windows.Forms.NumericUpDown nudIntensity;
        
        private System.Windows.Forms.NumericUpDown nudAddrSpaceMax;
        private System.Windows.Forms.NumericUpDown nudAddrSpaceMin;
        private System.Windows.Forms.NumericUpDown nudBurstMax;
        private System.Windows.Forms.Panel pnlSettings;
        private System.Windows.Forms.RadioButton autoMode;
        private System.Windows.Forms.RadioButton rbManual;
        private System.Windows.Forms.Button btnSessionEnd;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button btnWork;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.NumericUpDown nudBurstMin;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label lblFreeMemValue;
        private System.Windows.Forms.Label lblOccupiedMemValue;
    }
}

