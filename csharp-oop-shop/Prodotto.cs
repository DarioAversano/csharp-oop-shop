using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_oop_shop
{
    public class Prodotto
    {
        // ATTRIBUTI / CARATTESTICHE
        private int codice;
        private string nome;
        private string descrizione;
        private float prezzo;
        private float iva;

        // STATI
        //private bool accesa;
        //private int numero;
        //private string stringa;

        // COSTRUTTORE
        public Prodotto(int codice, string nome, string descrizione, float prezzo, float iva)
        {
            this.codice = codice;
            this.nome = nome;
            this.descrizione = descrizione;
            this.prezzo = prezzo;
            this.iva = iva;
            //???(?);

            //this.accesa = false;
        }
    }
}
