namespace csharp_oop_shop
{
    public class Prodottoproperties
    {
        // ATTRIBUTI con PROPERTIES

        private int codice;
        public int Codice { get { return this.codice; } }

        private string nome;
        public string Nome { get { return this.nome; } set { this.nome = value; } }

        private string descrizione;
        public string Descrizione { get { return this.descrizione; } set { this.descrizione = value; } }

        private float prezzo;
        public float Prezzo { get { return this.prezzo; } set { this.prezzo = value; } }

        private float iva;
        public float Iva { get { return this.iva; } set { this.iva = value; } }


        // COSTRUTTORE
        public Prodottoproperties(string nome, string descrizione, int prezzo, float iva)
        {
            Random codice = new Random();
            int randomCode = codice.Next(100, 1000);

            this.codice = randomCode;

            this.nome = nome;
            this.descrizione = descrizione;
            this.prezzo = prezzo;
            this.iva = iva;
        }

        public Prodottoproperties(string nome, string descrizione, float iva)
        {
            Random codice = new Random();
            int randomCode = codice.Next(100, 1000);

            this.codice = randomCode;

            this.nome = nome;
            this.descrizione = descrizione;
            this.prezzo = 0.01f;
            this.iva = iva;
        }










    }

}



