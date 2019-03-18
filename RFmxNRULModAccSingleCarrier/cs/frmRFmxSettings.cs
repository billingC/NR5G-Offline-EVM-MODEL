using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using System.IO;
using System.Threading.Tasks;
using System.Timers;
using System.Diagnostics;
using Excel = Microsoft.Office.Interop.Excel;

namespace NationalInstruments.Examples.RFmxNRULModAccSingleCarrier
{
    public partial class frmRFmxSettings : Form
    {
        RFmxNRULModAccSingleCarrier RFmxOBJ = new RFmxNRULModAccSingleCarrier();

        static ComplexSingle[] RIData = null;
        static ComplexWaveform<ComplexSingle> RIWave = null;
        internal string fName = "";

        public enum RFmxMultiplexing
        {
            DFTSOFDM = 0,
            CPOFDM = 1
        }

        public enum RFmxDuplexMode
        {
            FDD = 0,
            TDD = 1
        }

        public frmRFmxSettings()
        {
            InitializeComponent();
            this.optComplex.Checked = true; this.optIQFiles.Checked = false;
        }
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            this.cboDuplex.DataSource = Enum.GetValues(typeof(RFmxDuplexMode));
            this.cboDuplex.SelectedItem = RFmxDuplexMode.FDD;

            this.cboUplinkType.DataSource = Enum.GetValues(typeof(RFmx.NRMX.RFmxNRMXLinkDirection));
            this.cboUplinkType.SelectedItem = RFmx.NRMX.RFmxNRMXLinkDirection.Uplink;

            this.cboUplingConfig.DataSource = Enum.GetValues(typeof(RFmxMultiplexing));
            this.cboUplingConfig.SelectedItem = RFmxMultiplexing.DFTSOFDM;

            this.cboPUSCHMod.DataSource = Enum.GetValues(typeof(RFmx.NRMX.RFmxNRMXPuschModulationType));
            this.cboPUSCHMod.SelectedItem = RFmx.NRMX.RFmxNRMXPuschModulationType.Qam256;

            this.cboMeasUnit.DataSource = Enum.GetValues(typeof(RFmx.NRMX.RFmxNRMXModAccMeasurementLengthUnit));
            this.cboMeasUnit.SelectedItem = RFmx.NRMX.RFmxNRMXModAccMeasurementLengthUnit.Slot;

            this.cboEVMUnit.DataSource = Enum.GetValues(typeof(RFmx.NRMX.RFmxNRMXModAccEvmUnit));
            this.cboEVMUnit.SelectedItem = RFmx.NRMX.RFmxNRMXModAccEvmUnit.Percentage;
        }

        private void btnLoadFile_Click(object sender, EventArgs e)
        {
            // 
            // openfileDialog
            // 
            this.openfileDialog = new System.Windows.Forms.OpenFileDialog();
            this.openfileDialog.FileName = "";
            this.openfileDialog.Title = "Load IQ ComplexDouble Array";
            this.openfileDialog.ShowDialog();
            //
            fName = this.openfileDialog.FileName;
            this.openfileDialog.Dispose();

            if (File.Exists(@fName))
            {
                actionDone = false;
                RIData = null;  //preset for parallel operation

                if (this.optComplex.Checked)
                    Parallel.Invoke(() => SpinProgressBar(true), () => RIData = RFmxOBJ.LoadComplexFile(this.openfileDialog.FileName));
                else
                {
                    string fNameRoot = Path.GetDirectoryName(this.openfileDialog.FileName);
                    string fNameFirstFile = Path.GetFileName(this.openfileDialog.FileName);
                    string fNameSecondFile = "";
                    if (fNameFirstFile.ToUpper().StartsWith("I"))
                        fNameSecondFile = "Q" + fNameFirstFile.Substring(1);
                    else if (fNameFirstFile.ToUpper().StartsWith("Q"))
                        fNameSecondFile = "I" + fNameFirstFile.Substring(1);

                    Parallel.Invoke(() => SpinProgressBar(true), () => RIData = RFmxOBJ.LoadIQFiles(Path.Combine(fNameRoot, fNameFirstFile), Path.Combine(fNameRoot, fNameSecondFile)));
                }

            }
            else
                MessageBox.Show("File missing...", "Load File", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        //Task<ComplexSingle[]> GetRIDataAsync(string fname)
        //{
        //    return Task.Run (() => RFmxOBJ.LoadComplexFile(fname));
        //}

        internal static bool actionDone = false;

        Action onCompleted = () => { actionDone = true;  /*On complete action*/ };

        //internal void SpinProgressBar()
        //{
        //    this.pgbOps.Minimum = 0;
        //    this.pgbOps.Maximum = 100;

        //    Action onCompleted = () =>
        //    {
        //        pgbThreadFlag.Set();
        //        //On complete action
        //    };

        //    var thread = new Thread(() =>
        //    {
        //        try
        //        {
        //            while (true)
        //            {
        //                for (int i = 0; i < this.pgbOps.Maximum; i++)
        //                {
        //                    this.pgbOps.Value = i;
        //                    Thread.Sleep(1);
        //                    if (this.InvokeRequired)
        //                    {
        //                        RefreshDelegate rf = new Examples.RFmxNRULModAccSingleCarrier.frmRFmxSettings.RefreshDelegate(Refresh);
        //                        this.Invoke(rf, new object[] { });
        //                    }
        //                    this.Invoke(onCompleted);
        //                    //this.Refresh();
        //                }
        //            }
        //        }
        //        finally
        //        {
        //            this.Invoke(onCompleted);
        //        }

        //    });
        //    //thread.Start();
        //}

        private void SpinProgressBar(bool userMsg = false)
        {
            this.pgbOps.Minimum = 0;
            this.pgbOps.Maximum = 105;
            while (!actionDone)
            {
                for (int i = 0; i < this.pgbOps.Maximum - 4; i++)
                {
                    this.pgbOps.Value = i + 4;
                    Thread.Sleep(2);
                    this.Refresh();
                }
                if (RIData != null) this.Invoke(onCompleted);
            }
            this.pgbOps.Value = 1;
            if (userMsg)
                MessageBox.Show("Next, try to demodulate the file.", "File Loaded", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnDemod_Click(object sender, EventArgs e)
        {
            Stopwatch sw = new Stopwatch();
            sw.Start();
            try
            {
                RFmxOBJ.InitializeVariables();

                //Variables
                RFmxOBJ.componentCarrierBandwidth = Convert.ToDouble(this.numCarrierBW.Value) * 1e6;
                RFmxOBJ.cellID = 0;

                RFmxOBJ.duplexScheme = (RFmxDuplexMode)this.cboDuplex.SelectedItem;

                RFmxOBJ.lnkDirection = (RFmx.NRMX.RFmxNRMXLinkDirection)this.cboUplinkType.SelectedItem;

                RFmxOBJ.subcarrierSpacing = Convert.ToDouble(this.numSubCarrierSpacing.Value) * 1e3;
                RFmxOBJ.band = 78;   //Convert.ToInt32(this.numBand.Value);

                //RFmxOBJ.uplinkWaveformType = (RFmx.NRMX.RFmxNRMXUplinkWaveformType)this.cboUplinkType.SelectedItem;
                RFmxOBJ.puschTransformPrecodingEnabled = (((RFmxMultiplexing)this.cboUplingConfig.SelectedItem == RFmxMultiplexing.DFTSOFDM) ? RFmx.NRMX.RFmxNRMXPuschTransformPrecodingEnabled.True : RFmx.NRMX.RFmxNRMXPuschTransformPrecodingEnabled.False);

                RFmxOBJ.puschNumberOfRBClusters = 1;
                RFmxOBJ.puschRBOffset = (Int32)this.numRBOffset.Value;
                RFmxOBJ.puschNumberOfRBs = (Int32)this.numRBQty.Value;
                RFmxOBJ.puschModulationType = (RFmx.NRMX.RFmxNRMXPuschModulationType)this.cboPUSCHMod.SelectedItem;
                RFmxOBJ.puschSlotAllocation = "0-Last";
                RFmxOBJ.puschSymbolAllocation = "0-Last";
                RFmxOBJ.puschDmrsPower = -3;

                RFmxOBJ.puschDmrsConfigurationType = RFmx.NRMX.RFmxNRMXPuschDmrsConfigurationType.Type1;
                RFmxOBJ.puschDmrsMappingType = RFmx.NRMX.RFmxNRMXPuschMappingType.TypeA;
                RFmxOBJ.intPuschDmrsTypeAPosition = 2;
                RFmxOBJ.puschDmrsDuration = RFmx.NRMX.RFmxNRMXPuschDmrsDuration.SingleSymbol;
                //RFmxOBJ.puschDmrsAdditionalPositions = RFmx.NRMX.RFmxNRMXPuschDmrsAdditionalPositions.AdditionalPositions0;

                RFmxOBJ.averagingEnabled = RFmx.NRMX.RFmxNRMXModAccAveragingEnabled.False;
                RFmxOBJ.averagingCount = 10;

                RFmxOBJ.measurementLengthUnit = (RFmx.NRMX.RFmxNRMXModAccMeasurementLengthUnit)this.cboMeasUnit.SelectedItem;
                RFmxOBJ.measurementOffset = Convert.ToInt32(this.numMeasOffset.Value);
                RFmxOBJ.measurementLength = Convert.ToInt32(this.numMeasLength.Value);

                RFmxOBJ.evmUnit = (RFmx.NRMX.RFmxNRMXModAccEvmUnit)this.cboEVMUnit.SelectedItem;

                RFmxOBJ.timeout = 10.0; // (s)

                //Instrument Open Session
                RFmxOBJ.InitializeInstr();

                //Load Complex File
                RIWave = RFmxOBJ.ConvertComplexSingleToNiComplexWaveformFormat(RIData, (Convert.ToDouble(this.numSampleRate.Value) * 1e6));

                RFmxOBJ.ConfigureNR(RIWave);

                RFmxOBJ.RetrieveResults();

                MessageBox.Show("EVM = " + RFmxOBJ.meanRmsCompositeEvm);

                RFmxOBJ.PrintResults();

                CreateDataSet();

                if (chkConstellation.Checked == true)
                {
                    ComplexSingle[] Cont = RFmxOBJ.dataConstellation;

                    //WriteFile(Cont, "C:\\Users\\cdma_gsm\\Downloads\\RFmx2.5_Demod_DEV\\ConstellationFile_data.txt", FileMode.OpenOrCreate);

                    ComplexSingle[] dmrsCont = RFmxOBJ.dmrsDataConstellation;

                    double[] evmMax = RFmxOBJ.evmMaxPerSubcarrier.GetScaledData();

                    Console.WriteLine("EVM Max Subcarrier: " + evmMax.Max());
                    //WriteFile(dmrsCont, "C:\\Users\\cdma_gsm\\Downloads\\RFmx2.5_Demod_DEV\\ConstellationFile_dmrs.txt", FileMode.OpenOrCreate);

                    //Plot Constellation
                    Constellation frmChart = new Constellation();

                    actionDone = false; this.Refresh();
                    Parallel.Invoke(() => SpinProgressBar(), () => frmChart.LoadQAMChart(Cont, dmrsCont, RFmxOBJ.meanRmsCompositeEvm));
                    //frmChart.LoadQAMChart(Cont, dmrsCont);

                    actionDone = false; this.Refresh();
                    Parallel.Invoke(() => SpinProgressBar(), () => frmChart.LoadSubCarrierChart(evmMax));
                    //frmChart.LoadSubCarrierChart(evmMax);

                    frmChart.ShowDialog();
                }
            }
            catch (Exception ex)
            {
                RFmxOBJ.DisplayError(ex);
            }
            finally
            {
                /* Close session */
                RFmxOBJ.CloseSession();
            }
            long testTime = sw.ElapsedMilliseconds;
            MessageBox.Show("TestTime: " + testTime.ToString() + " mS");
        }

        internal void CreateDataSet()
        {
            Dictionary<string, string> dicEVMData = new Dictionary<string, string>();

            SetupDataGridView();

            dicEVMData.Add("FileName", fName);
            dicEVMData.Add("ArrayCount", RIData.LongCount().ToString());
            dicEVMData.Add("meanRmsCompositeEvm", RFmxOBJ.meanRmsCompositeEvm.ToString());
            dicEVMData.Add("maximumPeakCompositeEvm", RFmxOBJ.maximumPeakCompositeEvm.ToString());
            dicEVMData.Add("meanFrequencyError", RFmxOBJ.meanFrequencyError.ToString());
            dicEVMData.Add("peakCompositeEvmSlotIndex", RFmxOBJ.peakCompositeEvmSlotIndex.ToString());
            dicEVMData.Add("peakCompositeEvmSymbolIndex", RFmxOBJ.peakCompositeEvmSymbolIndex.ToString());
            dicEVMData.Add("peakCompositeEvmSubcarrierIndex", RFmxOBJ.peakCompositeEvmSubcarrierIndex.ToString());
            dicEVMData.Add("meanIQOriginOffset", RFmxOBJ.meanIQOriginOffset.ToString());
            dicEVMData.Add("meanIQGainImbalance", RFmxOBJ.meanIQGainImbalance.ToString());
            dicEVMData.Add("meanIQQuadratureError", RFmxOBJ.meanIQQuadratureError.ToString());

            foreach (string str in dicEVMData.Keys)
            {
                string[] arrTempEVM = { str, dicEVMData[str] };
                this.dgvEVMData.Rows.Add(arrTempEVM);

            }
        }

        private void SetupDataGridView()
        {
            this.dgvEVMData.SelectAll();
            this.dgvEVMData.ClearSelection();
            this.dgvEVMData.Refresh();

            dgvEVMData.ColumnCount = 3;

            dgvEVMData.ColumnHeadersDefaultCellStyle.BackColor = Color.Navy;
            dgvEVMData.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvEVMData.ColumnHeadersDefaultCellStyle.Font =
                new Font(dgvEVMData.Font, FontStyle.Bold);

            dgvEVMData.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
            dgvEVMData.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dgvEVMData.CellBorderStyle = DataGridViewCellBorderStyle.Single;
            dgvEVMData.GridColor = Color.Black;
            dgvEVMData.RowHeadersVisible = false;

            dgvEVMData.Columns[0].Name = "Parameter";
            dgvEVMData.Columns[1].Name = "Value";
            dgvEVMData.Columns[2].Name = "Description";
        }


        static void WriteFile(ComplexSingle[] values, string path, FileMode filemode)
        {
            using (FileStream fs = new FileStream(path, filemode, FileAccess.ReadWrite))
            {
                using (StreamWriter bw = new StreamWriter(fs, Encoding.Default))
                {
                    foreach (ComplexSingle value in values)
                    {
                        bw.WriteLine(value);
                    }
                }
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSaveData_Click(object sender, EventArgs e)
        {
            //this.dataSetEVM.WriteXml(@"C:\\DataSet_EVMDemod.txt");
            SaveData_ExcelFormat();
        }

        private void SaveData_ExcelFormat()
        {
            Excel.Application xlApp;
            Excel.Workbook xlWorkBook;
            Excel.Worksheet xlWorkSheet;
            object misValue = System.Reflection.Missing.Value;

            xlApp = new Excel.Application();
            xlApp.Visible = true;
            xlWorkBook = xlApp.Workbooks.Add(misValue);
            xlWorkSheet = (Excel.Worksheet)xlWorkBook.Worksheets.get_Item(1);
            int i = 0;
            int j = 0;

            for (i = 0; i <= dgvEVMData.RowCount - 1; i++)
            {
                for (j = 0; j <= dgvEVMData.ColumnCount - 1; j++)
                {
                    DataGridViewCell cell = dgvEVMData[j, i];
                    xlWorkSheet.Cells[i + 1, j + 1] = cell.Value;
                }
            }

            string strFileName = Path.GetFileNameWithoutExtension(fName);
            string strFilePath = Path.GetDirectoryName(fName);
            string strNewFullFileName = Path.Combine(strFilePath, strFileName) + "xls";

            DialogResult ret = MessageBox.Show("The data should have been pushed into an Excel book.\nDo you want to save this file as:\n" + strNewFullFileName, "Save File", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (ret == DialogResult.Yes && !File.Exists(strNewFullFileName))
            {
                xlWorkBook.SaveAs(strNewFullFileName, Excel.XlFileFormat.xlWorkbookNormal, misValue, misValue, misValue, misValue, Excel.XlSaveAsAccessMode.xlExclusive, misValue, misValue, misValue, misValue, misValue);
                xlWorkBook.Close(true, misValue, misValue);
                xlApp.Quit();
            }
            else if (File.Exists(strNewFullFileName))
            {
                MessageBox.Show("File already exists...save it yourself.");
            }

            releaseObject(xlWorkSheet);
            releaseObject(xlWorkBook);
            releaseObject(xlApp);
        }

        private void releaseObject(object obj)
        {
            try
            {
                System.Runtime.InteropServices.Marshal.ReleaseComObject(obj);
                obj = null;
            }
            catch (Exception ex)
            {
                obj = null;
                MessageBox.Show("Exception Occured while releasing object " + ex.ToString());
            }
            finally
            {
                GC.Collect();
            }
        }

        private void optComplex_CheckedChanged(object sender, EventArgs e)
        {
            this.optIQFiles.Checked = !this.optComplex.Checked;
        }

        private void optIQFiles_CheckedChanged(object sender, EventArgs e)
        {
            this.optComplex.Checked = !this.optIQFiles.Checked;
        }
    }
}
