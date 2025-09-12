using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibPizza
{
    public class Commande
    {
        private Client monClient;
        private static int compteurCommande = 1;
        private int numCommande;
        private bool aEmporter;
        private List<Pizza> listePizzas = new List<Pizza>();
        private DateTime dateCommande;

        public Commande(Client client, bool emporter, Pizza pizza, int quantite)
        {
            this.monClient = monClient;
            this.aEmporter = aEmporter;
            this.numCommande = compteurCommande++;
            this.dateCommande = DateTime.Now;
            for (int i = 0; i < quantite; i++)
            {
                this.listePizzas.Add(pizza);
            }
        }

        public Client MonClient
        {
            get { return monClient; }
            set { monClient = value; }
        }

        public bool AEmporter
        {
            get { return aEmporter; }
            set { aEmporter = value; }
        }

        public int NumCommande
        {
            get { return numCommande; }
        }

        public string AjouterPizza(Pizza p)
        {
            listePizzas.Add(p);
            return "Pizza " + p.GetNomPizza() + " ajoutée à la commande.";
        }

        public int GetQuantiteTotalePizzas()
        {
            return listePizzas.Count;
        }
        public override string ToString()
        {
            string pizzas = "";
            foreach (Pizza p in listePizzas)
            {
                pizzas += p.GetNomPizza() + ", ";
            }
            if (pizzas.Length > 2)
            {
                pizzas = pizzas.Substring(0, pizzas.Length - 2);
            }
            return $"Commande n°{numCommande} pour {monClient.prenom} {monClient.nom} ({(aEmporter ? "à emporter" : "sur place")}) le {dateCommande} : {GetQuantiteTotalePizzas()} pizza(s) [{pizzas}]";
        }
    }
}

