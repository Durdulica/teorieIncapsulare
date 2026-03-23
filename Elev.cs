using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teorieIncapsulare
{
    internal class Elev
    {
        private string nume;
        private string prenume;
        private int varsta;
        private int clasa;
        private double medie;

        public Elev(string nume, string prenume, int varsta, int clasa, double medie)
        {
            Nume = nume;
            Prenume = prenume;
            Varsta = varsta;
            Clasa = clasa;
            Medie = medie;
        }
        public string Nume
        {
            get { return nume; }
            set
            {
                if (value.Length == 0)
                {
                    throw new ArgumentException("nume nu poate fi empty");
                }
                for (int i = 0; i < value.Length; i++) {
                    if (!char.IsLetter(value[i]))
                    {
                        throw new ArgumentException("numele poate fi format numai din litere");
                    }
                }
                nume = value;
            }
        }

        public string Prenume
        {
            get { return prenume; }
            set
            {
                if (value.Length == 0)
                {
                    throw new ArgumentException("prenume nu poate fi empty");
                }
                for (int i = 0; i < value.Length; i++)
                {
                    if (!char.IsLetter(value[i]))
                    {
                        throw new ArgumentException("prenumele poate fi format numai din litere");
                    }
                }
                prenume = value;
            }
        }

        public int Varsta
        {
            get { return varsta; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("varsta nu poate fi negativa");
                }
                varsta = value;
            }
        }

        public int Clasa
        {
            get { return clasa; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Clasa nu poate fi negativa");
                }
                if (value > 12)
                {
                    throw new ArgumentException("Clasa este prea mare");
                }
                clasa = value;
            }
        }

        public double Medie
        {
            get { return medie; }
            set
            {
                if (value < 0.0)
                {
                    throw new ArgumentException("Media nu poate fi negativa");
                }
                if (value > 10.0)
                {
                    throw new ArgumentException("Media este prea mare");
                }
                medie = value;
            }
        }
    }
}
