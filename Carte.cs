using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teorieIncapsulare
{
    internal class Carte
    {
        private string titlu;
        private string autor;
        private int anAparitie;
        private int numarPagini;
        private double pret;

        
        public Carte(string titlu, string autor, int anAparitie, int numarPagini, double pret)
        {
            Titlu = titlu;
            Autor = autor;
            AnAparitie = anAparitie;
            NumarPagini = numarPagini;
            Pret = pret;
        }

        public string Titlu
        {
            get { return titlu; }
            set
            {
                if (value.Length == 0)
                {
                    throw new ArgumentException("Titlul nu poate fi empty");
                }
                titlu = value;
            }
        }

        public string Autor
        {
            get { return autor; }
            set
            {
                if (value.Length == 0) 
                {
                    throw new ArgumentException("Autorul nu poate fi empty");
                }
                autor = value;
                for (int i = 0; i < value.Length; i++)
                {
                    if (!char.IsLetter(value[i]))
                    {
                        throw new ArgumentException("Autorul poate fi format numai din litere");
                    }
                }
                autor = value;
            }
        }

        public int AnAparitie
        {
            get { return anAparitie; }
            set
            {
                if (value > 2026)
                {
                    throw new ArgumentException("An invalid");
                }
                anAparitie = value;
            }
        }

        public int NumarPagini
        {
            get { return numarPagini; }
            set
            {
                if (value < 1)
                {
                    throw new ArgumentException("Numar de pagini invalid");
                }
                numarPagini = value;
            }
        }

        public double Pret
        {
            get { return pret; }
            set
            {
                if(pret < 0)
                {
                    throw new ArgumentException("Pretul nu poate fi negativ");
                }
                pret = value;
            }
        }
    }
}
