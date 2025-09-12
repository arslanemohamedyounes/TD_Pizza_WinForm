using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibPizza
{
    public class Pizza
    {
        private string nom;

        public Pizza(string nom)
        {
            this.nom = nom;
        }

        public string GetNomPizza()
        {
            return nom;
        }

        public string pizza
        {
            get { return nom; }
            set { nom = value; }
        }
    
    }
}
