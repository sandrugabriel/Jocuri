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

        public List<Rezultat> getTestMemorie(int idUtilizator)
        {

            List<Rezultat> rezultats = new List<Rezultat>();

            for(int i=0;i<rezultate.Count;i++)
            {
                if (rezultate[i].getIdUtilizator() == idUtilizator && rezultate[i].getTipJoc() == 0)
                {
                    rezultats.Add(rezultate[i]);
                }
            }


            return rezultats;
        }

        public List<Rezultat> getPopice(int idUtilizator)
        {

            List<Rezultat> rezultats = new List<Rezultat>();

            for (int i = 0; i < rezultate.Count; i++)
            {
                if (rezultate[i].getIdUtilizator() == idUtilizator && rezultate[i].getTipJoc() == 1)
                {
                    rezultats.Add(rezultate[i]);
                }
            }


            return rezultats;
        }


    }
}
