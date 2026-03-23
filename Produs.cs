using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teorieIncapsulare
{
    internal class Produs
    {   //cel mai usoar de validat a fost proprietatea pret, deoarece pretul nu poate fi negativ
        //cel mai greu de validata a fost proprietatea categorie, deoarece nu imi este clar in ce consta
        private string denumire;
        private double pret;
        private int stoc;
        private string categorie;
        private string codProdus;

        public Produs(string denumire, double pret, int stoc, string categorie, string codProdus)
        {
            Denumire = denumire;
            Pret = pret;
            Stoc = stoc;
            Categorie = categorie;
            CodProdus = codProdus;
        }

        public string Denumire
        {
            get {  return denumire; }
            set { 
                if(value.Length == 0)
                {
                    throw new ArgumentException("Produsul are nevoie de un nume");
                }
                denumire = value;
            }
        }

        public double Pret
        {
            get { return pret; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Pretul nu poate fi negativ");
                }
                pret = value;
            }
        }

        public int Stoc
        {
            get { return stoc; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Stocul nu poate fi negativ");
                }
                stoc = value;
            }
        }

        public string Categorie
        {
            get { return categorie; }
            set
            {
                if (value.Length == 0)
                {
                    throw new ArgumentException("Categoria nu poate fi empty");
                }
                categorie = value;
            }
        }

        public string CodProdus
        {
            get { return codProdus; }
            set
            {
                if (value.Length == 0)
                {
                    throw new ArgumentException("Codul produsului nu poate fi empty");
                }
                codProdus = value;
            }
        }
    }
}
