using Jocuri.Controllers;
using Jocuri.Models;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Jocuri.Panels
{
    internal class PnlTestMemorie:Panel
    {

        Form1 form;
        Utilizator utilizator;
        Button btnStart;
        Label lblTimp;
        private int timp;
        private int score;
        private int contor;
        Timer timer;
        int n;

        List<string> listNumele;
        List<Image> listImagini;
        List<PictureBox> listPictureBoxes;
        List<PictureBox> listPctCorrect;
        List<Label> listLabels;
        List<Label> listLblCorrect;
        string path;
        private int score1;

        ControllerRezultate controllerRezultate;

        public PnlTestMemorie(Form1 form1, Utilizator utilizator1, int n1, int score2) {

            form = form1;
            score = 0;
            contor = 0;
            score1 = score2;
            utilizator = utilizator1;
            timp = 100;
            n = n1;
            listImagini = new List<Image>();
            listNumele = new List<string>();
            listPictureBoxes = new List<PictureBox>();
            listLabels = new List<Label>();
            listLblCorrect = new List<Label>();
            controllerRezultate = new ControllerRezultate();
            listPctCorrect = new List<PictureBox>();
            path = Application.StartupPath + @"/Imagini/";


            //PnlTestMemorie
            this.form.Size = new System.Drawing.Size(1400, 600); 
            this.form.MaximumSize = new System.Drawing.Size(1400, 600);
            this.form.MinimumSize = new System.Drawing.Size(1400, 600);
            this.Size = new System.Drawing.Size(1400, 600);
            this.Name = "PnlTestMemorie";

            this.btnStart = new Button();
            this.lblTimp = new Label();
            this.timer = new Timer();

            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.lblTimp);

            //btnStart
            this.btnStart.Text = "Start";
            this.btnStart.Size = new System.Drawing.Size(110,50);
            this.btnStart.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 20);
            this.btnStart.Location = new System.Drawing.Point(630,400);
            this.btnStart.Click += new EventHandler(btnStart_Click);

            //lblTime
            this.lblTimp.Text = "Timp Ramas: " + timp;
            this.lblTimp.AutoSize = true;
            this.lblTimp.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 20);
            this.lblTimp.Location = new System.Drawing.Point(575,350);

            //timer
            this.timer.Interval = 1000;
            this.timer.Stop();
            this.timer.Enabled = false;
            this.timer.Tick += new EventHandler(timer_Tick);

            createPictureBox(n);

            foreach (var pictureBox in listPictureBoxes)
            {
                pictureBox.Enabled = false;
            }

            foreach (var lbl in listLabels)
            { 
                lbl.Enabled = false;
            }
               
            


        }

        private void btnStart_Click(object sender, EventArgs e)
        {

            foreach (var pictureBox in listPictureBoxes)
            {
                pictureBox.Enabled = true;
            }

            foreach (var lbl in listLabels)
            {
                lbl.Enabled = true;
            }

            this.timer.Enabled = true;
            this.timer.Start();

        }

        public int ctObiecte(int n)
        {

            if (n <= 2)
            {
                return 1;
            }
            else
            {
              return ctObiecte(n - 1) + ctObiecte(n - 2);
            }



        }

        public void addList(int nrImagini)
        {

            string path = Application.StartupPath + @"/Imagini/";

            string[] imageFile = Directory.GetFiles(path,"*.jpg");
            string[] imageFile1 = Directory.GetFiles(path, "*.png");
            int dim = imageFile.Length;
            for(int i = 0; i <imageFile.Length; i++)
            {
                 Image image = Image.FromFile(imageFile[i]);
                 listImagini.Add(image);
                 

                string image1 = imageFile[i].Remove(0, 49);
                listNumele.Add(image1);
                
            }

            for(int i = 0; i < imageFile1.Length; i++)
            {
                Image image = Image.FromFile(imageFile1[i]);
                listImagini.Add(image);

                string image1 = imageFile1[i].Remove(0, 49);
                listNumele.Add(image1);
            }

            for (int i=0;i<listImagini.Count;i++)
            {
                if (listNumele.Count != nrImagini)
                {
                    listImagini.RemoveAt(i);
                    listNumele.RemoveAt(i);
                    i = 0;
                }
              //  MessageBox.Show(listImagini[i]);
            }

        }

        private int i = 0;

        public void createPictureBox(int n)
        {

            int nrPct = 2 * ctObiecte(n);
            addList(nrPct);

            int x = 20;
            for (i = 0; i < nrPct; i++)
            {

                PictureBox pictureBox = new PictureBox();
                this.Controls.Add(pictureBox);
                pictureBox.Size = new Size(100, 100);
                pictureBox.Name = listNumele[i];
                pictureBox.BackColor = Color.LightGreen;
                pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                pictureBox.BackgroundImageLayout = ImageLayout.Stretch;
                listPictureBoxes.Add(pictureBox);

                foreach (var pictureBox1 in listPictureBoxes)
                {
                    pictureBox1.Click += PictureBox_Click;
                }

                Label lblNume = new Label();
                this.Controls.Add(lblNume);
                lblNume.Name = listNumele[i];
                //lblNume.Text = "\n\n\n" + listNumele[i];
                lblNume.BackColor = Color.LightGreen;
                lblNume.Size = new Size(100, 100);
                listLabels.Add(lblNume);

                foreach (var lbl in listLabels)
                {
                    lbl.Click += Label_Click;
                }

               
            }

            Random random = new Random();
            List<PictureBox> listaAmestecata = new List<PictureBox>();

            while (listPictureBoxes.Count > 0)
            {
                int indexAleator = random.Next(0, listPictureBoxes.Count);
                PictureBox pictureBox = listPictureBoxes[indexAleator];
                listaAmestecata.Add(pictureBox);
                listPictureBoxes.RemoveAt(indexAleator);
            }
            listPictureBoxes = listaAmestecata;


            Random random1 = new Random();
            List<Label> listaAmestecata1 = new List<Label>();

            while (listLabels.Count > 0)
            {
                int indexAleator = random.Next(0, listLabels.Count);
                Label label = listLabels[indexAleator];
                listaAmestecata1.Add(label);
                listLabels.RemoveAt(indexAleator);
            }
            listLabels = listaAmestecata1;

            foreach (var pictureBox in listPictureBoxes)
            {              
                pictureBox.Location = new Point(x, 20);
                x += 115;
            }

            x = 20;

            foreach (var label in listLabels)
            {

                label.Location = new Point(x, 155); 
                x += 115;
            }


        }

        private PictureBox clickedPictureBox=null;

        private void PictureBox_Click(object sender, EventArgs e)
        {

            clickedPictureBox = (PictureBox)sender;

            clickedPictureBox.Image = Image.FromFile(path + clickedPictureBox.Name);

            foreach (var pictureBox in listPictureBoxes)
            {
                if (pictureBox.Name != clickedPictureBox.Name)
                {
                    pictureBox.Enabled = false;
                }

            }

        }

        private Label clickedLabel = null;

        private void Label_Click(object sender, EventArgs e)
        {

            clickedLabel = (Label)sender;
            int index = clickedLabel.Name.Length - 4;
            clickedLabel.Text = "\n\n\n        " + clickedLabel.Name.Remove(index);

            foreach (var lbl in listLabels)
            {
                if (lbl.Name != clickedLabel.Name)
                {
                    lbl.Enabled = false;
                }

            }


        }

        private void timer_Tick(object sender, EventArgs e)
        {
            timp--;
            this.lblTimp.Text = "Timp Ramas: " + timp;

            if(timp <= 0)
            {
                this.timer.Enabled = false;
                this.timer.Stop();
                MessageBox.Show("Ai pierdut!!","Ghinion!",MessageBoxButtons.OK, MessageBoxIcon.Stop);
                string text = controllerRezultate.generareId() + ";" + 0.ToString() + ";" + utilizator.getId() + ";" + 0.ToString() + ";" + DateTime.Today.ToString();
                controllerRezultate.save(text);
                this.form.removepnl("PnlTestMemorie");
                this.form.Controls.Add(new PnlAlegeJoc(form, utilizator));
            }

            if(clickedPictureBox!= null && clickedLabel!= null)
            {

                if(clickedLabel.Name == clickedPictureBox.Name)
                {
                    score1 = score1 +10;
                    listPctCorrect.Add(clickedPictureBox);
                    listLblCorrect.Add(clickedLabel);
                    clickedLabel.Enabled = false;
                    clickedLabel.Enabled = false;
                    clickedPictureBox = null;
                    clickedLabel = null;
                    foreach (var pictureBox1 in listPictureBoxes)
                    {
                        int semn = 0;
                        foreach (var pictureBox2 in listPctCorrect)
                        {
                            if (pictureBox1.Name == pictureBox2.Name)
                                semn = 1;
                        }
                        if (semn == 0)
                            pictureBox1.Enabled = true;
                    }
                    foreach (var lbl in listLabels)
                    {
                        int semn = 0;
                        foreach (var lbl1 in listLblCorrect)
                        {
                            if (lbl1.Name == lbl.Name)
                                semn = 1;
                        }
                        if (semn == 0)
                        {
                            lbl.Enabled = true;
                        }

                    }
                    score++;
                }
                else
                {
                    clickedLabel.Text = "";
                    clickedPictureBox.Image = null;
                    clickedPictureBox = null;
                    clickedLabel= null;

                    foreach (var pictureBox1 in listPictureBoxes)
                    {
                        int semn = 0;
                        foreach (var pictureBox2 in listPctCorrect)
                        {
                            if (pictureBox1.Name == pictureBox2.Name)
                                semn = 1;
                        }
                        if(semn==0)
                       pictureBox1.Enabled = true;
                    }
                    foreach (var lbl in listLabels)
                    {
                        int semn = 0;
                        foreach (var lbl1 in listLblCorrect)
                        {
                            if (lbl1.Name == lbl.Name)
                                semn = 1;
                        }
                        if (semn == 0)
                        {
                            lbl.Enabled = true;
                        }

                    }


                }

            }

            if (score >= 2 * ctObiecte(n))
            {

                n++;

                if (n >= 6)
                {
                    timer.Stop();
                    timer.Enabled = false;
                    string text = controllerRezultate.generareId() + ";" + 0.ToString() + ";" + utilizator.getId() + ";" + score1.ToString() + ";" + DateTime.Today.ToString();
                    controllerRezultate.save(text);
                    this.form.removepnl("PnlTestMemorie");
                    this.form.Controls.Add(new PnlCastigat(form,utilizator));
                }
                else
                {
                    MessageBox.Show("             Felicitari!\n  Ai trecut la nivelul urmator!!", "Felicitari", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.form.removepnl("PnlTestMemorie");
                    this.form.Controls.Add(new PnlTestMemorie(form, utilizator, n, score1));
                }
            }



        }




    }
}
