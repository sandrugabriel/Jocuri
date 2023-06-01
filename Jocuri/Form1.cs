using Jocuri.Models;
using Jocuri.Panels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Jocuri
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Utilizator utilizator = new Utilizator("1;ion@oti.ro;ion;noi");
           this.Controls.Add(new PnlPopice(this,utilizator));

        }

        public void removepnl(string pnl)
        {

            Control control = null;

            foreach (Control c in this.Controls)
            {
                if (c.Name.Equals(pnl))
                {
                    control = c;
                }

            }

            this.Controls.Remove(control);

        }


    }
}
