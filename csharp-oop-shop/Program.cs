// See https://aka.ms/new-console-template for more information
//creare la classe Prodotto che gestisce i prodotti del vostro shop.
using csharp_oop_shop;
using System.Data.Common;
using System.Diagnostics;
using System.Xml.Linq;


Prodotto p1= new Prodotto("Candela", "Candela Profumata", 20);
Prodotto p2 = new Prodotto("Peso", "Strumento per allenare i bicipiti", 37);
Prodotto p3 = new Prodotto("Bilancia", "Strumento per misurare il peso", 93);
Prodotto p4 = new Prodotto("Vetril", "Prodotto per pulire i vetri", 6);
Prodotto p5 = new Prodotto("Pistola", "Arma da fuoco", 870);




Console.WriteLine("Prodotto 1: " + p1.getNome());
Console.WriteLine("Codice prodotto: " + p1.getCodice());
Console.WriteLine("Descrizione: " + p1.getDescrizione());
Console.WriteLine("Prezzo iva compresa: " + p1.getPrezzoConIva());
Console.WriteLine("Iva: " + p1.getIva());
Console.WriteLine("Prezzo senza iva: " + p1.getPrezzoSenzaIva());

Console.WriteLine();
Console.WriteLine();


Console.WriteLine("Prodotto 2: " + p2.getNome());
Console.WriteLine("Codice prodotto: " + p2.getCodice());
Console.WriteLine("Descrizione: " + p2.getDescrizione());
Console.WriteLine("Prezzo iva compresa: " + p2.getPrezzoConIva());
Console.WriteLine("Iva: " + p2.getIva());
Console.WriteLine("Prezzo senza iva: " + p2.getPrezzoSenzaIva());


Console.WriteLine();
Console.WriteLine();


Console.WriteLine("Prodotto 3: " + p3.getNome());
Console.WriteLine("Codice prodotto: " + p3.getCodice());
Console.WriteLine("Descrizione: " + p3.getDescrizione());
Console.WriteLine("Prezzo iva compresa: " + p3.getPrezzoConIva());
Console.WriteLine("Iva: " + p3.getIva());
Console.WriteLine("Prezzo senza iva: " + p3.getPrezzoSenzaIva());

Console.WriteLine();
Console.WriteLine();


Console.WriteLine("Prodotto 4: " + p4.getNome());
Console.WriteLine("Codice prodotto: " + p4.getCodice());
Console.WriteLine("Descrizione: " + p4.getDescrizione());
Console.WriteLine("Prezzo iva compresa: " + p4.getPrezzoConIva());
Console.WriteLine("Iva: " + p4.getIva());
Console.WriteLine("Prezzo senza iva: " + p4.getPrezzoSenzaIva());