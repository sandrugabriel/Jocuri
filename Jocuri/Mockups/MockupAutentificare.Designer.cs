namespace Jocuri.Mockups
{
    partial class MockupAutentificare
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
            this.pctQRCode = new System.Windows.Forms.PictureBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblParola = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtParola = new System.Windows.Forms.TextBox();
            this.btnQRCode = new System.Windows.Forms.Button();
            this.btnContNou = new System.Windows.Forms.Button();
            this.btnLogare = new System.Windows.Forms.Button();
            this.lblTitlu = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pctQRCode)).BeginInit();
            this.SuspendLayout();
            // 
            // pctQRCode
            // 
            this.pctQRCode.Location = new System.Drawing.Point(12, 100);
            this.pctQRCode.Name = "pctQRCode";
            this.pctQRCode.Size = new System.Drawing.Size(250, 250);
            this.pctQRCode.TabIndex = 0;
            this.pctQRCode.TabStop = false;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 13.2F);
            this.lblEmail.Location = new System.Drawing.Point(309, 144);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(175, 30);
            this.lblEmail.TabIndex = 1;
            this.lblEmail.Text = "Adresa de email";
            // 
            // lblParola
            // 
            this.lblParola.AutoSize = true;
            this.lblParola.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 13.2F);
            this.lblParola.Location = new System.Drawing.Point(309, 242);
            this.lblParola.Name = "lblParola";
            this.lblParola.Size = new System.Drawing.Size(76, 30);
            this.lblParola.TabIndex = 2;
            this.lblParola.Text = "Parola";
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(314, 177);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(281, 34);
            this.txtEmail.TabIndex = 3;
            // 
            // txtParola
            // 
            this.txtParola.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtParola.Location = new System.Drawing.Point(314, 275);
            this.txtParola.Name = "txtParola";
            this.txtParola.Size = new System.Drawing.Size(281, 34);
            this.txtParola.TabIndex = 4;
            // 
            // btnQRCode
            // 
            this.btnQRCode.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQRCode.Location = new System.Drawing.Point(43, 398);
            this.btnQRCode.Name = "btnQRCode";
            this.btnQRCode.Size = new System.Drawing.Size(137, 55);
            this.btnQRCode.TabIndex = 5;
            this.btnQRCode.Text = "QRCode";
            this.btnQRCode.UseVisualStyleBackColor = true;
            // 
            // btnContNou
            // 
            this.btnContNou.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnContNou.Location = new System.Drawing.Point(446, 398);
            this.btnContNou.Name = "btnContNou";
            this.btnContNou.Size = new System.Drawing.Size(139, 55);
            this.btnContNou.TabIndex = 6;
            this.btnContNou.Text = "Cont Nou";
            this.btnContNou.UseVisualStyleBackColor = true;
            // 
            // btnLogare
            // 
            this.btnLogare.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogare.Location = new System.Drawing.Point(246, 398);
            this.btnLogare.Name = "btnLogare";
            this.btnLogare.Size = new System.Drawing.Size(139, 55);
            this.btnLogare.TabIndex = 7;
            this.btnLogare.Text = "Logare";
            this.btnLogare.UseVisualStyleBackColor = true;
            // 
            // lblTitlu
            // 
            this.lblTitlu.AutoSize = true;
            this.lblTitlu.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 18.2F);
            this.lblTitlu.Location = new System.Drawing.Point(220, 31);
            this.lblTitlu.Name = "lblTitlu";
            this.lblTitlu.Size = new System.Drawing.Size(194, 40);
            this.lblTitlu.TabIndex = 8;
            this.lblTitlu.Text = "Autentificare";
            // 
            // MockupAutentificare
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(694, 511);
            this.Controls.Add(this.lblTitlu);
            this.Controls.Add(this.btnLogare);
            this.Controls.Add(this.btnContNou);
            this.Controls.Add(this.btnQRCode);
            this.Controls.Add(this.txtParola);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.lblParola);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.pctQRCode);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "MockupAutentificare";
            this.Text = "MockupAutentificare";
            this.Load += new System.EventHandler(this.MockupAutentificare_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pctQRCode)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pctQRCode;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblParola;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtParola;
        private System.Windows.Forms.Button btnQRCode;
        private System.Windows.Forms.Button btnContNou;
        private System.Windows.Forms.Button btnLogare;
        private System.Windows.Forms.Label lblTitlu;
    }
}