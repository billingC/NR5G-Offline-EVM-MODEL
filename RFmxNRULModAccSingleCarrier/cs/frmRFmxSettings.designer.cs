namespace NationalInstruments.Examples.RFmxNRULModAccSingleCarrier
{
    partial class frmRFmxSettings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRFmxSettings));
            this.numCarrierBW = new System.Windows.Forms.NumericUpDown();
            this.lblCarrierBW = new System.Windows.Forms.Label();
            this.lblDuplex = new System.Windows.Forms.Label();
            this.cboDuplex = new System.Windows.Forms.ComboBox();
            this.cboUplinkType = new System.Windows.Forms.ComboBox();
            this.lblUplinkType = new System.Windows.Forms.Label();
            this.cboUplingConfig = new System.Windows.Forms.ComboBox();
            this.lblUplingConfig = new System.Windows.Forms.Label();
            this.lblSubCarrierSpacing = new System.Windows.Forms.Label();
            this.numSubCarrierSpacing = new System.Windows.Forms.NumericUpDown();
            this.cboPUSCHMod = new System.Windows.Forms.ComboBox();
            this.lblRBOffset = new System.Windows.Forms.Label();
            this.cboMeasUnit = new System.Windows.Forms.ComboBox();
            this.lblPUSCHMod = new System.Windows.Forms.Label();
            this.lblMeasUnit = new System.Windows.Forms.Label();
            this.numMeasOffset = new System.Windows.Forms.NumericUpDown();
            this.lblMeasOffset = new System.Windows.Forms.Label();
            this.numMeasLength = new System.Windows.Forms.NumericUpDown();
            this.cboEVMUnit = new System.Windows.Forms.ComboBox();
            this.lblMeasLength = new System.Windows.Forms.Label();
            this.btnLoadFile = new System.Windows.Forms.Button();
            this.dgvEVMData = new System.Windows.Forms.DataGridView();
            this.btnDemod = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnSaveData = new System.Windows.Forms.Button();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.pgbOps = new System.Windows.Forms.ProgressBar();
            this.numRBOffset = new System.Windows.Forms.NumericUpDown();
            this.lblEVMUnit = new System.Windows.Forms.Label();
            this.lblSamppleRate = new System.Windows.Forms.Label();
            this.numSampleRate = new System.Windows.Forms.NumericUpDown();
            this.chkConstellation = new System.Windows.Forms.CheckBox();
            this.numRBQty = new System.Windows.Forms.NumericUpDown();
            this.lblRBQty = new System.Windows.Forms.Label();
            this.gbxFileFormat = new System.Windows.Forms.GroupBox();
            this.optIQFiles = new System.Windows.Forms.RadioButton();
            this.optComplex = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.numCarrierBW)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSubCarrierSpacing)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMeasOffset)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMeasLength)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEVMData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numRBOffset)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSampleRate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numRBQty)).BeginInit();
            this.gbxFileFormat.SuspendLayout();
            this.SuspendLayout();
            // 
            // numCarrierBW
            // 
            this.numCarrierBW.Location = new System.Drawing.Point(143, 18);
            this.numCarrierBW.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numCarrierBW.Name = "numCarrierBW";
            this.numCarrierBW.Size = new System.Drawing.Size(106, 20);
            this.numCarrierBW.TabIndex = 0;
            this.numCarrierBW.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numCarrierBW.Value = new decimal(new int[] {
            60,
            0,
            0,
            0});
            // 
            // lblCarrierBW
            // 
            this.lblCarrierBW.AutoSize = true;
            this.lblCarrierBW.Location = new System.Drawing.Point(44, 25);
            this.lblCarrierBW.Name = "lblCarrierBW";
            this.lblCarrierBW.Size = new System.Drawing.Size(92, 13);
            this.lblCarrierBW.TabIndex = 1;
            this.lblCarrierBW.Text = "Carrier BW [MHz]:";
            // 
            // lblDuplex
            // 
            this.lblDuplex.AutoSize = true;
            this.lblDuplex.Location = new System.Drawing.Point(51, 60);
            this.lblDuplex.Name = "lblDuplex";
            this.lblDuplex.Size = new System.Drawing.Size(85, 13);
            this.lblDuplex.TabIndex = 2;
            this.lblDuplex.Text = "Duplex Scheme:";
            // 
            // cboDuplex
            // 
            this.cboDuplex.FormattingEnabled = true;
            this.cboDuplex.Items.AddRange(new object[] {
            "FDD",
            "TDD"});
            this.cboDuplex.Location = new System.Drawing.Point(143, 53);
            this.cboDuplex.Name = "cboDuplex";
            this.cboDuplex.Size = new System.Drawing.Size(106, 21);
            this.cboDuplex.TabIndex = 1;
            // 
            // cboUplinkType
            // 
            this.cboUplinkType.FormattingEnabled = true;
            this.cboUplinkType.Location = new System.Drawing.Point(143, 89);
            this.cboUplinkType.Name = "cboUplinkType";
            this.cboUplinkType.Size = new System.Drawing.Size(106, 21);
            this.cboUplinkType.TabIndex = 2;
            // 
            // lblUplinkType
            // 
            this.lblUplinkType.AutoSize = true;
            this.lblUplinkType.Location = new System.Drawing.Point(69, 95);
            this.lblUplinkType.Name = "lblUplinkType";
            this.lblUplinkType.Size = new System.Drawing.Size(67, 13);
            this.lblUplinkType.TabIndex = 4;
            this.lblUplinkType.Text = "Upling Type:";
            // 
            // cboUplingConfig
            // 
            this.cboUplingConfig.FormattingEnabled = true;
            this.cboUplingConfig.Items.AddRange(new object[] {
            "DFT-S-OFDM",
            "CP-OFDM"});
            this.cboUplingConfig.Location = new System.Drawing.Point(143, 125);
            this.cboUplingConfig.Name = "cboUplingConfig";
            this.cboUplingConfig.Size = new System.Drawing.Size(106, 21);
            this.cboUplingConfig.TabIndex = 3;
            // 
            // lblUplingConfig
            // 
            this.lblUplingConfig.AutoSize = true;
            this.lblUplingConfig.Location = new System.Drawing.Point(63, 130);
            this.lblUplingConfig.Name = "lblUplingConfig";
            this.lblUplingConfig.Size = new System.Drawing.Size(73, 13);
            this.lblUplingConfig.TabIndex = 6;
            this.lblUplingConfig.Text = "Uplink Config:";
            // 
            // lblSubCarrierSpacing
            // 
            this.lblSubCarrierSpacing.AutoSize = true;
            this.lblSubCarrierSpacing.Location = new System.Drawing.Point(6, 165);
            this.lblSubCarrierSpacing.Name = "lblSubCarrierSpacing";
            this.lblSubCarrierSpacing.Size = new System.Drawing.Size(130, 13);
            this.lblSubCarrierSpacing.TabIndex = 9;
            this.lblSubCarrierSpacing.Text = "SubCarrier Spacing [KHz]:";
            // 
            // numSubCarrierSpacing
            // 
            this.numSubCarrierSpacing.Location = new System.Drawing.Point(143, 161);
            this.numSubCarrierSpacing.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numSubCarrierSpacing.Name = "numSubCarrierSpacing";
            this.numSubCarrierSpacing.Size = new System.Drawing.Size(106, 20);
            this.numSubCarrierSpacing.TabIndex = 4;
            this.numSubCarrierSpacing.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numSubCarrierSpacing.Value = new decimal(new int[] {
            30,
            0,
            0,
            0});
            // 
            // cboPUSCHMod
            // 
            this.cboPUSCHMod.FormattingEnabled = true;
            this.cboPUSCHMod.Location = new System.Drawing.Point(143, 266);
            this.cboPUSCHMod.Name = "cboPUSCHMod";
            this.cboPUSCHMod.Size = new System.Drawing.Size(106, 21);
            this.cboPUSCHMod.TabIndex = 7;
            // 
            // lblRBOffset
            // 
            this.lblRBOffset.AutoSize = true;
            this.lblRBOffset.Location = new System.Drawing.Point(80, 200);
            this.lblRBOffset.Name = "lblRBOffset";
            this.lblRBOffset.Size = new System.Drawing.Size(56, 13);
            this.lblRBOffset.TabIndex = 10;
            this.lblRBOffset.Text = "RB Offest:";
            // 
            // cboMeasUnit
            // 
            this.cboMeasUnit.FormattingEnabled = true;
            this.cboMeasUnit.Location = new System.Drawing.Point(143, 302);
            this.cboMeasUnit.Name = "cboMeasUnit";
            this.cboMeasUnit.Size = new System.Drawing.Size(106, 21);
            this.cboMeasUnit.TabIndex = 8;
            // 
            // lblPUSCHMod
            // 
            this.lblPUSCHMod.AutoSize = true;
            this.lblPUSCHMod.Location = new System.Drawing.Point(65, 270);
            this.lblPUSCHMod.Name = "lblPUSCHMod";
            this.lblPUSCHMod.Size = new System.Drawing.Size(71, 13);
            this.lblPUSCHMod.TabIndex = 12;
            this.lblPUSCHMod.Text = "PUSCH Mod:";
            // 
            // lblMeasUnit
            // 
            this.lblMeasUnit.AutoSize = true;
            this.lblMeasUnit.Location = new System.Drawing.Point(78, 305);
            this.lblMeasUnit.Name = "lblMeasUnit";
            this.lblMeasUnit.Size = new System.Drawing.Size(58, 13);
            this.lblMeasUnit.TabIndex = 15;
            this.lblMeasUnit.Text = "Meas Unit:";
            // 
            // numMeasOffset
            // 
            this.numMeasOffset.Location = new System.Drawing.Point(143, 338);
            this.numMeasOffset.Name = "numMeasOffset";
            this.numMeasOffset.Size = new System.Drawing.Size(106, 20);
            this.numMeasOffset.TabIndex = 9;
            this.numMeasOffset.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numMeasOffset.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
            // 
            // lblMeasOffset
            // 
            this.lblMeasOffset.AutoSize = true;
            this.lblMeasOffset.Location = new System.Drawing.Point(69, 340);
            this.lblMeasOffset.Name = "lblMeasOffset";
            this.lblMeasOffset.Size = new System.Drawing.Size(67, 13);
            this.lblMeasOffset.TabIndex = 17;
            this.lblMeasOffset.Text = "Meas Offset:";
            // 
            // numMeasLength
            // 
            this.numMeasLength.Location = new System.Drawing.Point(143, 373);
            this.numMeasLength.Name = "numMeasLength";
            this.numMeasLength.Size = new System.Drawing.Size(106, 20);
            this.numMeasLength.TabIndex = 10;
            this.numMeasLength.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numMeasLength.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // cboEVMUnit
            // 
            this.cboEVMUnit.FormattingEnabled = true;
            this.cboEVMUnit.Location = new System.Drawing.Point(143, 408);
            this.cboEVMUnit.Name = "cboEVMUnit";
            this.cboEVMUnit.Size = new System.Drawing.Size(106, 21);
            this.cboEVMUnit.TabIndex = 11;
            // 
            // lblMeasLength
            // 
            this.lblMeasLength.AutoSize = true;
            this.lblMeasLength.Location = new System.Drawing.Point(64, 375);
            this.lblMeasLength.Name = "lblMeasLength";
            this.lblMeasLength.Size = new System.Drawing.Size(72, 13);
            this.lblMeasLength.TabIndex = 18;
            this.lblMeasLength.Text = "Meas Length:";
            // 
            // btnLoadFile
            // 
            this.btnLoadFile.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnLoadFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoadFile.Location = new System.Drawing.Point(412, 18);
            this.btnLoadFile.Name = "btnLoadFile";
            this.btnLoadFile.Size = new System.Drawing.Size(129, 55);
            this.btnLoadFile.TabIndex = 13;
            this.btnLoadFile.Text = "Load File";
            this.btnLoadFile.UseVisualStyleBackColor = false;
            this.btnLoadFile.Click += new System.EventHandler(this.btnLoadFile_Click);
            // 
            // dgvEVMData
            // 
            this.dgvEVMData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEVMData.Location = new System.Drawing.Point(276, 207);
            this.dgvEVMData.Name = "dgvEVMData";
            this.dgvEVMData.Size = new System.Drawing.Size(541, 226);
            this.dgvEVMData.TabIndex = 21;
            // 
            // btnDemod
            // 
            this.btnDemod.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnDemod.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDemod.Location = new System.Drawing.Point(314, 114);
            this.btnDemod.Name = "btnDemod";
            this.btnDemod.Size = new System.Drawing.Size(227, 41);
            this.btnDemod.TabIndex = 15;
            this.btnDemod.Text = "Demodulate File";
            this.btnDemod.UseVisualStyleBackColor = false;
            this.btnDemod.Click += new System.EventHandler(this.btnDemod_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.Red;
            this.btnExit.Location = new System.Drawing.Point(314, 163);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(227, 37);
            this.btnExit.TabIndex = 17;
            this.btnExit.Text = "EXIT";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnSaveData
            // 
            this.btnSaveData.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnSaveData.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveData.Location = new System.Drawing.Point(654, 163);
            this.btnSaveData.Name = "btnSaveData";
            this.btnSaveData.Size = new System.Drawing.Size(163, 39);
            this.btnSaveData.TabIndex = 18;
            this.btnSaveData.Text = "Save Data";
            this.btnSaveData.UseVisualStyleBackColor = false;
            this.btnSaveData.Click += new System.EventHandler(this.btnSaveData_Click);
            // 
            // picLogo
            // 
            this.picLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.picLogo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picLogo.Image = ((System.Drawing.Image)(resources.GetObject("picLogo.Image")));
            this.picLogo.Location = new System.Drawing.Point(555, 2);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(264, 108);
            this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picLogo.TabIndex = 25;
            this.picLogo.TabStop = false;
            // 
            // pgbOps
            // 
            this.pgbOps.Location = new System.Drawing.Point(12, 450);
            this.pgbOps.Name = "pgbOps";
            this.pgbOps.Size = new System.Drawing.Size(807, 36);
            this.pgbOps.TabIndex = 26;
            // 
            // numRBOffset
            // 
            this.numRBOffset.Location = new System.Drawing.Point(143, 196);
            this.numRBOffset.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.numRBOffset.Name = "numRBOffset";
            this.numRBOffset.Size = new System.Drawing.Size(106, 20);
            this.numRBOffset.TabIndex = 5;
            this.numRBOffset.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblEVMUnit
            // 
            this.lblEVMUnit.AutoSize = true;
            this.lblEVMUnit.Location = new System.Drawing.Point(81, 410);
            this.lblEVMUnit.Name = "lblEVMUnit";
            this.lblEVMUnit.Size = new System.Drawing.Size(55, 13);
            this.lblEVMUnit.TabIndex = 28;
            this.lblEVMUnit.Text = "EVM Unit:";
            // 
            // lblSamppleRate
            // 
            this.lblSamppleRate.AutoSize = true;
            this.lblSamppleRate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSamppleRate.Location = new System.Drawing.Point(266, 90);
            this.lblSamppleRate.Name = "lblSamppleRate";
            this.lblSamppleRate.Size = new System.Drawing.Size(151, 16);
            this.lblSamppleRate.TabIndex = 30;
            this.lblSamppleRate.Text = "Sample Rate [MS/s]:";
            // 
            // numSampleRate
            // 
            this.numSampleRate.DecimalPlaces = 3;
            this.numSampleRate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numSampleRate.Location = new System.Drawing.Point(421, 86);
            this.numSampleRate.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.numSampleRate.Name = "numSampleRate";
            this.numSampleRate.Size = new System.Drawing.Size(120, 22);
            this.numSampleRate.TabIndex = 14;
            this.numSampleRate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numSampleRate.Value = new decimal(new int[] {
            500,
            0,
            0,
            0});
            // 
            // chkConstellation
            // 
            this.chkConstellation.AutoSize = true;
            this.chkConstellation.Checked = true;
            this.chkConstellation.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkConstellation.Location = new System.Drawing.Point(552, 123);
            this.chkConstellation.Name = "chkConstellation";
            this.chkConstellation.Size = new System.Drawing.Size(116, 17);
            this.chkConstellation.TabIndex = 16;
            this.chkConstellation.Text = "Show Constellation";
            this.chkConstellation.UseVisualStyleBackColor = true;
            // 
            // numRBQty
            // 
            this.numRBQty.Location = new System.Drawing.Point(143, 231);
            this.numRBQty.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.numRBQty.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            this.numRBQty.Name = "numRBQty";
            this.numRBQty.Size = new System.Drawing.Size(106, 20);
            this.numRBQty.TabIndex = 6;
            this.numRBQty.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numRBQty.Value = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            // 
            // lblRBQty
            // 
            this.lblRBQty.AutoSize = true;
            this.lblRBQty.Location = new System.Drawing.Point(72, 235);
            this.lblRBQty.Name = "lblRBQty";
            this.lblRBQty.Size = new System.Drawing.Size(64, 13);
            this.lblRBQty.TabIndex = 34;
            this.lblRBQty.Text = "RB Quanity:";
            // 
            // gbxFileFormat
            // 
            this.gbxFileFormat.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.gbxFileFormat.Controls.Add(this.optIQFiles);
            this.gbxFileFormat.Controls.Add(this.optComplex);
            this.gbxFileFormat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxFileFormat.ForeColor = System.Drawing.Color.Blue;
            this.gbxFileFormat.Location = new System.Drawing.Point(257, 12);
            this.gbxFileFormat.Name = "gbxFileFormat";
            this.gbxFileFormat.Size = new System.Drawing.Size(149, 75);
            this.gbxFileFormat.TabIndex = 37;
            this.gbxFileFormat.TabStop = false;
            this.gbxFileFormat.Text = "Data File Format";
            // 
            // optIQFiles
            // 
            this.optIQFiles.AutoSize = true;
            this.optIQFiles.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.optIQFiles.Location = new System.Drawing.Point(11, 44);
            this.optIQFiles.Name = "optIQFiles";
            this.optIQFiles.Size = new System.Drawing.Size(133, 19);
            this.optIQFiles.TabIndex = 1;
            this.optIQFiles.TabStop = true;
            this.optIQFiles.Text = "I/Q Files (I_ and Q_)";
            this.optIQFiles.UseVisualStyleBackColor = true;
            this.optIQFiles.CheckedChanged += new System.EventHandler(this.optIQFiles_CheckedChanged);
            // 
            // optComplex
            // 
            this.optComplex.AutoSize = true;
            this.optComplex.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.optComplex.Location = new System.Drawing.Point(11, 22);
            this.optComplex.Name = "optComplex";
            this.optComplex.Size = new System.Drawing.Size(116, 20);
            this.optComplex.TabIndex = 0;
            this.optComplex.TabStop = true;
            this.optComplex.Text = "Complex (a+bi)";
            this.optComplex.UseVisualStyleBackColor = true;
            this.optComplex.CheckedChanged += new System.EventHandler(this.optComplex_CheckedChanged);
            // 
            // frmRFmxSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(829, 491);
            this.Controls.Add(this.gbxFileFormat);
            this.Controls.Add(this.lblRBQty);
            this.Controls.Add(this.numRBQty);
            this.Controls.Add(this.chkConstellation);
            this.Controls.Add(this.lblSamppleRate);
            this.Controls.Add(this.numSampleRate);
            this.Controls.Add(this.lblEVMUnit);
            this.Controls.Add(this.numRBOffset);
            this.Controls.Add(this.pgbOps);
            this.Controls.Add(this.picLogo);
            this.Controls.Add(this.btnSaveData);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnDemod);
            this.Controls.Add(this.dgvEVMData);
            this.Controls.Add(this.btnLoadFile);
            this.Controls.Add(this.cboEVMUnit);
            this.Controls.Add(this.lblMeasLength);
            this.Controls.Add(this.lblMeasOffset);
            this.Controls.Add(this.numMeasLength);
            this.Controls.Add(this.lblMeasUnit);
            this.Controls.Add(this.numMeasOffset);
            this.Controls.Add(this.cboMeasUnit);
            this.Controls.Add(this.lblPUSCHMod);
            this.Controls.Add(this.cboPUSCHMod);
            this.Controls.Add(this.lblRBOffset);
            this.Controls.Add(this.lblSubCarrierSpacing);
            this.Controls.Add(this.numSubCarrierSpacing);
            this.Controls.Add(this.cboUplingConfig);
            this.Controls.Add(this.lblUplingConfig);
            this.Controls.Add(this.cboUplinkType);
            this.Controls.Add(this.lblUplinkType);
            this.Controls.Add(this.cboDuplex);
            this.Controls.Add(this.lblDuplex);
            this.Controls.Add(this.lblCarrierBW);
            this.Controls.Add(this.numCarrierBW);
            this.Name = "frmRFmxSettings";
            this.Text = "RFmxSettings for 5G/ New Radio";
            ((System.ComponentModel.ISupportInitialize)(this.numCarrierBW)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSubCarrierSpacing)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMeasOffset)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMeasLength)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEVMData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numRBOffset)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSampleRate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numRBQty)).EndInit();
            this.gbxFileFormat.ResumeLayout(false);
            this.gbxFileFormat.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown numCarrierBW;
        private System.Windows.Forms.Label lblCarrierBW;
        private System.Windows.Forms.Label lblDuplex;
        private System.Windows.Forms.ComboBox cboDuplex;
        private System.Windows.Forms.ComboBox cboUplinkType;
        private System.Windows.Forms.Label lblUplinkType;
        private System.Windows.Forms.ComboBox cboUplingConfig;
        private System.Windows.Forms.Label lblUplingConfig;
        private System.Windows.Forms.Label lblSubCarrierSpacing;
        private System.Windows.Forms.NumericUpDown numSubCarrierSpacing;
        private System.Windows.Forms.ComboBox cboPUSCHMod;
        private System.Windows.Forms.Label lblRBOffset;
        private System.Windows.Forms.ComboBox cboMeasUnit;
        private System.Windows.Forms.Label lblPUSCHMod;
        private System.Windows.Forms.Label lblMeasUnit;
        private System.Windows.Forms.NumericUpDown numMeasOffset;
        private System.Windows.Forms.Label lblMeasOffset;
        private System.Windows.Forms.NumericUpDown numMeasLength;
        private System.Windows.Forms.ComboBox cboEVMUnit;
        private System.Windows.Forms.Label lblMeasLength;
        private System.Windows.Forms.Button btnLoadFile;
        private System.Windows.Forms.DataGridView dgvEVMData;
        private System.Windows.Forms.Button btnDemod;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnSaveData;
        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.ProgressBar pgbOps;
        private System.Windows.Forms.NumericUpDown numRBOffset;
        private System.Windows.Forms.Label lblEVMUnit;
        private System.Windows.Forms.Label lblSamppleRate;
        private System.Windows.Forms.NumericUpDown numSampleRate;
        private System.Windows.Forms.OpenFileDialog openfileDialog;
        private System.Windows.Forms.CheckBox chkConstellation;
        private System.Windows.Forms.NumericUpDown numRBQty;
        private System.Windows.Forms.Label lblRBQty;
        private System.Windows.Forms.GroupBox gbxFileFormat;
        private System.Windows.Forms.RadioButton optIQFiles;
        private System.Windows.Forms.RadioButton optComplex;
    }
}