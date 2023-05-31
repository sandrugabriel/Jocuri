using Jocuri.Models;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Jocuri.Panels
{
    internal class PnlCastigat : Panel
    {

        Form1 form;

        private System.Windows.Forms.Label lblTitlu;
        private System.Windows.Forms.Label lblTitlu1;
        private System.Windows.Forms.PictureBox pct6;
        private System.Windows.Forms.PictureBox pct1;
        private System.Windows.Forms.PictureBox pct2;
        private System.Windows.Forms.PictureBox pct3;
        private System.Windows.Forms.PictureBox pct4;
        private System.Windows.Forms.PictureBox pct5;
        private int timp;

        Timer timer;

        List<PictureBox> pictureBoxes;

        Utilizator utilizator;

        public PnlCastigat(Form1 form1,Utilizator utilizator1) {

            form = form1;
            this.form.Size = new System.Drawing.Size(673, 457);
            this.form.MaximumSize = new System.Drawing.Size(673, 457);
            this.form.MinimumSize = new System.Drawing.Size(673, 457);
            timer = new Timer();
            utilizator = utilizator1;
            timp = 01;
            //PnlCastigat
            this.BackColor = System.Drawing.Color.MediumAquamarine;
            this.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 12F, System.Drawing.FontStyle.Regular);
            this.Name = "PnlCastigat";
            this.Size = new System.Drawing.Size(673, 457);

            this.lblTitlu = new System.Windows.Forms.Label();
            this.lblTitlu1 = new System.Windows.Forms.Label();
            this.pct6 = new System.Windows.Forms.PictureBox();
            this.pct1 = new System.Windows.Forms.PictureBox();
            this.pct2 = new System.Windows.Forms.PictureBox();
            this.pct3 = new System.Windows.Forms.PictureBox();
            this.pct4 = new System.Windows.Forms.PictureBox();
            this.pct5 = new System.Windows.Forms.PictureBox();

            this.Controls.Add(this.pct5);
            this.Controls.Add(this.pct4);
            this.Controls.Add(this.pct3);
            this.Controls.Add(this.pct2);
            this.Controls.Add(this.pct1);
            this.Controls.Add(this.pct6);
            this.Controls.Add(this.lblTitlu1);
            this.Controls.Add(this.lblTitlu);

            //timer
            this.timer.Interval = 65;
            this.timer.Start();
            this.timer.Tick += new EventHandler(timer_Tick);   

            // lblTitlu
            this.lblTitlu.AutoSize = true;
            this.lblTitlu.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 35F);
            this.lblTitlu.Location = new System.Drawing.Point(177, 105);
            this.lblTitlu.Name = "lblTitlu";
            this.lblTitlu.Size = new System.Drawing.Size(264, 78);
            this.lblTitlu.TabIndex = 0;
            this.lblTitlu.Text = "Felicitari!";

            // lblTitlu1
            this.lblTitlu1.AutoSize = true;
            this.lblTitlu1.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 35F);
            this.lblTitlu1.Location = new System.Drawing.Point(77, 220);
            this.lblTitlu1.Name = "lblTitlu1";
            this.lblTitlu1.Size = new System.Drawing.Size(464, 78);
            this.lblTitlu1.TabIndex = 1;
            this.lblTitlu1.Text = "Ai castigat jocul!";

            // pct6
            this.pct6.Location = new System.Drawing.Point(37, 88);
            this.pct6.Name = "pct6";
            this.pct6.Size = new System.Drawing.Size(95, 95);
            this.pct6.TabIndex = 2;
            this.pct6.TabStop = false;

            // pct1
            this.pct1.Location = new System.Drawing.Point(276, 7);
            this.pct1.Name = "pct1";
            this.pct1.Size = new System.Drawing.Size(95, 95);
            this.pct1.TabIndex = 3;
            this.pct1.TabStop = false;

            // pct2
            this.pct2.Location = new System.Drawing.Point(500, 105);
            this.pct2.Name = "pct2";
            this.pct2.Size = new System.Drawing.Size(95, 95);
            this.pct2.TabIndex = 4;
            this.pct2.TabStop = false;

            // pct3
            this.pct3.Location = new System.Drawing.Point(519, 315);
            this.pct3.Name = "pct3";
            this.pct3.Size = new System.Drawing.Size(95, 95);
            this.pct3.TabIndex = 5;
            this.pct3.TabStop = false;

            // pct4
            this.pct4.Location = new System.Drawing.Point(285, 350);
            this.pct4.Name = "pct4";
            this.pct4.Size = new System.Drawing.Size(95, 95);
            this.pct4.TabIndex = 6;
            this.pct4.TabStop = false;

            // pct5
            this.pct5.Location = new System.Drawing.Point(37, 301);
            this.pct5.Name = "pct5";
            this.pct5.Size = new System.Drawing.Size(95, 95);
            this.pct5.TabIndex = 7;
            this.pct5.TabStop = false;

            pictureBoxes = new List<PictureBox> { pct1, pct2, pct3, pct4, pct5, pct6 };
        }

        private void timer_Tick(object sender, EventArgs e)
        {


            foreach (PictureBox pictureBox in pictureBoxes)
            {
                if (timp <= 9)
                {
                    pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                    string path = Application.StartupPath + @"/Artificii/" + "artificie_0" + timp + ".png";
                    pictureBox.Image = Image.FromFile(path);
                }
                else
                {
                    pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                    string path = Application.StartupPath + @"/Artificii/" + "artificie_" + timp + ".png";
                    pictureBox.Image = Image.FromFile(path);

                }


            }

            timp++;
            if(timp > 33)
            {
                timer.Enabled = false;
                timer.Stop();
                this.form.removepnl("PnlCastigat");
                this.form.Controls.Add(new PnlAlegeJoc(form, utilizator));
            }
        }


    }
}
