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
        public Prodotto(string name, string description, int price)
        {
            this.codice = CalcolaCodice();
            this.nome = name;
            this.descrizione = description;
            this.prezzo = price;
            this.iva = getIva();
        }


        //Getter
        public int getCodice()
        {
            return codice;
        }

        public string getNome()
        {
            return nome;
        }

        public string getDescrizione()
        {
            return descrizione;
        }

        public int getPrezzoSenzaIva()
        {
            return prezzo - iva;
        }

        public int getPrezzoConIva()
        {
            return prezzo;
        }

        public int getIva()
        { 
           return CalcoloIva(prezzo);
        }



        //Setter
        public void setNome(string name)
        {
            nome = name;
        }

        public void setDescrizione(string description)
        {
            descrizione = description;
        }

        public void setPrezzo(int price)
        {
            this.prezzo = price;
            iva = CalcoloIva(price);
        }

        public void setPrezzoConIva(int price)
        {
            iva = CalcoloIva(price);
            prezzo = CalcoloPrezzoConIva(price);
        }



        //Metodi

        private int CalcolaCodice()
        {
            Random r = new Random();
            return r.Next(0, 9999999);
        }

        private int CalcoloIva(int price)
        {
            return (price * 20) / 100;
        }

        private int CalcoloPrezzoConIva(int price)
        {
            return price - (price * 20 /100);
        }
    }
}
