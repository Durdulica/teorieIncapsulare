using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//todo:Constructori
// este o metoda ce se apeleaza automat la instantiere
// se poate supraincarca
//nu are tip returnat 
//are acelasi nume ca si clasa
// daca nu definim un constructor csharp "ne doneaza" unul automat
namespace teorieIncapsulare
{
    public class Masina
    {
        private string marca;
        private string model;
        private int anFabricare;
        private int caiPutere;
        private int greutate;
        private string culoare;


        public Masina()
        {
            Console.WriteLine("constructor fara parametrii");
        }

        public Masina(string marca, string model, int anFabricare, int caiPutere, int greutate, string culoare)
        {
            Marca = marca;
            Model = model;
            AnFabricare = anFabricare;
            CaiPutere = caiPutere;
            Greutate = greutate;
            Culoare = culoare;
        }

        public string Marca
        {
            get { return marca; } set
            {

                bool isEmpty = value.Length == 0;

                if (isEmpty)
                {
                    throw new ArgumentException("Marca nu poate fi empty");
                }
                marca = value;
            }
        }

        public string Model
        {
            get { return model; }
            set
            {
                bool isEmpty = value.Length == 0;

                if (isEmpty)
                {
                    throw new ArgumentException("Modelul nu poate fi empty");
                }
                model = value;
            }
        }

        public int AnFabricare
        {
            get { return anFabricare; }
            set
            {
                if (value < 0 || value > 2026)
                {
                    throw new ArgumentException("Anul fabricarii nu este corect");
                }
                anFabricare = value;
            }
        }

        public int CaiPutere
        {
            get { return caiPutere; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Puterea nu poate fi negativa");
                }
                caiPutere = value;
            }
        }

        public int Greutate
        {
            get { return greutate; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Greutatea nu poate fi negativa");
                }
                greutate = value;
            }
        }

        public string Culoare
        {
            get { return culoare; }
            set
            {
                if (value.Length == 0)
                {
                    throw new ArgumentException("Culoarea nu poate fi empty");
                }
                culoare = value;
            }
        }


    }
}
