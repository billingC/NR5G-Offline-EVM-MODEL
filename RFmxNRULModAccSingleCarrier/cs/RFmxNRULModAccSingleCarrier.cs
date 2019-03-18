//Steps:
//1. Open a new RFmx Session.
//2. Configure Frequency Reference.
//3. Configure basic signal properties(Center Frequency, Reference Level and External Attenuation).
//4. Configure Trigger Type and Trigger Parameters.
//5. Configure Carrier Bandwidth, Cell ID, Band and BWP Subcarrier Spacing.
//6. Configure PUSCH Number of RB Clusters and Modulation Type.
//7. Configure PUSCH RB Offset and Number of RBs.
//8. Configure PUSCH Slot Allocation, Symbol Allocation and Transform Precoding Enabled.
//9. Configure PUSCH DMRS properties(Power, Configuration Type, Type A Position, Duration and Additional Positions).
//10. Select ModAcc measurement and enable Traces.
//11. Configure Averaging Parameters for ModAcc measurement.
//12. Configure Measurement Interval.
//13. Initiate the Measurement.
//14.Fetch ModAcc Measurements and Traces.
//15. Close RFmx Session.

using System;
using System.Collections.Generic;
using NationalInstruments.RFmx.InstrMX;
using NationalInstruments.RFmx.NRMX;
using System.Threading;
using System.IO;

namespace NationalInstruments.Examples.RFmxNRULModAccSingleCarrier
{
   public class RFmxNRULModAccSingleCarrier
   {
        RFmxInstrMX instrSession;
        RFmxNRMX NR;
        IQTraceDataFFT traceData;
        ComplexSingle[] RIData = null;

        string rfsaResourceName = "VST2";

        const int NumberOfSubblocks = 1;
        string subblockString = "";
        string carrierString = "";
        string puschClusterString = "";

        string frequencyReferenceSource;
        double frequencyReferenceFrequency;

        double centerFrequency;
        double referenceLevel;
        double externalAttenuation;

        bool enableTrigger;
        string digitalEdgeSource;
        RFmxNRMXDigitalEdgeTriggerEdge digitalEdge;
        double triggerDelay;

        public double componentCarrierBandwidth;
        public int cellID;
        public double subcarrierSpacing;
        public int band;

        //
        public frmRFmxSettings.RFmxDuplexMode duplexScheme = frmRFmxSettings.RFmxDuplexMode.FDD;
        public RFmxNRMXPuschTransformPrecodingEnabled puschTransformPrecodingEnabled = RFmxNRMXPuschTransformPrecodingEnabled.False;
        public int puschNumberOfRBClusters = 1;
        public int puschRBOffset = 0;
        public int puschNumberOfRBs = -1;
        public RFmxNRMXPuschModulationType puschModulationType = RFmxNRMXPuschModulationType.Qam256;
        public string puschSlotAllocation;
        public string puschSymbolAllocation;

        public int puschDmrsPower;
        public RFmxNRMXPuschDmrsConfigurationType puschDmrsConfigurationType;
        public RFmxNRMXPuschMappingType puschDmrsMappingType;
        public int intPuschDmrsTypeAPosition = 2;
        public RFmxNRMXPuschDmrsDuration puschDmrsDuration;
        //public RFmxNRMXPuschDmrsAdditionalPositions puschDmrsAdditionalPositions;

        public RFmxNRMXModAccAveragingEnabled averagingEnabled;
        public int averagingCount;

        public RFmxNRMXModAccMeasurementLengthUnit measurementLengthUnit;
        public int measurementOffset;
        public int measurementLength;

        public RFmxNRMXModAccEvmUnit evmUnit;
        public RFmxNRMXLinkDirection lnkDirection;
        public double timeout;                                                            /* (s) */
        public int peakCompositeEvmSubcarrierIndex;
        public int peakCompositeEvmSymbolIndex;
        public int peakCompositeEvmSlotIndex;
        public double meanRmsCompositeEvm;                                                /* (%) */
        public double maximumPeakCompositeEvm;                                            /* (%) */
        public double meanFrequencyError;                                                 /* (Hz) */
        public double meanIQOriginOffset;                                                 /* (dBc) */
        public double meanIQGainImbalance;                                                /* (dB) */
        public double meanIQQuadratureError;                                              /* (deg) */
        public double inBandEmissionMargin;                                               /* (dB) */
        public ComplexSingle[] dataConstellation, dmrsDataConstellation;
        public AnalogWaveform<float> evmPerSubcarrier;
        public AnalogWaveform<float> evmMaxPerSubcarrier;
        public Spectrum<float> spectralFlatness;
        public Spectrum<float> spectralFlatnessLowerMask;
        public Spectrum<float> spectralFlatnessUpperMask;

        public void CloseSession()
        {
            if (NR != null)
            {
            NR.Dispose();
            NR = null;
            }
            if (instrSession != null)
            {
            instrSession.Close();
            instrSession = null;
            }
        }

        public void Run()
      {
         try
         {
            //InitializeVariables();
            //InitializeInstr();
            //ConfigureNR();
            //RetrieveResults();
            //PrintResults();
         }
         catch (Exception ex)
         {
            DisplayError(ex);
         }
         finally
         {
            /* Close session */
            CloseSession();
            Console.WriteLine("Press any key to exit");
            Console.ReadKey();
         }
      }

        public void InitializeInstr()
        {
            instrSession = new RFmxInstrMX("", "AnalysisOnly=1");  // takes 10ms, move out of here
            //instrSession = new RFmxInstrMX(rfsaResourceName, "");
        }

        public ComplexSingle[] LoadIQFiles(string rFileName, string iFileName)
        {
            List<string> lstRel = new List<string>();
            using (StreamReader rdFile = new StreamReader(rFileName))
            {
                string strtemp = "";
                while ((strtemp = rdFile.ReadLine()) != null)
                {
                    lstRel.Add(strtemp.Trim());
                }
                rdFile.Close();
            }

            List<string> lstImg = new List<string>();
            using (StreamReader rdFile = new StreamReader(iFileName))
            {
                string strtemp = "";
                while ((strtemp = rdFile.ReadLine()) != null)
                {
                    lstImg.Add(strtemp.Trim());
                }
                rdFile.Close();
            }

            ComplexSingle[] temp = new ComplexSingle[lstRel.Count];
            ComplexSingle cs;
            string buildComplex = "";
            bool success = false;
            double dblImg = 0;
            for (int x = 0; x < lstRel.Count; x++)
            {
                success = Double.TryParse(lstImg[x], out dblImg);

                if (dblImg >= 0)
                    buildComplex = lstRel[x] + "+" + lstImg[x] + "i";
                else
                    buildComplex = lstRel[x] + lstImg[x] + "i";

                success = ComplexSingle.TryParse(buildComplex, out cs);
                if (success)
                    temp[x] = cs;
                else
                    Console.WriteLine("ComplexSingle TryParse FAILED");
            }

            //frmRFmxSettings.fileThreadFlag.Set();

            Console.WriteLine("Real/ Imag files loaded...\n" + rFileName + "\n" + iFileName + "\nArray Count = " + temp.LongLength);
            return temp;
        }

        public ComplexSingle[] LoadComplexFile(string riFileName)
        {
            List<string> lstRI = new List<string>();
            using (StreamReader rdFile = new StreamReader(riFileName))
            {
                string strtemp = "";
                while ((strtemp = rdFile.ReadLine()) != null)
                {
                    lstRI.Add(strtemp);
                }
                rdFile.Close();
            }

            ComplexSingle[] temp = new ComplexSingle[lstRI.Count];
            ComplexSingle cs;
            bool success = false;
            for (int x = 0; x < lstRI.Count; x++)
            {
                success = ComplexSingle.TryParse(lstRI[x], out cs);
                if (success)
                    temp[x] = cs;
                else
                    Console.WriteLine("ComplexSingle TryParse FAILED");
            }

            //frmRFmxSettings.fileThreadFlag.Set();

            Console.WriteLine("RI file loaded...\n" + riFileName + "\nArray Count = " + temp.LongLength);
            return temp;
        }

        public void InitializeVariables()
      {
            rfsaResourceName = "VST2";

            frequencyReferenceSource = RFmxInstrMXConstants.OnboardClock;
            frequencyReferenceFrequency = 10e6;                                     /* (Hz) */

            centerFrequency = 1.0e9;                                               /* (Hz) */
            referenceLevel = 0.00;                                                  /* (dBm) */
            externalAttenuation = 0.0;                                              /* (dB) */

            enableTrigger = true;
            digitalEdgeSource = RFmxNRMXConstants.PxiTriggerLine2;
            digitalEdge = RFmxNRMXDigitalEdgeTriggerEdge.Rising;
            triggerDelay = 0.0;                                                     /* (s) */

            //componentCarrierBandwidth = 100e6;                                       /* (Hz) */
            //cellID = 0;
            //subcarrierSpacing = 30e3;                                               /* (Hz) */
            //band = 78;

            //puschTransformPrecodingEnabled = RFmxNRMXPuschTransformPrecodingEnabled.False;
            //puschNumberOfRBClusters = 1;
            //puschRBOffset = 0;
            //puschNumberOfRBs = -1;
            //puschModulationType = RFmxNRMXPuschModulationType.Qam256;
            //puschSlotAllocation = "0-Last";
            //puschSymbolAllocation = "0-Last";

            //puschDmrsPower = 0;                                                     /* (dB) */
            //puschDmrsConfigurationType = RFmxNRMXPuschDmrsConfigurationType.Type1;
            //puschDmrsTypeAPosition = RFmxNRMXPuschDmrsTypeAPosition.Position2;
            //puschDmrsDuration = RFmxNRMXPuschDmrsDuration.SingleSymbol;
            //puschDmrsAdditionalPositions = RFmxNRMXPuschDmrsAdditionalPositions.AdditionalPositions0;

            //averagingEnabled = RFmxNRMXModAccAveragingEnabled.False;
            //averagingCount = 10;

            //measurementLengthUnit = RFmxNRMXModAccMeasurementLengthUnit.Slot;
            //measurementOffset = 0;
            //measurementLength = 1;

            //timeout = 10.0;                                                         /* (s) */
        }

        public void ConfigureNR(ComplexWaveform<ComplexSingle> niFormattedData)
      {
            NR = instrSession.GetNRSignalConfiguration();     /* Create a new RFmx Session */
            instrSession.ConfigureRFAttenuation("", RFmxInstrMXRFAttenuationAuto.True, 20);
            instrSession.ConfigureFrequencyReference("", RFmxInstrMXConstants.OnboardClock, 10e6);
            //instrSession.SetTriggerExportOutputTerminal("", "");
            NR.ConfigureDigitalEdgeTrigger("", "PXI_Trig2", RFmxNRMXDigitalEdgeTriggerEdge.Rising, 0, true);
            NR.SelectMeasurements("", RFmxNRMXMeasurementTypes.ModAcc, true);
            NR.ModAcc.Configuration.SetMeasurementEnabled("", true);
            NR.ModAcc.Configuration.SetAveragingEnabled("", averagingEnabled);
            NR.ModAcc.Configuration.SetAveragingCount("", averagingCount);

            NR.SetLinkDirection("", RFmxNRMXLinkDirection.Uplink);
            
			NR.ComponentCarrier.SetBandwidth("", componentCarrierBandwidth);
            //int maxRBs = 0, offsetRBs = 0;
            //NR.ComponentCarrier.GetPuschResourceBlockOffset("", out offsetRBs);
            //NR.ComponentCarrier.GetPuschNumberOfResourceBlocks("", out maxRBs);
            NR.ComponentCarrier.SetCellID("", cellID);
            NR.SetBand("", band);
            NR.ComponentCarrier.SetBandwidthPartSubcarrierSpacing("", subcarrierSpacing);

            NR.SetAutoResourceBlockDetectionEnabled("", RFmxNRMXAutoResourceBlockDetectionEnabled.False);

            NR.ComponentCarrier.SetPuschNumberOfResourceBlockClusters("", puschNumberOfRBClusters);
            NR.ComponentCarrier.SetPuschModulationType("", puschModulationType);
            //NR.ComponentCarrier.SetResourceBlockAlignmentMode("", RFmxNRMXResourceBlockAlignmentMode.Disabled);
            for (int i = 0; i < NumberOfSubblocks; i++)
            {
                subblockString = RFmxNRMX.BuildSubblockString("", 0);
                carrierString = RFmxNRMX.BuildCarrierString(subblockString, 0);
                puschClusterString = RFmxNRMX.BuildPuschClusterString(carrierString, i);
                NR.ComponentCarrier.SetPuschResourceBlockOffset(puschClusterString, puschRBOffset);
                NR.ComponentCarrier.SetPuschNumberOfResourceBlocks(puschClusterString, puschNumberOfRBs);
            }

            NR.ComponentCarrier.SetPuschSlotAllocation("", puschSlotAllocation);
            NR.ComponentCarrier.SetPuschSymbolAllocation("", puschSymbolAllocation);
            NR.ComponentCarrier.SetPuschTransformPrecodingEnabled("", puschTransformPrecodingEnabled);
            NR.ComponentCarrier.SetPuschMappingType("", puschDmrsMappingType);
            //NR.ComponentCarrier.SetPssPower.puschDmrsPower();
            NR.ComponentCarrier.SetPuschDmrsScramblingID("", 0);
            NR.ComponentCarrier.SetPuschDmrsScramblingIDMode("", RFmxNRMXPuschDmrsScramblingIDMode.CellID);

            NR.ComponentCarrier.SetPuschDmrsPuschID("", 0);
            NR.ComponentCarrier.SetPuschDmrsPuschIDMode("", RFmxNRMXPuschDmrsPuschIDMode.CellID);

            NR.ComponentCarrier.SetPuschDmrsPower("", puschDmrsPower);
            NR.ComponentCarrier.SetPuschDmrsConfigurationType("", puschDmrsConfigurationType);
            NR.ComponentCarrier.SetPuschDmrsTypeAPosition("", intPuschDmrsTypeAPosition);
            NR.ComponentCarrier.SetPuschDmrsDuration("", puschDmrsDuration);
            NR.ComponentCarrier.SetPuschDmrsAdditionalPositions("", 0);

            //NR.ModAcc.Configuration.SetFftWindowLength("", 10e-3);

            if (this.duplexScheme == frmRFmxSettings.RFmxDuplexMode.TDD)
            {
                NR.ModAcc.Configuration.SetMeasurementLengthUnit("", RFmxNRMXModAccMeasurementLengthUnit.Time);
                NR.ModAcc.Configuration.SetMeasurementOffset("", 0);
                NR.ModAcc.Configuration.SetMeasurementLength("", 1e-3);
            }
            else
            {
                NR.ModAcc.Configuration.SetMeasurementLengthUnit("", measurementLengthUnit);
                NR.ModAcc.Configuration.SetMeasurementOffset("", measurementOffset);
                NR.ModAcc.Configuration.SetMeasurementLength("", measurementLength);
            }

            NR.ModAcc.Configuration.SetEvmUnit("", evmUnit);

            //NR.ModAcc.Configuration.SetSynchronizationMode("", RFmxNRMXModAccSynchronizationMode.HalfSubframe);
            //NR.Initiate("", "");

            NR.Commit("");

            #region Run Analysis

            bool averagingDone;

            double recommendedPreTriggerTime;

            RFmxInstrMXRecommendedAcquisitionType recType;
            instrSession.GetRecommendedAcquisitionType("", out recType);
            double acquisitionTime;
            instrSession.GetRecommendedIQAcquisitionTime("", out acquisitionTime);
            int numberOfRecords;
            instrSession.GetRecommendedNumberOfRecords("", out numberOfRecords);
            //instrSession.GetRecommendedSpectralAcquisitionSpan("", out spectralAcquisitionSpan);
            double minimumSampleRate;
            instrSession.GetRecommendedIQMinimumSampleRate("", out minimumSampleRate);
            instrSession.GetRecommendedIQPreTriggerTime("", out recommendedPreTriggerTime);

            Console.WriteLine("Rec pre-trigger time = " + recommendedPreTriggerTime.ToString());

            //ComplexWaveform<ComplexSingle> niFormattedData;

            //if (!RIFileType)
            //    niFormattedData = ConvertIqDataToNiComplexFormat(traceData);
            //else
            //    niFormattedData = RIData;

            #endregion Run Analysis

            ///AnalyzeIQ reset must be true for for last or single AnalyzeIQ call. 
            ///Note: averaging in offline mode is done in MXA (IQ data in this module has been averaged).
            NR.AnalyzeIQ("", "", niFormattedData, true, out averagingDone);
            //int err = NR.Initiate("", "");
            NR.WaitForMeasurementComplete("", 10);
        }

        public ComplexWaveform<ComplexSingle> ConvertComplexSingleToNiComplexWaveformFormat(ComplexSingle[] data, double sRate)
        {
            double absoluteInitialX = 0;  // -0.000005;
            double IQmag = 0, IQmax = 0;
            double[] arrMag = new double[data.Length];
            ComplexWaveform<ComplexSingle> target = new ComplexWaveform<ComplexSingle>(data.Length);
            var targetBuffer = target.GetWritableBuffer();
            for (int i = 0; i < data.Length; i++)
            {
                targetBuffer[i] = new ComplexSingle(data[i].Real, data[i].Imaginary);
                IQmag = Math.Sqrt(Math.Pow(data[i].Real, 2) + Math.Pow(data[i].Imaginary, 2));
                arrMag[i] = IQmag;
                if (IQmag > 1.0)
                {
                    Console.WriteLine("IQmag = " + IQmag.ToString() + "\nArrayElement = " + i.ToString());
                    if (IQmag > IQmax) IQmax = IQmag;
                }
            }
            target.PrecisionTiming = PrecisionWaveformTiming.CreateWithRegularInterval(
                new PrecisionTimeSpan(1.0 / sRate),
                new PrecisionTimeSpan(absoluteInitialX));

            Console.WriteLine("IQmax = " + IQmax.ToString());

            return target;
        }

        public void RetrieveResults()
        {
            NR.ModAcc.Results.GetCompositePeakEvmSubcarrierIndex("", out peakCompositeEvmSubcarrierIndex);
            NR.ModAcc.Results.GetCompositePeakEvmSymbolIndex("", out peakCompositeEvmSymbolIndex);
            NR.ModAcc.Results.GetCompositeRmsEvmMean("", out meanRmsCompositeEvm);
            NR.ModAcc.Results.GetCompositePeakEvmMaximum("", out maximumPeakCompositeEvm);
            NR.ModAcc.Results.GetCompositePeakEvmSlotIndex("", out peakCompositeEvmSlotIndex);

            NR.ModAcc.Results.GetComponentCarrierFrequencyErrorMean("", out meanFrequencyError);
            NR.ModAcc.Results.GetComponentCarrierIQOriginOffsetMean("", out meanIQOriginOffset);
            NR.ModAcc.Results.GetComponentCarrierIQGainImbalanceMean("", out meanIQGainImbalance);
            NR.ModAcc.Results.GetComponentCarrierQuadratureErrorMean("", out meanIQQuadratureError);
            NR.ModAcc.Results.GetInBandEmissionMargin("", out inBandEmissionMargin);
            NR.ModAcc.Results.FetchPuschDataConstellationTrace("", timeout, ref dataConstellation);
            NR.ModAcc.Results.FetchPuschDmrsConstellationTrace("", timeout, ref dmrsDataConstellation);
            NR.ModAcc.Results.FetchRmsEvmPerSubcarrierMeanTrace("", timeout, ref evmPerSubcarrier);
            NR.ModAcc.Results.FetchPeakEvmPerSubcarrierMaximumTrace("", timeout, ref evmMaxPerSubcarrier);
            NR.ModAcc.Results.FetchSpectralFlatnessTrace("", timeout, ref spectralFlatness, ref spectralFlatnessLowerMask,
            ref spectralFlatnessUpperMask);
        }

        public void PrintResults()
      {
         Console.WriteLine("------------------Measurement------------------");
         Console.WriteLine("Mean RMS Composite EVM  (%)             : {0}", meanRmsCompositeEvm);
         Console.WriteLine("Max Peak Composite EVM  (%)             : {0}", maximumPeakCompositeEvm);
         Console.WriteLine("Peak Composite EVM Slot Index           : {0}", peakCompositeEvmSlotIndex);
         Console.WriteLine("Peak Composite EVM Symbol Index         : {0}", peakCompositeEvmSymbolIndex);
         Console.WriteLine("Peak Composite EVM Subcarrier Index     : {0}", peakCompositeEvmSubcarrierIndex);
         Console.WriteLine("Mean Frequency Error  (Hz)              : {0}", meanFrequencyError);
         Console.WriteLine("Mean IQ Origin Offset  (dBc)            : {0}", meanIQOriginOffset);
         Console.WriteLine("Mean IQ Gain Imbalance  (dB)            : {0}", meanIQGainImbalance);
         Console.WriteLine("Mean IQ Quadrature Error  (deg)         : {0}", meanIQQuadratureError);
         Console.WriteLine("In-Band Emission Margin (dB)            : {0}", inBandEmissionMargin);
      }

        public void DisplayError(Exception ex)
      {
         Console.WriteLine("ERROR:\n" + ex.GetType() + ": " + ex.Message);
      }

   }
    public partial class IQTraceDataFFT
    {
        public double freq;
        public double freqOffset;
        public double SampleRate;
        public double SweepTime;
        public double FirstTimeDomainPoint;
        public double[] Iarray;
        public double[] Qarray;
        public double[] IQmagArray;
        public double[] IQRawInterleavedArray;
        public double PoutDbm;
        public double iqMeanPwr_Meas;
        public double iqPkPwr_Meas;
        public double iqPk2Mean_Meas;
    }

}
