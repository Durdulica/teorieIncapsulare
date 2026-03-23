using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teorieIncapsulare
{
    internal class Pacient
    {
        private string nume;
        private int varsta;
        private double greutate;  //kg
        private int inaltime; //cm
        private string grupaSange;

        public Pacient(string nume, int varsta, double greutate, int inaltime, string grupaSange)
        {
            Nume = nume;
            Varsta = varsta;
            Greutate = greutate;
            Inaltime = inaltime;
            GrupaSange = grupaSange;
        }
        public string Nume
        {
            get { return nume; }
            set
            {
                if (value.Length == 0)
                {
                    throw new ArgumentException("Numele nu poate fi empty");
                }
                for (int i = 0; i < value.Length; i++)
                {
                    if (!char.IsLetter(value[i]))
                    {
                        throw new ArgumentException("Numele poate contine numai litere");
                    }
                }
                nume = value;
            }
        }

        public int Varsta
        {
            get { return varsta; }

            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Varsta nu poate fi negativa");
                }
                if (value > 120) {
                    throw new ArgumentException("Varsta este prea mare");
                }
                varsta = value;
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

        public int Inaltime
        {
            get { return inaltime; }
            set
            {
                if(value < 30)
                {
                    throw new ArgumentException("Inaltime prea mica");
                }
                if (value > 230)
                {
                    throw new ArgumentException("Inaltime prea mare");
                }
                inaltime = value;
            }
        }

        public string GrupaSange
        {
            get { return grupaSange; }
            set
            {
                if(value.Length == 0)
                {
                    throw new ArgumentException("Campul <grupa de sange> nu poate fi empty");
                }
                if(value != "O-" && value != "O+" && value != "A-" && value != "A+" && value != "B-" && value != "B+" && value != "AB-" && value != "AB+")
                {
                    throw new ArgumentException("grupa de sange necunoscuta");
                }
                grupaSange = value;
            }
        }
    }
}
