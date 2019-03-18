namespace NationalInstruments.Examples.RFmxNRULModAccSingleCarrier
{
    partial class Constellation
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chrtConstellation = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chrtEVMperSubCarrier = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.lblEVMMAX = new System.Windows.Forms.Label();
            this.lblRMSMean = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chrtConstellation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chrtEVMperSubCarrier)).BeginInit();
            this.SuspendLayout();
            // 
            // chrtConstellation
            // 
            this.chrtConstellation.BackColor = System.Drawing.Color.LightGray;
            chartArea1.AxisX.Maximum = 1.5D;
            chartArea1.AxisX.Minimum = -1.5D;
            chartArea1.AxisY.Maximum = 1.5D;
            chartArea1.AxisY.Minimum = -1.5D;
            chartArea1.Name = "ChartArea1";
            this.chrtConstellation.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chrtConstellation.Legends.Add(legend1);
            this.chrtConstellation.Location = new System.Drawing.Point(24, 20);
            this.chrtConstellation.Name = "chrtConstellation";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
            series1.Legend = "Legend1";
            series1.MarkerBorderColor = System.Drawing.Color.Blue;
            series1.MarkerColor = System.Drawing.Color.DodgerBlue;
            series1.MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Circle;
            series1.Name = "DATA";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
            series2.Legend = "Legend1";
            series2.MarkerBorderColor = System.Drawing.Color.Sienna;
            series2.MarkerColor = System.Drawing.Color.DarkOrange;
            series2.MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Circle;
            series2.Name = "DMRS";
            this.chrtConstellation.Series.Add(series1);
            this.chrtConstellation.Series.Add(series2);
            this.chrtConstellation.Size = new System.Drawing.Size(684, 608);
            this.chrtConstellation.TabIndex = 0;
            this.chrtConstellation.Text = "Constellation";
            // 
            // chrtEVMperSubCarrier
            // 
            this.chrtEVMperSubCarrier.BackColor = System.Drawing.Color.LightGray;
            chartArea2.AxisX.Interval = 1D;
            chartArea2.AxisX.MajorGrid.Interval = 0D;
            chartArea2.AxisX.MajorTickMark.Enabled = false;
            chartArea2.AxisX.Minimum = 0D;
            chartArea2.Name = "ChartArea1";
            this.chrtEVMperSubCarrier.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chrtEVMperSubCarrier.Legends.Add(legend2);
            this.chrtEVMperSubCarrier.Location = new System.Drawing.Point(24, 627);
            this.chrtEVMperSubCarrier.Name = "chrtEVMperSubCarrier";
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Area;
            series3.Legend = "Legend1";
            series3.Name = "EVM per Carrier";
            this.chrtEVMperSubCarrier.Series.Add(series3);
            this.chrtEVMperSubCarrier.Size = new System.Drawing.Size(684, 213);
            this.chrtEVMperSubCarrier.TabIndex = 1;
            this.chrtEVMperSubCarrier.Text = "MAX EVM";
            // 
            // lblEVMMAX
            // 
            this.lblEVMMAX.BackColor = System.Drawing.Color.LightGray;
            this.lblEVMMAX.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblEVMMAX.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEVMMAX.Location = new System.Drawing.Point(538, 791);
            this.lblEVMMAX.Name = "lblEVMMAX";
            this.lblEVMMAX.Size = new System.Drawing.Size(161, 16);
            this.lblEVMMAX.TabIndex = 2;
            this.lblEVMMAX.Text = "MAX = ";
            // 
            // lblRMSMean
            // 
            this.lblRMSMean.BackColor = System.Drawing.Color.LightGray;
            this.lblRMSMean.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblRMSMean.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRMSMean.Location = new System.Drawing.Point(580, 251);
            this.lblRMSMean.Name = "lblRMSMean";
            this.lblRMSMean.Size = new System.Drawing.Size(119, 18);
            this.lblRMSMean.TabIndex = 3;
            this.lblRMSMean.Text = "RMS Mean = ";
            // 
            // Constellation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(739, 852);
            this.Controls.Add(this.lblRMSMean);
            this.Controls.Add(this.lblEVMMAX);
            this.Controls.Add(this.chrtEVMperSubCarrier);
            this.Controls.Add(this.chrtConstellation);
            this.Name = "Constellation";
            this.Text = "Constellation";
            ((System.ComponentModel.ISupportInitialize)(this.chrtConstellation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chrtEVMperSubCarrier)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chrtConstellation;
        private System.Windows.Forms.DataVisualization.Charting.Chart chrtEVMperSubCarrier;
        private System.Windows.Forms.Label lblEVMMAX;
        private System.Windows.Forms.Label lblRMSMean;
    }
}