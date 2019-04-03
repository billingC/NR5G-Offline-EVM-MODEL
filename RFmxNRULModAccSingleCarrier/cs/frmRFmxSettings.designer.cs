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
            this.cboLinkDirection = new System.Windows.Forms.ComboBox();
            this.lblLinkDirection = new System.Windows.Forms.Label();
            this.cboMiltiplexingScheme = new System.Windows.Forms.ComboBox();
            this.lblMultiplexingScheme = new System.Windows.Forms.Label();
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblCdmGroups = new System.Windows.Forms.Label();
            this.numCdmGroups = new System.Windows.Forms.NumericUpDown();
            this.lblDmrsAdditionalPosition = new System.Windows.Forms.Label();
            this.numDmrsAdditionalPosition = new System.Windows.Forms.NumericUpDown();
            this.lblDmrsDuration = new System.Windows.Forms.Label();
            this.cboDmrsDuration = new System.Windows.Forms.ComboBox();
            this.lblDmrsPosition = new System.Windows.Forms.Label();
            this.numDmrsPosition = new System.Windows.Forms.NumericUpDown();
            this.lblDmrsMappingType = new System.Windows.Forms.Label();
            this.cboDmrsMappingType = new System.Windows.Forms.ComboBox();
            this.lblDmrsConfigType = new System.Windows.Forms.Label();
            this.cboDmrsConfigType = new System.Windows.Forms.ComboBox();
            this.lblDmrsPower = new System.Windows.Forms.Label();
            this.numDmrsPower = new System.Windows.Forms.NumericUpDown();
            this.lblDmrsPowerMode = new System.Windows.Forms.Label();
            this.cboDmrsPowerMode = new System.Windows.Forms.ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
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
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numCdmGroups)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDmrsAdditionalPosition)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDmrsPosition)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDmrsPower)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // numCarrierBW
            // 
            this.numCarrierBW.Location = new System.Drawing.Point(146, 10);
            this.numCarrierBW.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numCarrierBW.Name = "numCarrierBW";
            this.numCarrierBW.Size = new System.Drawing.Size(94, 20);
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
            this.lblCarrierBW.Location = new System.Drawing.Point(45, 17);
            this.lblCarrierBW.Name = "lblCarrierBW";
            this.lblCarrierBW.Size = new System.Drawing.Size(92, 13);
            this.lblCarrierBW.TabIndex = 1;
            this.lblCarrierBW.Text = "Carrier BW [MHz]:";
            // 
            // lblDuplex
            // 
            this.lblDuplex.AutoSize = true;
            this.lblDuplex.Location = new System.Drawing.Point(52, 52);
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
            this.cboDuplex.Location = new System.Drawing.Point(146, 45);
            this.cboDuplex.Name = "cboDuplex";
            this.cboDuplex.Size = new System.Drawing.Size(94, 21);
            this.cboDuplex.TabIndex = 1;
            // 
            // cboLinkDirection
            // 
            this.cboLinkDirection.FormattingEnabled = true;
            this.cboLinkDirection.Location = new System.Drawing.Point(146, 81);
            this.cboLinkDirection.Name = "cboLinkDirection";
            this.cboLinkDirection.Size = new System.Drawing.Size(94, 21);
            this.cboLinkDirection.TabIndex = 2;
            // 
            // lblLinkDirection
            // 
            this.lblLinkDirection.AutoSize = true;
            this.lblLinkDirection.Location = new System.Drawing.Point(62, 87);
            this.lblLinkDirection.Name = "lblLinkDirection";
            this.lblLinkDirection.Size = new System.Drawing.Size(75, 13);
            this.lblLinkDirection.TabIndex = 4;
            this.lblLinkDirection.Text = "Link Direction:";
            // 
            // cboMiltiplexingScheme
            // 
            this.cboMiltiplexingScheme.FormattingEnabled = true;
            this.cboMiltiplexingScheme.Items.AddRange(new object[] {
            "DFT-S-OFDM",
            "CP-OFDM"});
            this.cboMiltiplexingScheme.Location = new System.Drawing.Point(146, 117);
            this.cboMiltiplexingScheme.Name = "cboMiltiplexingScheme";
            this.cboMiltiplexingScheme.Size = new System.Drawing.Size(94, 21);
            this.cboMiltiplexingScheme.TabIndex = 3;
            // 
            // lblMultiplexingScheme
            // 
            this.lblMultiplexingScheme.AutoSize = true;
            this.lblMultiplexingScheme.Location = new System.Drawing.Point(30, 122);
            this.lblMultiplexingScheme.Name = "lblMultiplexingScheme";
            this.lblMultiplexingScheme.Size = new System.Drawing.Size(107, 13);
            this.lblMultiplexingScheme.TabIndex = 6;
            this.lblMultiplexingScheme.Text = "Multiplexing Scheme:";
            // 
            // lblSubCarrierSpacing
            // 
            this.lblSubCarrierSpacing.AutoSize = true;
            this.lblSubCarrierSpacing.Location = new System.Drawing.Point(7, 157);
            this.lblSubCarrierSpacing.Name = "lblSubCarrierSpacing";
            this.lblSubCarrierSpacing.Size = new System.Drawing.Size(130, 13);
            this.lblSubCarrierSpacing.TabIndex = 9;
            this.lblSubCarrierSpacing.Text = "SubCarrier Spacing [KHz]:";
            // 
            // numSubCarrierSpacing
            // 
            this.numSubCarrierSpacing.Location = new System.Drawing.Point(146, 153);
            this.numSubCarrierSpacing.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numSubCarrierSpacing.Name = "numSubCarrierSpacing";
            this.numSubCarrierSpacing.Size = new System.Drawing.Size(94, 20);
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
            this.cboPUSCHMod.Location = new System.Drawing.Point(146, 258);
            this.cboPUSCHMod.Name = "cboPUSCHMod";
            this.cboPUSCHMod.Size = new System.Drawing.Size(94, 21);
            this.cboPUSCHMod.TabIndex = 7;
            // 
            // lblRBOffset
            // 
            this.lblRBOffset.AutoSize = true;
            this.lblRBOffset.Location = new System.Drawing.Point(81, 192);
            this.lblRBOffset.Name = "lblRBOffset";
            this.lblRBOffset.Size = new System.Drawing.Size(56, 13);
            this.lblRBOffset.TabIndex = 10;
            this.lblRBOffset.Text = "RB Offest:";
            // 
            // cboMeasUnit
            // 
            this.cboMeasUnit.FormattingEnabled = true;
            this.cboMeasUnit.Location = new System.Drawing.Point(145, 12);
            this.cboMeasUnit.Name = "cboMeasUnit";
            this.cboMeasUnit.Size = new System.Drawing.Size(94, 21);
            this.cboMeasUnit.TabIndex = 8;
            // 
            // lblPUSCHMod
            // 
            this.lblPUSCHMod.AutoSize = true;
            this.lblPUSCHMod.Location = new System.Drawing.Point(66, 262);
            this.lblPUSCHMod.Name = "lblPUSCHMod";
            this.lblPUSCHMod.Size = new System.Drawing.Size(71, 13);
            this.lblPUSCHMod.TabIndex = 12;
            this.lblPUSCHMod.Text = "PUSCH Mod:";
            // 
            // lblMeasUnit
            // 
            this.lblMeasUnit.AutoSize = true;
            this.lblMeasUnit.Location = new System.Drawing.Point(78, 15);
            this.lblMeasUnit.Name = "lblMeasUnit";
            this.lblMeasUnit.Size = new System.Drawing.Size(58, 13);
            this.lblMeasUnit.TabIndex = 15;
            this.lblMeasUnit.Text = "Meas Unit:";
            // 
            // numMeasOffset
            // 
            this.numMeasOffset.Location = new System.Drawing.Point(145, 39);
            this.numMeasOffset.Name = "numMeasOffset";
            this.numMeasOffset.Size = new System.Drawing.Size(94, 20);
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
            this.lblMeasOffset.Location = new System.Drawing.Point(69, 43);
            this.lblMeasOffset.Name = "lblMeasOffset";
            this.lblMeasOffset.Size = new System.Drawing.Size(67, 13);
            this.lblMeasOffset.TabIndex = 17;
            this.lblMeasOffset.Text = "Meas Offset:";
            // 
            // numMeasLength
            // 
            this.numMeasLength.Location = new System.Drawing.Point(145, 66);
            this.numMeasLength.Name = "numMeasLength";
            this.numMeasLength.Size = new System.Drawing.Size(94, 20);
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
            this.cboEVMUnit.Location = new System.Drawing.Point(145, 92);
            this.cboEVMUnit.Name = "cboEVMUnit";
            this.cboEVMUnit.Size = new System.Drawing.Size(94, 21);
            this.cboEVMUnit.TabIndex = 11;
            // 
            // lblMeasLength
            // 
            this.lblMeasLength.AutoSize = true;
            this.lblMeasLength.Location = new System.Drawing.Point(64, 71);
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
            this.dgvEVMData.Size = new System.Drawing.Size(541, 435);
            this.dgvEVMData.TabIndex = 21;
            // 
            // btnDemod
            // 
            this.btnDemod.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnDemod.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDemod.Location = new System.Drawing.Point(276, 114);
            this.btnDemod.Name = "btnDemod";
            this.btnDemod.Size = new System.Drawing.Size(265, 41);
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
            this.btnExit.Location = new System.Drawing.Point(276, 163);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(265, 37);
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
            this.pgbOps.Location = new System.Drawing.Point(13, 648);
            this.pgbOps.Name = "pgbOps";
            this.pgbOps.Size = new System.Drawing.Size(807, 36);
            this.pgbOps.TabIndex = 26;
            // 
            // numRBOffset
            // 
            this.numRBOffset.Location = new System.Drawing.Point(146, 188);
            this.numRBOffset.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.numRBOffset.Name = "numRBOffset";
            this.numRBOffset.Size = new System.Drawing.Size(94, 20);
            this.numRBOffset.TabIndex = 5;
            this.numRBOffset.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblEVMUnit
            // 
            this.lblEVMUnit.AutoSize = true;
            this.lblEVMUnit.Location = new System.Drawing.Point(81, 99);
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
            this.numRBQty.Location = new System.Drawing.Point(146, 223);
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
            this.numRBQty.Size = new System.Drawing.Size(94, 20);
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
            this.lblRBQty.Location = new System.Drawing.Point(73, 227);
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
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.lblCdmGroups);
            this.panel1.Controls.Add(this.numCdmGroups);
            this.panel1.Controls.Add(this.lblDmrsAdditionalPosition);
            this.panel1.Controls.Add(this.numDmrsAdditionalPosition);
            this.panel1.Controls.Add(this.lblDmrsDuration);
            this.panel1.Controls.Add(this.cboDmrsDuration);
            this.panel1.Controls.Add(this.lblDmrsPosition);
            this.panel1.Controls.Add(this.numDmrsPosition);
            this.panel1.Controls.Add(this.lblDmrsMappingType);
            this.panel1.Controls.Add(this.cboDmrsMappingType);
            this.panel1.Controls.Add(this.lblDmrsConfigType);
            this.panel1.Controls.Add(this.cboDmrsConfigType);
            this.panel1.Controls.Add(this.lblDmrsPower);
            this.panel1.Controls.Add(this.numDmrsPower);
            this.panel1.Controls.Add(this.lblDmrsPowerMode);
            this.panel1.Controls.Add(this.cboDmrsPowerMode);
            this.panel1.Location = new System.Drawing.Point(9, 294);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(251, 224);
            this.panel1.TabIndex = 38;
            // 
            // lblCdmGroups
            // 
            this.lblCdmGroups.AutoSize = true;
            this.lblCdmGroups.Location = new System.Drawing.Point(31, 204);
            this.lblCdmGroups.Name = "lblCdmGroups";
            this.lblCdmGroups.Size = new System.Drawing.Size(106, 13);
            this.lblCdmGroups.TabIndex = 50;
            this.lblCdmGroups.Text = "DMRS CDM Groups:";
            // 
            // numCdmGroups
            // 
            this.numCdmGroups.Location = new System.Drawing.Point(146, 199);
            this.numCdmGroups.Maximum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.numCdmGroups.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numCdmGroups.Name = "numCdmGroups";
            this.numCdmGroups.Size = new System.Drawing.Size(94, 20);
            this.numCdmGroups.TabIndex = 49;
            this.numCdmGroups.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numCdmGroups.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lblDmrsAdditionalPosition
            // 
            this.lblDmrsAdditionalPosition.AutoSize = true;
            this.lblDmrsAdditionalPosition.Location = new System.Drawing.Point(21, 147);
            this.lblDmrsAdditionalPosition.Name = "lblDmrsAdditionalPosition";
            this.lblDmrsAdditionalPosition.Size = new System.Drawing.Size(116, 13);
            this.lblDmrsAdditionalPosition.TabIndex = 48;
            this.lblDmrsAdditionalPosition.Text = "DMRS Added Position:";
            // 
            // numDmrsAdditionalPosition
            // 
            this.numDmrsAdditionalPosition.Location = new System.Drawing.Point(146, 145);
            this.numDmrsAdditionalPosition.Maximum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.numDmrsAdditionalPosition.Name = "numDmrsAdditionalPosition";
            this.numDmrsAdditionalPosition.Size = new System.Drawing.Size(94, 20);
            this.numDmrsAdditionalPosition.TabIndex = 47;
            this.numDmrsAdditionalPosition.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblDmrsDuration
            // 
            this.lblDmrsDuration.AutoSize = true;
            this.lblDmrsDuration.Location = new System.Drawing.Point(52, 91);
            this.lblDmrsDuration.Name = "lblDmrsDuration";
            this.lblDmrsDuration.Size = new System.Drawing.Size(85, 13);
            this.lblDmrsDuration.TabIndex = 46;
            this.lblDmrsDuration.Text = "DMRS Duration:";
            // 
            // cboDmrsDuration
            // 
            this.cboDmrsDuration.FormattingEnabled = true;
            this.cboDmrsDuration.Location = new System.Drawing.Point(146, 88);
            this.cboDmrsDuration.Name = "cboDmrsDuration";
            this.cboDmrsDuration.Size = new System.Drawing.Size(93, 21);
            this.cboDmrsDuration.TabIndex = 45;
            // 
            // lblDmrsPosition
            // 
            this.lblDmrsPosition.AutoSize = true;
            this.lblDmrsPosition.Location = new System.Drawing.Point(20, 119);
            this.lblDmrsPosition.Name = "lblDmrsPosition";
            this.lblDmrsPosition.Size = new System.Drawing.Size(116, 13);
            this.lblDmrsPosition.TabIndex = 44;
            this.lblDmrsPosition.Text = "DMRS Type APosition:";
            // 
            // numDmrsPosition
            // 
            this.numDmrsPosition.Location = new System.Drawing.Point(146, 116);
            this.numDmrsPosition.Maximum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.numDmrsPosition.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numDmrsPosition.Name = "numDmrsPosition";
            this.numDmrsPosition.Size = new System.Drawing.Size(94, 20);
            this.numDmrsPosition.TabIndex = 43;
            this.numDmrsPosition.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numDmrsPosition.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // lblDmrsMappingType
            // 
            this.lblDmrsMappingType.AutoSize = true;
            this.lblDmrsMappingType.Location = new System.Drawing.Point(23, 176);
            this.lblDmrsMappingType.Name = "lblDmrsMappingType";
            this.lblDmrsMappingType.Size = new System.Drawing.Size(113, 13);
            this.lblDmrsMappingType.TabIndex = 42;
            this.lblDmrsMappingType.Text = "DMRS Mapping Type:";
            // 
            // cboDmrsMappingType
            // 
            this.cboDmrsMappingType.FormattingEnabled = true;
            this.cboDmrsMappingType.Location = new System.Drawing.Point(145, 172);
            this.cboDmrsMappingType.Name = "cboDmrsMappingType";
            this.cboDmrsMappingType.Size = new System.Drawing.Size(93, 21);
            this.cboDmrsMappingType.TabIndex = 41;
            // 
            // lblDmrsConfigType
            // 
            this.lblDmrsConfigType.AutoSize = true;
            this.lblDmrsConfigType.Location = new System.Drawing.Point(35, 66);
            this.lblDmrsConfigType.Name = "lblDmrsConfigType";
            this.lblDmrsConfigType.Size = new System.Drawing.Size(102, 13);
            this.lblDmrsConfigType.TabIndex = 40;
            this.lblDmrsConfigType.Text = "DMRS Config Type:";
            // 
            // cboDmrsConfigType
            // 
            this.cboDmrsConfigType.FormattingEnabled = true;
            this.cboDmrsConfigType.Location = new System.Drawing.Point(146, 61);
            this.cboDmrsConfigType.Name = "cboDmrsConfigType";
            this.cboDmrsConfigType.Size = new System.Drawing.Size(93, 21);
            this.cboDmrsConfigType.TabIndex = 39;
            // 
            // lblDmrsPower
            // 
            this.lblDmrsPower.AutoSize = true;
            this.lblDmrsPower.Location = new System.Drawing.Point(40, 40);
            this.lblDmrsPower.Name = "lblDmrsPower";
            this.lblDmrsPower.Size = new System.Drawing.Size(97, 13);
            this.lblDmrsPower.TabIndex = 38;
            this.lblDmrsPower.Text = "DMRS Power [dB]:";
            // 
            // numDmrsPower
            // 
            this.numDmrsPower.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numDmrsPower.Location = new System.Drawing.Point(146, 35);
            this.numDmrsPower.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.numDmrsPower.Minimum = new decimal(new int[] {
            20,
            0,
            0,
            -2147483648});
            this.numDmrsPower.Name = "numDmrsPower";
            this.numDmrsPower.Size = new System.Drawing.Size(94, 20);
            this.numDmrsPower.TabIndex = 37;
            this.numDmrsPower.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblDmrsPowerMode
            // 
            this.lblDmrsPowerMode.AutoSize = true;
            this.lblDmrsPowerMode.Location = new System.Drawing.Point(32, 14);
            this.lblDmrsPowerMode.Name = "lblDmrsPowerMode";
            this.lblDmrsPowerMode.Size = new System.Drawing.Size(105, 13);
            this.lblDmrsPowerMode.TabIndex = 14;
            this.lblDmrsPowerMode.Text = "DMRS Power Mode:";
            // 
            // cboDmrsPowerMode
            // 
            this.cboDmrsPowerMode.FormattingEnabled = true;
            this.cboDmrsPowerMode.Location = new System.Drawing.Point(146, 8);
            this.cboDmrsPowerMode.Name = "cboDmrsPowerMode";
            this.cboDmrsPowerMode.Size = new System.Drawing.Size(93, 21);
            this.cboDmrsPowerMode.TabIndex = 13;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.cboEVMUnit);
            this.panel2.Controls.Add(this.numMeasLength);
            this.panel2.Controls.Add(this.numMeasOffset);
            this.panel2.Controls.Add(this.cboMeasUnit);
            this.panel2.Controls.Add(this.lblEVMUnit);
            this.panel2.Controls.Add(this.lblMeasLength);
            this.panel2.Controls.Add(this.lblMeasOffset);
            this.panel2.Controls.Add(this.lblMeasUnit);
            this.panel2.Location = new System.Drawing.Point(9, 518);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(251, 124);
            this.panel2.TabIndex = 39;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.lblRBQty);
            this.panel3.Controls.Add(this.numRBQty);
            this.panel3.Controls.Add(this.numRBOffset);
            this.panel3.Controls.Add(this.lblPUSCHMod);
            this.panel3.Controls.Add(this.cboPUSCHMod);
            this.panel3.Controls.Add(this.lblRBOffset);
            this.panel3.Controls.Add(this.lblSubCarrierSpacing);
            this.panel3.Controls.Add(this.numSubCarrierSpacing);
            this.panel3.Controls.Add(this.cboMiltiplexingScheme);
            this.panel3.Controls.Add(this.lblMultiplexingScheme);
            this.panel3.Controls.Add(this.cboLinkDirection);
            this.panel3.Controls.Add(this.lblLinkDirection);
            this.panel3.Controls.Add(this.cboDuplex);
            this.panel3.Controls.Add(this.lblDuplex);
            this.panel3.Controls.Add(this.lblCarrierBW);
            this.panel3.Controls.Add(this.numCarrierBW);
            this.panel3.Location = new System.Drawing.Point(9, 8);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(251, 286);
            this.panel3.TabIndex = 40;
            // 
            // frmRFmxSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(832, 691);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.gbxFileFormat);
            this.Controls.Add(this.chkConstellation);
            this.Controls.Add(this.lblSamppleRate);
            this.Controls.Add(this.numSampleRate);
            this.Controls.Add(this.pgbOps);
            this.Controls.Add(this.picLogo);
            this.Controls.Add(this.btnSaveData);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnDemod);
            this.Controls.Add(this.dgvEVMData);
            this.Controls.Add(this.btnLoadFile);
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
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numCdmGroups)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDmrsAdditionalPosition)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDmrsPosition)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDmrsPower)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown numCarrierBW;
        private System.Windows.Forms.Label lblCarrierBW;
        private System.Windows.Forms.Label lblDuplex;
        private System.Windows.Forms.ComboBox cboDuplex;
        private System.Windows.Forms.ComboBox cboLinkDirection;
        private System.Windows.Forms.Label lblLinkDirection;
        private System.Windows.Forms.ComboBox cboMiltiplexingScheme;
        private System.Windows.Forms.Label lblMultiplexingScheme;
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
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblDmrsPosition;
        private System.Windows.Forms.NumericUpDown numDmrsPosition;
        private System.Windows.Forms.Label lblDmrsMappingType;
        private System.Windows.Forms.ComboBox cboDmrsMappingType;
        private System.Windows.Forms.Label lblDmrsConfigType;
        private System.Windows.Forms.ComboBox cboDmrsConfigType;
        private System.Windows.Forms.Label lblDmrsPower;
        private System.Windows.Forms.NumericUpDown numDmrsPower;
        private System.Windows.Forms.Label lblDmrsPowerMode;
        private System.Windows.Forms.ComboBox cboDmrsPowerMode;
        private System.Windows.Forms.Label lblDmrsAdditionalPosition;
        private System.Windows.Forms.NumericUpDown numDmrsAdditionalPosition;
        private System.Windows.Forms.Label lblDmrsDuration;
        private System.Windows.Forms.ComboBox cboDmrsDuration;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblCdmGroups;
        private System.Windows.Forms.NumericUpDown numCdmGroups;
        private System.Windows.Forms.Panel panel3;
    }
}