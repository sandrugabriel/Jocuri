using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace Jocuri.Models
{
    internal class Rezultat
    {

        private int id;
        private int tipJoc;
        private int idUtilizator;
        private int punctraj;
        private DateTime data;

        public Rezultat(int id, int tipJoc, int idUtilizator, int punctraj, DateTime data)
        {
            this.id = id;
            this.tipJoc = tipJoc;
            this.idUtilizator = idUtilizator;
            this.punctraj = punctraj;
            this.data = data;
        }

        public Rezultat(string textul) {

            string[] prop = textul.Split(';');

            this.id = int.Parse(prop[0]);
            this.tipJoc = int.Parse(prop[1]);
            this.idUtilizator = int.Parse(prop[2]);
            this.punctraj= int.Parse(prop[3]);
            this.data = DateTime.Parse(prop[4]);
        
        }

        public int getId()
        {
            return id;
        }

        public int getTipJoc()
        {
            return tipJoc;
        }

        public int getIdUtilizator()
        {
            return idUtilizator;
        }

        public int getpunctaj()
        {
            return punctraj;
        }

        public DateTime getData()
        {
            return data;
        }


    }
}
