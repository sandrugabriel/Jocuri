using Jocuri.Controllers;
using Jocuri.Models;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Jocuri.Panels
{
    internal class PnlPopice:Panel
    {

        Form1 form;
        Utilizator utilizator1;

        private System.Windows.Forms.PictureBox pctBila;

        List<Image> images;
        List<string> listNumele;
        List<string> listLiterele;
        List<Label> listLabels;
        private int timp;

        Label lblImagine1;
        Label lblImagine2;

        Timer timerForm;

        private string cuv1;
        private string cuv2;

        private System.Windows.Forms.Label lblTimp;
        private System.Windows.Forms.Label lblLitere;
        private System.Windows.Forms.PictureBox pct1;
        private System.Windows.Forms.PictureBox pct2;

        ControllerRezultate controllerRezultate;


        public PnlPopice(Form1 form1, Utilizator utilizator)
        {
            form = form1;
            utilizator1 = utilizator;
            timp = 100;
            images = new List<Image>();
            listLiterele = new List<string>();
            listNumele = new List<string>();
            listLabels = new List<Label>();
            controllerRezultate = new ControllerRezultate();


            // pnlPopic
            this.Location = new System.Drawing.Point(17, 39);
            this.Name = "PnlPopice";
            this.Size = new System.Drawing.Size(1222, 506);
            this.BackColor = SystemColors.GradientInactiveCaption;


            this.pctBila = new System.Windows.Forms.PictureBox();
            this.lblTimp = new System.Windows.Forms.Label();
            this.lblLitere = new System.Windows.Forms.Label();
            this.pct1 = new System.Windows.Forms.PictureBox();
            this.pct2 = new System.Windows.Forms.PictureBox();
            this.timerForm = new Timer();
            this.lblImagine1 = new System.Windows.Forms.Label();
            this.lblImagine2 = new System.Windows.Forms.Label();

            this.Controls.Add(this.pctBila);

            this.timerForm.Interval = 1000;
            this.timerForm.Tick += new EventHandler(timerForm_Tick);
            this.timerForm.Start();

            //Form
            this.form.MinimumSize = new System.Drawing.Size(1251, 730);
            this.form.MaximumSize = new System.Drawing.Size(1251, 730);
            this.form.Size = new System.Drawing.Size(1251, 730);
            this.form.Controls.Add(this.pct2);
            this.form.Controls.Add(this.pct1);
            this.form.Controls.Add(this.lblTimp);
            this.form.Controls.Add(this.lblImagine1);
            this.form.Controls.Add(this.lblImagine2);
            this.form.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.form.Name = "Popice";
            this.form.Text = "Popice cu Litere";
            this.form.KeyDown += new KeyEventHandler(form_KeyDowm);

            string path = Application.StartupPath + @"/Imagini/";

            // pctBila
            this.pctBila.Location = new System.Drawing.Point(50, 400);
            this.pctBila.Name = "pctBila";
            this.pctBila.Size = new System.Drawing.Size(50, 50);
            this.pctBila.SizeMode = PictureBoxSizeMode.StretchImage;
            this.pctBila.Image = Image.FromFile(Application.StartupPath + @"/ball.png");

            addList();
            addListLiterele();
            lblImagine1.Text = "";
            lblImagine2.Text = "";

            lblTimp.Visible = true;
            lblLitere.Visible = true;
            pct1.Visible = true;
            pct2.Visible = true;

            // lblTimp
            this.lblTimp.AutoSize = true;
            this.lblTimp.Location = new System.Drawing.Point(32, 9);
            this.lblTimp.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTimp.Name = "lblTimp";
            this.lblTimp.Size = new System.Drawing.Size(128, 27);
            this.lblTimp.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 15);
            this.lblTimp.Text = "Timp Ramas: " + timp;

            // pct1
            this.pct1.Location = new System.Drawing.Point(17, 551);
            this.pct1.Name = "pct1";
            this.pct1.Size = new System.Drawing.Size(200, 113);
            this.pct1.SizeMode = PictureBoxSizeMode.StretchImage;
            this.pct1.Image = images[0];

            // pct2
            this.pct2.Location = new System.Drawing.Point(233, 551);
            this.pct2.Name = "pct2";
            this.pct2.Size = new System.Drawing.Size(200, 113);
            this.pct2.SizeMode = PictureBoxSizeMode.StretchImage;
            this.pct2.Image = images[1];

            // lblImg1
            this.lblImagine1.AutoSize = true;
            this.lblImagine1.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 16.2F, System.Drawing.FontStyle.Regular);
            this.lblImagine1.Location = new System.Drawing.Point(600, 600);
            this.lblImagine1.Text = initializere1();

            //lblImg2
            this.lblImagine2.AutoSize = true;
            this.lblImagine2.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 16.2F, System.Drawing.FontStyle.Regular);
            this.lblImagine2.Location = new System.Drawing.Point(900, 600);
            this.lblImagine2.Text = initializere2();

            cuv1 = listNumele[0].Remove(listNumele[0].Length - 4);
            cuv2 = listNumele[1].Remove(listNumele[1].Length - 4);

            createLabels();
        }

        public string initializere1()
        {
            string t = "";
            for (int i = 0; i < listNumele[0].Length-4; i++)
            {
                t += "_ ";
            }

            return t;
        }

        public string initializere2()
        {
            string t = "";
            for (int i = 0; i < listNumele[1].Length-4; i++)
            {
                t += "_ ";
            }

            return t;
        }

        private int semn1 = 0;
        private int semn2 = 0;
        private int ctCuv1 = 0;
        private int ctCuv2 = 0;
        public void ghicire1(string litera)
        {
            int ct = 0;
            for (int i = 0; i < cuv1.Length; i++)
            {

                if (cuv1[i].ToString() == litera || cuv1[i].ToString() == litera.ToLower())
                {
                    string textLabelNou = lblImagine1.Text.Substring(0, i * 2) + litera + lblImagine1.Text.Substring(i * 2 + 1);
                    lblImagine1.Text = textLabelNou;
                    ct++;
                }
            }
            ctCuv1 += ct;
            if (ctCuv1>= cuv1.Length)
            {
                pct1.Visible = false;
                pct1 = null;
                semn1 = 1;
                if (semn1 == 1 && semn2 == 1)
                {
                    MessageBox.Show("Bravo! \n Ai ghicit cuvintele!", "Felicitari!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.form.removepnl("PnlPopice");
                    int rez = timp;
                    lblTimp.Visible = false;
                    lblLitere.Visible = false;
                    lblImagine1.Text = "";
                    lblImagine2.Text = "";
                    string textul = controllerRezultate.generareId().ToString() + ";" + 1.ToString() + ";" + utilizator1.getId() + ";" + rez.ToString() + ";" + DateTime.Today;
                    controllerRezultate.save(textul);
                    this.form.Controls.Add(new PnlAlegeJoc(form, utilizator1));
                }
              
            }
        }

        public void ghicire2(string litera)
        {
            int ct = 0;
            for (int i = 0; i < cuv2.Length; i++)
            {

                if (cuv2[i].ToString() == litera || cuv2[i].ToString() == litera.ToLower())
                {
                    string textLabelNou = lblImagine2.Text.Substring(0, i * 2) + litera + lblImagine2.Text.Substring(i * 2 + 1);
                    lblImagine2.Text = textLabelNou;
                    ct++;
                }
            }

            ctCuv2 += ct;
            if (ctCuv2 >= cuv2.Length)
            {
                semn2 = 1;
                pct2.Visible = false;
                pct2 = null;

                if (semn1 == 1 && semn2 == 1)
                {
                    MessageBox.Show("Bravo! \n Ai ghicit cuvintele!", "Felicitari!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.form.removepnl("PnlPopice");
                    int rez = timp;
                    lblTimp.Visible = false;
                    lblLitere.Visible = false;
                    lblImagine1.Text = "";
                    lblImagine2.Text = "";
                    string textul = controllerRezultate.generareId().ToString() + ";" + 1.ToString() + ";" + utilizator1.getId() + ";" + rez.ToString() + ";" + DateTime.Today;
                    controllerRezultate.save(textul);
                    this.form.Controls.Add(new PnlAlegeJoc(form, utilizator1));
                }

            }
        }

        public void addList()
        {

            string path = Application.StartupPath + @"/Imagini/";

            string[] imageFile = Directory.GetFiles(path, "*.jpg");
            string[] imageFile1 = Directory.GetFiles(path, "*.png");

            int dim = imageFile.Length;
            Random random = new Random();
            int rand= random.Next(0, imageFile.Length-1);
            Image image = Image.FromFile(imageFile[rand]);
            images.Add(image);

            string image1 = imageFile[rand].Remove(0, 49);

            listNumele.Add(image1);


            int rand1 = random.Next(0, imageFile1.Length);
            Image image3 = Image.FromFile(imageFile1[rand1]);
            images.Add(image3);

            string image2 = imageFile1[rand1].Remove(0, 49);
            listNumele.Add(image2);

        }

        public void addListLiterele()
        {

            List<string> listaCuvinte = new List<string>();

            foreach (string fisier in listNumele)
            {
                string numeFisier = Path.GetFileNameWithoutExtension(fisier);
                listaCuvinte.Add(numeFisier);
            }

            foreach (string cuvant in listaCuvinte)
            {
                char[] litere = cuvant.ToCharArray();
                foreach (char litera in litere)
                {
                    listLiterele.Add(litera.ToString());
                }
            }

            Random random = new Random();
            List<string> listaAmestecata = new List<string>();

            while (listLiterele.Count > 0)
            {
                int indexAleator = random.Next(0, listLiterele.Count);
                string litera = listLiterele[indexAleator];
                listaAmestecata.Add(litera);
                listLiterele.RemoveAt(indexAleator);
            }
            listLiterele = listaAmestecata;


        }

        public void createLabels()
        {

            int x = 50;
            for (int i = 0; i < listLiterele.Count; i++)
            {

                Label lblLitere;
                lblLitere = new Label();
                this.Controls.Add(lblLitere);
                lblLitere.BackColor = System.Drawing.Color.BlanchedAlmond;
                lblLitere.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 20F);
                lblLitere.Location = new System.Drawing.Point(x, 50);
                lblLitere.Name = listLiterele[i];
                lblLitere.Size = new System.Drawing.Size(50, 50);
                lblLitere.Text = listLiterele[i].ToUpper();
               // MessageBox.Show(lblLitere.Location.X.ToString());
                listLabels.Add(lblLitere);

                foreach (var lbl in listLabels)
                {
                  //  lbl.Click += Label_Click;
                }

                x += 55;
            }


        }

        private void form_KeyDowm(object sender, KeyEventArgs e)
        {
            if(pctBila.Location.X >50 && pctBila.Location.Y != 50)
            if(e.KeyCode == Keys.Left) {

                pctBila.Location = new Point(pctBila.Location.X - 55, pctBila.Location.Y + 0);
            }

            if(pctBila.Location.X < listLabels[listLabels.Count - 1].Location.X && pctBila.Location.Y!=50)
            if(e.KeyCode == Keys.Right)
            {

                pctBila.Location = new Point(pctBila.Location.X + 55, pctBila.Location.Y + 0);

            }

            if (e.KeyCode == Keys.Up) {
                pctBila.Location = new Point(pctBila.Location.X, 50);

                for(int i = 0;i< listLabels.Count; i++)
                {
                    if(pctBila.Location == listLabels[i].Location)
                    {
                        if(semn1!=1)
                        ghicire1(listLabels[i].Name);

                        if(semn2!=1)
                        ghicire2(listLabels[i].Name);

                        listLabels[i].Enabled = false;
                        listLabels[i].Location = new Point(0, 0);
                        listLabels[i].Visible = false;
                    }

                }


            }

            if (e.KeyCode == Keys.Down)
            {
                pctBila.Location = new Point(pctBila.Location.X, 400);

            }


        }

        private void timerForm_Tick(object sender, EventArgs e)
        {

            timp--;
            this.lblTimp.Text = "Timp Ramas: " + timp;

            if(timp <= 0) {

                MessageBox.Show("Ai pierdut!", "Ghinion!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                timerForm.Stop();
                timerForm.Enabled = false;
                this.form.removepnl("PnlPopice");
                int rez = timp;
                lblTimp.Visible = false;
                lblLitere.Visible = false;
                pct1.Visible = false;
                pct2.Visible = false;
                string textul = controllerRezultate.generareId().ToString() + ";" + 1.ToString() + ";" + utilizator1.getId() + ";" + rez.ToString() + ";" + DateTime.Today;
                controllerRezultate.save(textul);
                this.form.Controls.Add(new PnlAlegeJoc(form, utilizator1));

            }

        }


    }
}
