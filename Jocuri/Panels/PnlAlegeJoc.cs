using Jocuri.Controllers;
using Jocuri.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Jocuri.Panels
{
    internal class PnlAlegeJoc:Panel
    {
        Form1 form;
        Utilizator utilizator;

        private System.Windows.Forms.Label lblNume;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart;
        private System.Windows.Forms.Button btnTestMemorie;
        private System.Windows.Forms.Button btnQR;
        private System.Windows.Forms.Button btnPopice;

        ControllerRezultate controllerRezultate;
        List<Rezultat> listTestMemorie;
        List<Rezultat> listPopice;
        public PnlAlegeJoc(Form1 form1, Utilizator utilizator1)
        {

            form = form1;
            utilizator = utilizator1;
            controllerRezultate = new ControllerRezultate();
            this.form.Size = new System.Drawing.Size(886, 481);
            this.form.MaximumSize = new System.Drawing.Size(886, 510);
            this.form.MinimumSize = new System.Drawing.Size(886, 510);
            listPopice = new List<Rezultat>();
            listTestMemorie = new List<Rezultat>();

            //PnlAlegeJoc
            this.Size = new System.Drawing.Size(886, 510);
            this.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));            this.Name = "PnlAlegeJoc";
            this.Name = "PnlAlegeJoc";

            ChartArea chartArea1 = new ChartArea();
            Legend legend1 = new Legend();
            Series series1 = new Series();
            Series series2 = new Series();
            this.lblNume = new System.Windows.Forms.Label();
            this.chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btnTestMemorie = new System.Windows.Forms.Button();
            this.btnQR = new System.Windows.Forms.Button();
            this.btnPopice = new System.Windows.Forms.Button();

                        
            this.Controls.Add(this.btnPopice);
            this.Controls.Add(this.btnQR);
            this.Controls.Add(this.btnTestMemorie);
            this.Controls.Add(this.chart);
            this.Controls.Add(this.lblNume);



            // lblNume
            this.lblNume.AutoSize = true;
            this.lblNume.Location = new System.Drawing.Point(259, 9);
            this.lblNume.Name = "lblNume";
            this.lblNume.Size = new System.Drawing.Size(121, 27);
            this.lblNume.TabIndex = 0;
            this.lblNume.Text = "Bine ai venit";
             
            // chart
            chartArea1.Name = "ChartArea1";
            this.chart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart.Legends.Add(legend1);
            this.chart.Location = new System.Drawing.Point(28, 71);
            this.chart.Name = "chart";
            this.chart.Series.Add(series1);
            this.chart.Series.Add(series2);
            this.chart.Size = new System.Drawing.Size(831, 267);
            this.chart.Text = "chart1";
           // chart.ChartAreas[0].AxisX.Interval = 1;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = SeriesChartType.Line;
            series1.Legend = "Legend1";
            series1.LegendText = "Test Memorie";
            series1.Name = "Series1";
            series1.XValueType = ChartValueType.DateTime;

            series2.ChartArea = "ChartArea1";
            series2.ChartType = SeriesChartType.Line;
            series2.Legend = "Legend1";
            series2.LegendText = "Popice Cu Litere";
            series2.Name = "Series2";
            series2.XValueType = ChartValueType.DateTime;

            listTestMemorie = controllerRezultate.getTestMemorie(utilizator.getId());
            listPopice = controllerRezultate.getPopice(utilizator.getId());

            for (int i = 0; i < listTestMemorie.Count; i++)
            {
                chart.Series["Series1"].Points.AddXY(listTestMemorie[i].getData(), listTestMemorie[i].getpunctaj());

            }

            for (int i = 0; i < listPopice.Count; i++)
            {
                chart.Series["Series2"].Points.AddXY(listPopice[i].getData(), listPopice[i].getpunctaj());

            }

            // btnTestMemorie
            this.btnTestMemorie.Location = new System.Drawing.Point(116, 385);
            this.btnTestMemorie.Name = "btnTestMemorie";
            this.btnTestMemorie.Size = new System.Drawing.Size(191, 65);
            this.btnTestMemorie.Text = "Testeaza Memoria";
            this.btnTestMemorie.Click += new EventHandler(btnTestMemorie_Click);
             
            // btnQR
            this.btnQR.Location = new System.Drawing.Point(553, 385);
            this.btnQR.Name = "btnQR";
            this.btnQR.Size = new System.Drawing.Size(191, 65);
            this.btnQR.Text = "Gaseste Prim QR";
             
            // btnPopice
            this.btnPopice.Location = new System.Drawing.Point(335, 385);
            this.btnPopice.Name = "btnPopice";
            this.btnPopice.Size = new System.Drawing.Size(191, 65);
            this.btnPopice.Text = "Popice cu litere";
            this.btnPopice.Click += new EventHandler(btnPopice_Click);
            
        }

        private void btnTestMemorie_Click(object sender, EventArgs e)
        {

            this.form.removepnl("PnlAlegeJoc");
            this.form.Controls.Add(new PnlTestMemorie(form, utilizator, 3,1));


        }
        private void btnPopice_Click(object sender, EventArgs e)
        {

            this.form.removepnl("PnlAlegeJoc");
            this.form.Controls.Add(new PnlPopice(form, utilizator));

        }

    }
}
