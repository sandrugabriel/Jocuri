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
    internal class PnlContNou:Panel
    {
        Form1 form;

        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblParola;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtParola;
        private System.Windows.Forms.Button btnRenunta;
        private System.Windows.Forms.Button btnInregistrare;
        private System.Windows.Forms.Label lblTitlu;
        private System.Windows.Forms.TextBox txtNume;
        private System.Windows.Forms.Label lblNume;
        private System.Windows.Forms.TextBox txtReParola;
        private System.Windows.Forms.Label lblReParola;

        ControllerUtilizatori controllerUtilizatori;
        List<string> erori;
        public PnlContNou(Form1 form1) {

            form = form1;
            controllerUtilizatori = new ControllerUtilizatori();
            erori = new List<string>();
            this.form.Size = new System.Drawing.Size(694, 511);
            this.form.MinimumSize = new System.Drawing.Size(694, 511);
            this.form.MaximumSize = new System.Drawing.Size(694, 511);

            //PnlContNou
            this.Size = new System.Drawing.Size(694, 511);
            this.Name = "PnlContNou";

            this.lblEmail = new System.Windows.Forms.Label();
            this.lblParola = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtParola = new System.Windows.Forms.TextBox();
            this.btnRenunta = new System.Windows.Forms.Button();
            this.btnInregistrare = new System.Windows.Forms.Button();
            this.lblTitlu = new System.Windows.Forms.Label();
            this.txtNume = new System.Windows.Forms.TextBox();
            this.lblNume = new System.Windows.Forms.Label();
            this.txtReParola = new System.Windows.Forms.TextBox();
            this.lblReParola = new System.Windows.Forms.Label();

            this.Controls.Add(this.txtReParola);
            this.Controls.Add(this.lblReParola);
            this.Controls.Add(this.txtNume);
            this.Controls.Add(this.lblNume);
            this.Controls.Add(this.lblTitlu);
            this.Controls.Add(this.btnInregistrare);
            this.Controls.Add(this.btnRenunta);
            this.Controls.Add(this.txtParola);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.lblParola);
            this.Controls.Add(this.lblEmail);


            // lblEmail
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 13.2F);
            this.lblEmail.Location = new System.Drawing.Point(21, 127);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(175, 30);
            this.lblEmail.TabIndex = 1;
            this.lblEmail.Text = "Adresa de email";
             
            // lblParola
            this.lblParola.AutoSize = true;
            this.lblParola.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 13.2F);
            this.lblParola.Location = new System.Drawing.Point(21, 271);
            this.lblParola.Name = "lblParola";
            this.lblParola.Size = new System.Drawing.Size(76, 30);
            this.lblParola.Text = "Parola";
             
            // txtEmail
            this.txtEmail.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 12F, System.Drawing.FontStyle.Regular);
            this.txtEmail.Location = new System.Drawing.Point(26, 160);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(281, 34);
            
            // txtParola
            this.txtParola.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 12F, System.Drawing.FontStyle.Regular);
            this.txtParola.Location = new System.Drawing.Point(26, 304);
            this.txtParola.Name = "txtParola";
            this.txtParola.Size = new System.Drawing.Size(281, 34);
            this.txtParola.UseSystemPasswordChar = true;
             
            // btnRenunta
            this.btnRenunta.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 13.8F, System.Drawing.FontStyle.Regular);
            this.btnRenunta.Location = new System.Drawing.Point(365, 370);
            this.btnRenunta.Name = "btnRenunta";
            this.btnRenunta.Size = new System.Drawing.Size(146, 65);
            this.btnRenunta.Text = "Renunta";
            this.btnRenunta.Click += new EventHandler(btnRenunta_Click);
             
            // btnInregistrare
            this.btnInregistrare.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 13.8F, System.Drawing.FontStyle.Regular);
            this.btnInregistrare.Location = new System.Drawing.Point(176, 370);
            this.btnInregistrare.Name = "btnInregistrare";
            this.btnInregistrare.Size = new System.Drawing.Size(146, 65);
            this.btnInregistrare.Text = "Inregistrare";
            this.btnInregistrare.Click += new EventHandler(btnInregistrare_Click);
             
            // lblTitlu
            this.lblTitlu.AutoSize = true;
            this.lblTitlu.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 18.2F);
            this.lblTitlu.Location = new System.Drawing.Point(220, 31);
            this.lblTitlu.Name = "lblTitlu";
            this.lblTitlu.Size = new System.Drawing.Size(155, 40);
            this.lblTitlu.Text = "Cont Nou";
             
            // txtNume
            this.txtNume.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 12F, System.Drawing.FontStyle.Regular);
            this.txtNume.Location = new System.Drawing.Point(365, 160);
            this.txtNume.Name = "txtNume";
            this.txtNume.Size = new System.Drawing.Size(281, 34);

            // lblNume
            this.lblNume.AutoSize = true;
            this.lblNume.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 13.2F);
            this.lblNume.Location = new System.Drawing.Point(360, 127);
            this.lblNume.Name = "lblNume";
            this.lblNume.Size = new System.Drawing.Size(170, 30);
            this.lblNume.Text = "Nume Utilizator";
            
            // txtReParola
            this.txtReParola.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 12F, System.Drawing.FontStyle.Regular);
            this.txtReParola.Location = new System.Drawing.Point(365, 304);
            this.txtReParola.Name = "txtReParola";
            this.txtReParola.Size = new System.Drawing.Size(281, 34);
            this.txtReParola.UseSystemPasswordChar = true;
             
            // lblReParola
            this.lblReParola.AutoSize = true;
            this.lblReParola.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 13.2F);
            this.lblReParola.Location = new System.Drawing.Point(360, 271);
            this.lblReParola.Name = "lblReParola";
            this.lblReParola.Size = new System.Drawing.Size(196, 30);
            this.lblReParola.Text = "Confirmare Parola";


        }

        private void errors()
        {
            erori.Clear();

            if (txtNume.Text.Equals(""))
            {
                erori.Add("You have not entered the username");
            }


            if (txtEmail.Text.Equals(""))
            {
                erori.Add("You have not entered the email");
            }

            if (txtParola.Text.Equals(""))
            {
                erori.Add("You have not entered the password");
            }
            else
            {
                if (controllerUtilizatori.verificationPassword(txtParola.Text) == false)
                {
                    txtParola.Focus();
                    erori.Add("Password is invalid");

                }
                else
                    if (txtParola.Text != txtReParola.Text)
                {
                    erori.Add("Password does not match");
                }

            }


        }

        private void btnInregistrare_Click(object sender, EventArgs e)
        {


            errors();

            if (erori.Count > 0)
            {
                for (int i = 0; i < erori.Count; i++)
                {
                    MessageBox.Show(erori[i], "Errors", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {


                int id = controllerUtilizatori.generareId();
                string name = txtNume.Text;
                string password = txtParola.Text;
                string email = txtEmail.Text;

                string textul = id.ToString() + ";" + email + ";" + name + ";" + password;

                controllerUtilizatori.save(textul);

                controllerUtilizatori.load();

                Utilizator utilizator = new Utilizator(textul);

                this.form.removepnl("PnlContNou");
                this.form.Controls.Add(new PnlAlegeJoc(form, utilizator));
            }


        }

        private void btnRenunta_Click(object sender, EventArgs e)
        {

            this.form.removepnl("PnlContNou");
            this.form.Controls.Add(new PnlAutentificare(form));

        }

    }
}
