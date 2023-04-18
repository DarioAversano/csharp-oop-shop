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
    }
}





