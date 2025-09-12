namespace LibPizza
{
    public class Client
    {
        private string Adresse;
        private int Codepostal;
        private string Nom;
        private string Prenom;
        private int Telephone;
        private string Ville;

        public Client(string adresse, int codepostal, string nom, string prenom, int telephone, string ville)
        {
            this.Adresse = adresse;
            this.Codepostal = codepostal;
            this.Nom = nom;
            this.Prenom = prenom;
            this.Telephone = telephone;
            this.Ville = ville;
        }

        public string adresse
        {
            get { return Adresse; }
            set { Adresse = value; }
        }

        public int codepostal
        {
            get { return Codepostal; }
            set { Codepostal = value; }
        }

        public string nom
        {
            get { return Nom; }
            set { Nom = value; }
        }

        public string prenom
        {
            get { return Prenom; }
            set { Prenom = value; }
        }

        public int telephone
        {
            get { return Telephone; }
            set { Telephone = value; }
        }

        public string ville
        {
            get { return Ville; }
            set { Ville = value; }
        }

    }
}
