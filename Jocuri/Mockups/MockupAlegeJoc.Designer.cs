namespace Jocuri.Mockups
{
    partial class MockupAlegeJoc
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
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint1 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(44925D, 12D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint2 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(44925D, 15D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint3 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(44925D, 20D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint4 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(44927D, 150D);
            this.lblNume = new System.Windows.Forms.Label();
            this.chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btnTestMemorie = new System.Windows.Forms.Button();
            this.btnQR = new System.Windows.Forms.Button();
            this.btnPopice = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.chart)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNume
            // 
            this.lblNume.AutoSize = true;
            this.lblNume.Location = new System.Drawing.Point(259, 9);
            this.lblNume.Name = "lblNume";
            this.lblNume.Size = new System.Drawing.Size(121, 27);
            this.lblNume.TabIndex = 0;
            this.lblNume.Text = "Bine ai venit";
            // 
            // chart
            // 
            chartArea1.Name = "ChartArea1";
            this.chart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart.Legends.Add(legend1);
            this.chart.Location = new System.Drawing.Point(25, 59);
            this.chart.Name = "chart";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            dataPoint1.Font = new System.Drawing.Font("Microsoft Sans Serif", 500F, System.Drawing.FontStyle.Bold);
            dataPoint1.LabelForeColor = System.Drawing.Color.DimGray;
            series1.Points.Add(dataPoint1);
            series1.Points.Add(dataPoint2);
            series1.Points.Add(dataPoint3);
            series1.Points.Add(dataPoint4);
            series1.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.DateTime;
            this.chart.Series.Add(series1);
            this.chart.Size = new System.Drawing.Size(832, 267);
            this.chart.TabIndex = 1;
            this.chart.Text = "chart1";
            // 
            // btnTestMemorie
            // 
            this.btnTestMemorie.Location = new System.Drawing.Point(116, 385);
            this.btnTestMemorie.Name = "btnTestMemorie";
            this.btnTestMemorie.Size = new System.Drawing.Size(191, 65);
            this.btnTestMemorie.TabIndex = 2;
            this.btnTestMemorie.Text = "Testeaza Memoria";
            this.btnTestMemorie.UseVisualStyleBackColor = true;
            // 
            // btnQR
            // 
            this.btnQR.Location = new System.Drawing.Point(553, 385);
            this.btnQR.Name = "btnQR";
            this.btnQR.Size = new System.Drawing.Size(191, 65);
            this.btnQR.TabIndex = 3;
            this.btnQR.Text = "Gaseste Prim QR";
            this.btnQR.UseVisualStyleBackColor = true;
            // 
            // btnPopice
            // 
            this.btnPopice.Location = new System.Drawing.Point(335, 385);
            this.btnPopice.Name = "btnPopice";
            this.btnPopice.Size = new System.Drawing.Size(191, 65);
            this.btnPopice.TabIndex = 4;
            this.btnPopice.Text = "Popice cu litere";
            this.btnPopice.UseVisualStyleBackColor = true;
            // 
            // MockupAlegeJoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(886, 481);
            this.Controls.Add(this.btnPopice);
            this.Controls.Add(this.btnQR);
            this.Controls.Add(this.btnTestMemorie);
            this.Controls.Add(this.chart);
            this.Controls.Add(this.lblNume);
            this.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "MockupAlegeJoc";
            this.Text = "MockupAlegeJoc";
            ((System.ComponentModel.ISupportInitialize)(this.chart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNume;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart;
        private System.Windows.Forms.Button btnTestMemorie;
        private System.Windows.Forms.Button btnQR;
        private System.Windows.Forms.Button btnPopice;
    }
}