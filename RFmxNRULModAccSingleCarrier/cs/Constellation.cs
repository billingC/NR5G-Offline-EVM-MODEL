using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace NationalInstruments.Examples.RFmxNRULModAccSingleCarrier
{
    public partial class Constellation : Form
    {
        public Constellation()
        {
            InitializeComponent();
        }

        public void LoadQAMChart(ComplexSingle[] riData, ComplexSingle[] dmrsData, double rmsEVM = 0)
        {
            Int32 div = 0;
            Int32 mod = 0;
            Int32[] mods = new Int32[999];

            for(int j = 0; j < mods.Count(); j++)
            {
                //mods[j] = Convert.ToInt32(Math.Pow(2, j + 1));
                mods[j] = j+1;

                Math.DivRem(riData.Count(), mods[j], out mod);

                //get highest mod
                if (mod == 0)
                {
                    double ratio = ((Convert.ToDouble(riData.LongCount()) / Convert.ToDouble(mods[j])) / Convert.ToDouble(riData.LongCount())) * 100;
                    if (ratio > 5)
                    {
                        div = mods[j];
                        Console.WriteLine("Divisor = " + div.ToString());
                    }
                    else
                        Console.WriteLine("Divisor = " + mods[j].ToString() + " ---NOT USED---Ratio = " + ratio.ToString() + " %");
                }
            }

            Console.WriteLine("Drawing DMRS");
            Single[] iData = new Single[Convert.ToInt32(dmrsData.LongCount())];
            Single[] qData = new Single[Convert.ToInt32(dmrsData.LongCount())];

            ComplexSingle.DecomposeArray(dmrsData, out iData, out qData);

            for (int x = 0; x < iData.LongCount(); x++)
            {
                this.chrtConstellation.Series["DMRS"].Points.AddXY(iData[x], qData[x]);
            }

            ComplexSingle[] newRIData = null;
            Single[] relData = null;
            Single[] imgData = null;

            if (div == 0)
            {
                newRIData = riData;
                relData = new Single[Convert.ToInt32(riData.LongCount())];
                imgData = new Single[Convert.ToInt32(riData.LongCount())];
            }
            else
            {
                newRIData = new ComplexSingle[Convert.ToInt32(riData.LongCount() / div)];
                for (int k = 0; k < Convert.ToInt32(riData.LongCount() / div); k++)
                {
                    newRIData[k] = riData[k * div];
                }
                relData = new Single[Convert.ToInt32(riData.LongCount() / div)];
                imgData = new Single[Convert.ToInt32(riData.LongCount() / div)];
            }

            ComplexSingle.DecomposeArray(newRIData, out relData, out imgData);
            Console.WriteLine("Charting..." + newRIData.LongCount().ToString() + " points!");
            Console.WriteLine("Drawing DATA Constellation");
            for (int x = 0; x < relData.LongCount(); x++)
            {
                this.chrtConstellation.Series["DATA"].Points.AddXY(relData[x], imgData[x]);
                //System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint1 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 0D);
                //series1.ChartArea = "ChartArea1";
                //series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
                //series1.Legend = "Legend1";
                //series1.Name = "DATA";
                //series1.Points.Add(dataPoint1);

                //this.chrtConstellation.Series.Add(series1);
            }

            this.lblRMSMean.Text = "RMS Mean = " + rmsEVM.ToString("#0.##0");
        }

        public void LoadSubCarrierChart(double[] evmData)
        {
            System.Windows.Forms.DataVisualization.Charting.Series series = this.chrtEVMperSubCarrier.Series["EVM per Carrier"];

            for (int x = 0; x < evmData.LongCount(); x++)
            {
                double dblTemp = Convert.ToDouble(evmData[x].ToString("#0.##0"));
                series.Points.AddXY(x, dblTemp);
            }

            this.lblEVMMAX.Text = "MAX = " + evmData.Max().ToString("#0.##0") + " @ " + Array.IndexOf(evmData, evmData.Max()) + " of " + evmData.LongCount().ToString();
        }

    }
}
