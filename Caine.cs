using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teorieIncapsulare
{
    internal class Caine
    {
        private string nume;
        private string gen;     //M/F
        private int varsta;     //ani
        private int inaltime;   //cm
        private double greutate;    //kg
        private string rasa;
        private string culoareBlana;
        private bool pedigree;

        public Caine()
        {
            nume = "";
            gen = "";
            varsta = 0;
            inaltime = 0;
            greutate = 0;
            rasa = "";
            culoareBlana = "";
            pedigree = false;
        }
        public Caine(string nume, string gen, int varsta, int inaltime, double greutate, string rasa, string culoareBlana, bool Pedigree)
        {   //constructorul cu parametri este util deoarece ne ajuta sa initializam mai usor variabilele din clasa
            Nume = nume;
            Gen = gen;
            Varsta = varsta;
            Inaltime = inaltime;
            Greutate = greutate;
            Rasa = rasa;
            CuloareBlana = culoareBlana;
            pedigree = Pedigree;
        }

        public string Nume
        {
            get { return nume; }
            set
            {
                if (value.Length == 0)
                {
                    throw new ArgumentException("Campul <nume> nu poate fi empty");
                }
                for (int i = 0; i < value.Length; i++) {
                    if (!char.IsLetter(value[i])) {
                        throw new ArgumentException("Campul <nume> poate contine numai litere");
                    }
                }
                nume = value;
            }
        }

        public string Gen
        {
            get { return gen; }
            set
            {
                if(value.Length == 0)
                {
                    throw new ArgumentException("Campul <gen> nu poate fi empty");
                }
                if(value != "masculin" && value != "feminin")
                {
                    throw new ArgumentException("Gen necunoscut");
                }
                gen = value;
            }
        }

        public int Varsta
        {
            get { return varsta; }
            set { 
                if(value < 0)
                {
                    throw new ArgumentException("Varsta nu poate fi negativa");
                }
                if(value > 20)
                {
                    throw new ArgumentException("Varsta este prea mare");
                }
                varsta = value;
            }
        }

        public int Inaltime
        {
            get { return inaltime; }
            set
            {
                if(value < 10)
                {
                    throw new ArgumentException("Inaltimea este prea mica");
                }
                if(value > 150)
                {
                    throw new ArgumentException("Inaltimea este prea mare");
                }
                inaltime = value;
            }
        }

        public double Greutate
        {
            get { return greutate; }
            set
            {
                if(value < 0)
                {
                    throw new ArgumentException("Greutatea nu poate fi negativa");
                }
                greutate = value;
            }
        }

        public string Rasa
        {
            get { return rasa; }
            set {
                if (value.Length == 0)
                {
                    throw new ArgumentException("Campul <rasa> nu poate fi empty");
                }
                for (int i = 0; i < value.Length; i++)
                {
                    if (!char.IsLetter(value[i]) && value[i] != ' ')
                    {
                        throw new ArgumentException("Campul <rasa> poate contine numai litere");
                    }
                }
                rasa = value;
            }
        }

        public string CuloareBlana
        {
            get { return culoareBlana; }
            set
            {
                if (value.Length == 0)
                {
                    throw new ArgumentException("Campul <culoare blana> nu poate fi empty");
                }
                for (int i = 0; i < value.Length; i++)
                {
                    if (!char.IsLetter(value[i]))
                    {
                        throw new ArgumentException("Campul <culoare blana> poate contine numai litere");
                    }
                }
                culoareBlana = value;
            }
        }

        public void AfisareDetalii()
        {
            Console.WriteLine("Numele cainelui: " + nume);
            Console.WriteLine("Genul cainelui: " + gen);
            Console.WriteLine("Varsta cainelui: " + varsta + " ani");
            Console.WriteLine("Inaltimea cainelui: " + inaltime + " cm");
            Console.WriteLine("Greutatea cainelui: " + greutate + " kg");
            Console.WriteLine("Rasa cainelui: " + rasa);
            Console.WriteLine("Culoarea blanii cainelui: " + culoareBlana);
            if (pedigree)
            {
                Console.WriteLine("Cainele ARE pedigree");
            }
            else
            {
                Console.WriteLine("Cainele NU are pedigree");
            }
        }
    }
}
