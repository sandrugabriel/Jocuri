using Jocuri.Controllers;
using Jocuri.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Jocuri.Panels
{
    internal class PnlAutentificare:Panel
    {
        Form1 form;

        private System.Windows.Forms.PictureBox pctQRCode;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblParola;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtParola;
        private System.Windows.Forms.Button btnQRCode;
        private System.Windows.Forms.Button btnContNou;
        private System.Windows.Forms.Button btnLogare;
        private System.Windows.Forms.Label lblTitlu;

        List<string> erori;

        ControllerUtilizatori controllerUtilizatori;

        public PnlAutentificare(Form1 form1)
        {

            form = form1;
            erori = new List<string>();
            controllerUtilizatori = new ControllerUtilizatori();

            // PnlAutentificare
            this.ClientSize = new System.Drawing.Size(694, 511);
            this.Name = "PnlAutentificare";

            this.pctQRCode = new System.Windows.Forms.PictureBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblParola = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtParola = new System.Windows.Forms.TextBox();
            this.btnQRCode = new System.Windows.Forms.Button();
            this.btnContNou = new System.Windows.Forms.Button();
            this.btnLogare = new System.Windows.Forms.Button();
            this.lblTitlu = new System.Windows.Forms.Label();

            this.Controls.Add(this.lblTitlu);
            this.Controls.Add(this.btnLogare);
            this.Controls.Add(this.btnContNou);
            this.Controls.Add(this.btnQRCode);
            this.Controls.Add(this.txtParola);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.lblParola);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.pctQRCode);

            // pctQRCode
            this.pctQRCode.Location = new System.Drawing.Point(12, 100);
            this.pctQRCode.Name = "pctQRCode";
            this.pctQRCode.Size = new System.Drawing.Size(250, 250);
             
            // lblEmail
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 13.2F);
            this.lblEmail.Location = new System.Drawing.Point(309, 144);
            this.lblEmail.Size = new System.Drawing.Size(175, 30);
            this.lblEmail.Text = "Adresa de email";
             
            // lblParola
            this.lblParola.AutoSize = true;
            this.lblParola.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 13.2F);
            this.lblParola.Location = new System.Drawing.Point(309, 242);
            this.lblParola.Size = new System.Drawing.Size(76, 30);
            this.lblParola.Text = "Parola";
             
            // txtEmail
            this.txtEmail.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 12F, System.Drawing.FontStyle.Regular);
            this.txtEmail.Location = new System.Drawing.Point(314, 177);
            this.txtEmail.Size = new System.Drawing.Size(281, 34);
            
            // txtParola
            this.txtParola.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 12F, System.Drawing.FontStyle.Regular);
            this.txtParola.Location = new System.Drawing.Point(314, 275);
            this.txtParola.UseSystemPasswordChar = true;
            this.txtParola.Size = new System.Drawing.Size(281, 34);
             
            // btnQRCode
            this.btnQRCode.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 13.8F, System.Drawing.FontStyle.Regular);
            this.btnQRCode.Location = new System.Drawing.Point(43, 398);
            this.btnQRCode.Size = new System.Drawing.Size(137, 55);
            this.btnQRCode.Text = "QRCode";
             
            // btnContNou
            this.btnContNou.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 13.8F, System.Drawing.FontStyle.Regular);
            this.btnContNou.Location = new System.Drawing.Point(446, 398);
            this.btnContNou.Name = "btnContNou";
            this.btnContNou.Size = new System.Drawing.Size(139, 55);
            this.btnContNou.Text = "Cont Nou";
            this.btnContNou.Click += new EventHandler(btnContNou_Click);
            
            // btnLogare
            this.btnLogare.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 13.8F, System.Drawing.FontStyle.Regular);
            this.btnLogare.Location = new System.Drawing.Point(246, 398);
            this.btnLogare.Size = new System.Drawing.Size(139, 55);
            this.btnLogare.Text = "Logare";
            this.btnLogare.Click += new EventHandler(btnLogare_Click);
             
            // lblTitlu
            this.lblTitlu.AutoSize = true;
            this.lblTitlu.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 18.2F);
            this.lblTitlu.Location = new System.Drawing.Point(220, 31);
            this.lblTitlu.Text = "Autentificare";
            this.lblTitlu.Size = new System.Drawing.Size(194, 40);

        }

        private void btnLogare_Click(object sender, EventArgs e)
        {

            if (controllerUtilizatori.verification(txtParola.Text, txtEmail.Text))
            {

                int id = controllerUtilizatori.idByemailPass(txtParola.Text, txtEmail.Text);
                string email = txtEmail.Text;
                string pass = txtParola.Text;
                this.form.removepnl("PnlAutentificare");
                Utilizator utilizator = controllerUtilizatori.utilizatorbyId(id);
            }
            else
            {

                MessageBox.Show("Nume de utilizator si/sau parola invalida!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtEmail.Text = "";
                txtParola.Text = "";

            }


        }

        private void btnContNou_Click(object sender, EventArgs e)
        {

            this.form.removepnl("PnlAutentificare");
            this.form.Controls.Add(new PnlContNou(form));

        }



    }
}
