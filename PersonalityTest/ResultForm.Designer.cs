namespace PersonalityTest
{
    partial class ResultForm
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.ChartResult = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btClose = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ChartResult)).BeginInit();
            this.SuspendLayout();
            // 
            // ChartResult
            // 
            this.ChartResult.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea2.Name = "ChartArea1";
            this.ChartResult.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.ChartResult.Legends.Add(legend2);
            this.ChartResult.Location = new System.Drawing.Point(13, 13);
            this.ChartResult.Name = "ChartResult";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.ChartResult.Series.Add(series2);
            this.ChartResult.Size = new System.Drawing.Size(555, 495);
            this.ChartResult.TabIndex = 0;
            this.ChartResult.Text = "chart1";
            // 
            // btClose
            // 
            this.btClose.Location = new System.Drawing.Point(254, 514);
            this.btClose.Name = "btClose";
            this.btClose.Size = new System.Drawing.Size(75, 23);
            this.btClose.TabIndex = 1;
            this.btClose.Text = "Zamknij";
            this.btClose.UseVisualStyleBackColor = true;
            this.btClose.Click += new System.EventHandler(this.btClose_Click);
            // 
            // ResultForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(580, 549);
            this.Controls.Add(this.btClose);
            this.Controls.Add(this.ChartResult);
            this.Name = "ResultForm";
            this.Text = "ResultForm";
            ((System.ComponentModel.ISupportInitialize)(this.ChartResult)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart ChartResult;
        private System.Windows.Forms.Button btClose;
    }
}