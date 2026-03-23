using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teorieIncapsulare
{
    internal class ContBancar
    {
        private string titular;
        private string iBAN;
        private double sold;
        private string moneda;

        public ContBancar(string titular, string iBAN, double Sold, string moneda) { 
            Titular = titular;
            IBAN = iBAN;
            sold = Sold;
            Moneda = moneda;
        }
        public string Titular
        {
            get { return titular; }
            set
            {
                if (value.Length == 0)
                {
                    throw new ArgumentException("Titularul nu poate fi empty");
                }
                for (int i = 0; i < value.Length; i++)
                {
                    if (!char.IsLetter(value[i]))
                    {
                        throw new ArgumentException("Titularul poate fi format numai din litere");
                    }
                }
                titular = value;
            }
        }

        public string IBAN
        {
            get { return iBAN; }
            set { 
                if(value.Length < 12)
                {
                    throw new ArgumentException("IBAN prea scurt");
                }
                iBAN = value;
            }
        }

        public string Moneda
        {
            get { return moneda; }
            set
            {
                if(value != "EUR" || value != "USD" || value != "RON")
                {
                    throw new ArgumentException("Tip incorect de moneda");
                }
                moneda = value;
            }
        }
    }
}
