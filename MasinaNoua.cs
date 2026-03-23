using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teorieIncapsulare
{
    internal class MasinaNoua
    {
        private string marca = string.Empty;
        private string model = string.Empty;
        private int anFabricatie;
        private string combustibil = string.Empty;
        private double pret;
        private int kilometri;
        private string culoare = string.Empty;

        public MasinaNoua(string marca, string model, int anFabricatie, string combustibil, double pret, int kilometri, string culoare)
        {
            Marca = marca;
            Model = model;
            AnFabricatie = anFabricatie;
            Combustibil = combustibil;
            Pret = pret;
            Kilometri = kilometri;
            Culoare = culoare;
        }

        public string Marca
        {
            get { return marca; }
            set
            {
                if (value.Length == 0)
                {
                    throw new ArgumentException("Marca nu poate fi empty");
                }
                for (int i = 0; i < value.Length; i++) {
                    if (!char.IsLetter(value[i])) {
                        throw new ArgumentException("Marca poate contine doar litere");
                    }
                }
                marca = value;
            }
        }
        public string Model
        {
            get { return model; }
            set
            {
                if (value.Length == 0)
                {
                    throw new ArgumentException("Modelul nu poate fi empty");
                }
                model = value;
            }
        }

        public int AnFabricatie
        {
            get { return anFabricatie; }
            set
            {
                if (value < 1880)
                {
                    throw new ArgumentException("Anul de fabricare este prea mic");
                }
                if (value > 2026)
                {
                    throw new ArgumentException("Anul de fabricare este prea mare");
                }
                anFabricatie = value;
            }
        }

        public string Combustibil
        {
            get { return  combustibil; }
            set
            {
                if(value.Length == 0)
                {
                    throw new ArgumentException("Campul <combustibil> nu poate fi empty");
                }
                if(value != "diesel" && value != "benzina" && value != "GPL")
                {
                    throw new ArgumentException("tip de combustibil necunoscut pentru un automobil");
                }
                combustibil = value;
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

        public int Kilometri
        {
            get { return kilometri; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Kilometrajul nu poate fi negativ");
                }
                kilometri = value;
            }
        }

        public string Culoare
        {
            get { return culoare; }
            set
            {
                if (value.Length == 0)
                {
                    throw new ArgumentException("Campul <culoare> nu poate fi empty");
                }
                for (int i = 0; i < value.Length; i++) {
                    if (char.IsLetter(value[i]))
                    {
                        throw new ArgumentException("Campul <culoare> poate contine numai litere");
                    }
                }
                culoare = value;
            }
        }
    }
}
