using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_oop_shop
{
    public class Prodotto
    {
        private int codice;
        private string nome;
        private string descrizione;
        private int prezzo;
        private int iva;


        //Costruttori di default
        public Prodotto() { }

        //Costruttori con parametri
        public Prodotto(int codice, string name, string description, int price, int iva) { 
            this.codice = codice;
            this.nome = name;
            this.descrizione = description;
            this.prezzo = price;
            this.iva = iva;           
        }
        //Getter
        public int getCodice()
        {
            return codice; 
        }

        public void setNome(string name)
        {
            nome = name;
        }
    }
}
