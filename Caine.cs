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
        private string gen;
        private int varsta;
        private int inaltime;
        private double greutate;   
        private string rasa;
        private string culoareBlana;
        private bool pedigree;

        public Caine()
        {
            nume = "Necunoscut";
            gen = "Necunoscut";
            varsta = 0;
            inaltime = 0;
            greutate = 0;
            rasa = "Necunoscut";
            culoareBlana = "Necunoscut";
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
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Campul <nume> nu poate fi empty");
                }

                value = value.Trim();

                if(value.Length < 2 || value.Length > 30)
                {
                    throw new ArgumentException("Numele trebuie sa aiba intre 2 si 30 de caractere");
                }

                foreach (char caracter in value)
                {
                    bool caracterPermis = char.IsLetter(caracter) || caracter == ' ' || caracter == '-';

                    if (!caracterPermis)
                    {
                        throw new ArgumentException("Numele contine caractere nepermise");
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
                if(string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Genul nu poate fi gol");
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
            set
            {
                if (value < 0 || value > 20)
                {
                    throw new ArgumentException("Varsta trebuie sa fie intre 1 si 20 de ani");
                }

                varsta = value;
            }
        }

        public int Inaltime
        {
            get { return inaltime; }
            set
            {
                if(value < 10 || value > 150)
                {
                    throw new ArgumentException("Inaltimea trebuie sa fie intre 10 si 150 de centimetri");
                }

                inaltime = value;
            }
        }

        public double Greutate
        {
            get { return greutate; }
            set
            {
                if(value <= 0)
                {
                    throw new ArgumentException("Greutatea trebuie sa fie mai mare decat 0 de kilograme");
                }
                
                if(value > 150)
                {
                    throw new ArgumentException("Greutatea trebuie sa fie mai mica decat 150 de kilograme");
                }

                greutate = value;
            }
        }

        public string Rasa
        {
            get { return rasa; }
            set {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Rasa nu poate fi goala");
                }
                
                value = value.Trim();

                if (value.Length < 2 || value.Length > 30)
                {
                    throw new ArgumentException("Rasa trebuie sa contina intre 2 si 30 de caractere");
                }

                foreach (char caracter in value)
                {
                    bool caracterePermise = char.IsLetter(caracter) || caracter == ' ' || caracter == '-';

                    if (!caracterePermise)
                    {
                        throw new ArgumentException("Rasa contine caractere nepermise");
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
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Culoarea blanii nu poate fi goala");
                }

                if (value.Length < 2 || value.Length > 30)
                {
                    throw new ArgumentException("Culoarea blanii trebuie sa contina intre 2 si 30 de caractere");
                }

                foreach (char caracter in value)
                {
                    bool caracterPermis = char.IsLetter(caracter) || caracter == ' ' || caracter == '-';
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
