using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Jocuri.Models
{
    internal class Utilizator
    {

        private int id;
        private string email;
        private string name;
        private string password;

        public Utilizator(int id, string email, string name, string password)
        {
            this.id = id;
            this.email = email;
            this.name = name;
            this.password = password;
        }

        public Utilizator(string textul) {

            string[] prop = textul.Split(';');

            this.id = int.Parse(prop[0]);
            this.email = prop[1];
            this.name = prop[2];
            this.password = prop[3];
        
        }

        public int getId() { 
            return id; 
        }

        public string getEmail()
        {
            return email;
        }

        public string getName()
        {
            return name;
        }

        public string getPassword()
        {
            return password;
        }

    }
}
