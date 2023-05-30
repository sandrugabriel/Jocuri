using Jocuri.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Jocuri.Controllers
{
    internal class ControllerRezultate
    {

        private List<Rezultat> rezultate;

        public ControllerRezultate()
        {

            rezultate = new List<Rezultat>();

            load();
        }

        public void load()
        {

            string path = Application.StartupPath + @"/data/Rezultate.txt";
            StreamReader streamReader = new StreamReader(path);

            string t;

            while ((t = streamReader.ReadLine()) != null)
            {

                Rezultat rezultat = new Rezultat(t);
                rezultate.Add(rezultat);
            }
            streamReader.Close();
        }






    }
}
