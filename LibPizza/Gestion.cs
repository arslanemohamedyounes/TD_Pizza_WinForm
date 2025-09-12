using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibPizza
{
    public class Gestion
    {
        List<Commande> mesCommandes = new List<Commande>();
        List<Client> mesClients = new List<Client>();
        List<Pizza> mesPizzas = new List<Pizza>();
        public Gestion()
        {
            mesCommandes = new List<Commande>();
            mesClients = new List<Client>();
            mesPizzas = new List<Pizza>();
        }

        public string AjouterCommande(Commande rt)
        {
            mesCommandes.Add(rt);
            return "Commande ajoutée.";
        }

        public string AjouterNouveauClient(Client cl)
        {
            mesClients.Add(cl);
            return "Client ajouté.";
        }

        public string AjouterNouvellePizza(Pizza p)
        {
            mesPizzas.Add(p);
            return "Pizza ajoutée.";
        }

        public string AjouterPizza(int numCommande, Pizza p)
        {
            foreach (Commande c in mesCommandes)
            {
                if (c.NumCommande == numCommande)
                {
                    c.AjouterPizza(p);
                    return "Pizza ajoutée à la commande.";
                }
            }
            return "Commande non trouvée.";
        }

        public string GetListClients()
        {
            string liste = "";
            foreach (Client c in mesClients)
            {
                liste += c.ToString() + "\n";
            }
            return liste;
        }

        public string GetListPizzas()
        {
            string liste = "";
            foreach (Pizza p in mesPizzas)
            {
                liste += p.ToString() + "\n";
            }
            return liste;
        }

        public string GetClient(string nom, string prenom, int telephone)
        {
            foreach (Client c in mesClients)
            {
                if (c.nom == nom && c.prenom == prenom && c.telephone == telephone)
                {
                    return c.ToString();
                }
            }
            return "Client non trouvé.";
        }

        public string GetPizza(string nomPizza)
        {
            foreach (Pizza p in mesPizzas)
            {
                if (p.GetNomPizza() == nomPizza)
                {
                    return p.ToString();
                }
            }
            return "Pizza non trouvée.";
        }

        public string GetCommande(int numCommande)
        {
            foreach (Commande c in mesCommandes)
            {
                if (c.NumCommande == numCommande)
                {
                    return c.ToString();
                }
            }
            return "Commande non trouvée.";
        }

        public string AfficherCommande()
        {
            string liste = "";
            foreach (Commande c in mesCommandes)
            {
                liste += c.ToString() + "\n";
            }
            return liste;
        }

    }
}
