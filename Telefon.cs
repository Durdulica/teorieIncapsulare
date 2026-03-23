using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teorieIncapsulare
{
    internal class Telefon
    {
        private string brand;
        private string model;
        private int memorieGB;
        private double pret;
        private string culoare;

        public string Brand
        {
            get { return brand; }
            set
            {
                if (value.Length == 0)
                {
                    throw new ArgumentException("Brandul nu poate fi empty");
                }
                brand = value;
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

        public int MemorieGB
        {
            get { return memorieGB; }
            set
            {
                if(value < 16)
                {
                    throw new ArgumentException("Memorie de tip GB prea mica");
                }
                if(value > 1024)
                {
                    throw new ArgumentException("Memorie de tip GB prea mare");
                }
                memorieGB = value;
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

        public string Culoare
        {
            get { return culoare; }
            set
            {
                if( value.Length == 0)
                {
                    throw new ArgumentException("Culoarea nu poate fi empty");
                }


                for (int i = 0; i < value.Length; i++)
                {
                    if (!char.IsLetter(value[i]))
                    {
                        throw new ArgumentException("Culoarea poate fi formata numai din litere");
                    }
                }
                culoare = value;
            }
        }
    }
}
