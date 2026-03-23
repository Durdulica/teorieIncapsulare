namespace teorieIncapsulare
{
    public class Masina
    {
        private string marca = string.Empty;
        private string model = string.Empty;
        private int anFabricare;
        private int caiPutere;
        private int greutate;
        private string culoare = string.Empty;

        public Masina()
        {
            marca = "Necunoscuta";
            model = "Necunoscut";
            culoare = "Necunoscuta";
            Console.WriteLine("constructor fara parametri");
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
            get { return marca; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Marca nu poate fi goala");
                }

                string text = value.Trim();

                if (text.Length < 2 || text.Length > 30)
                {
                    throw new ArgumentException("Marca trebuie sa aiba intre 2 si 30 caractere");
                }

                foreach (char caracter in text)
                {
                    bool caracterPermis = char.IsLetter(caracter) || caracter == ' ' || caracter == '-';

                    if (!caracterPermis)
                    {
                        throw new ArgumentException("Marca contine caractere nepermise");
                    }
                }

                marca = text;
            }
        }

        public string Model
        {
            get { return model; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Modelul nu poate fi gol");
                }

                string text = value.Trim();

                if (text.Length < 1 || text.Length > 40)
                {
                    throw new ArgumentException("Modelul trebuie sa aiba intre 1 si 40 caractere");
                }

                foreach (char caracter in text)
                {
                    bool caracterPermis = char.IsLetterOrDigit(caracter) || caracter == ' ' || caracter == '-' || caracter == '.';

                    if (!caracterPermis)
                    {
                        throw new ArgumentException("Modelul contine caractere nepermise");
                    }
                }

                model = text;
            }
        }

        public int AnFabricare
        {
            get { return anFabricare; }
            set
            {
                if (value < 1886 || value > DateTime.Now.Year)
                {
                    throw new ArgumentException("Anul fabricarii nu este corect");
                }

                if (value < 1950)
                {
                    throw new ArgumentException("Anul fabricarii este prea mic pentru acest exemplu");
                }

                anFabricare = value;
            }
        }

        public int CaiPutere
        {
            get { return caiPutere; }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Puterea trebuie sa fie mai mare decat 0");
                }

                if (value < 40 || value > 2000)
                {
                    throw new ArgumentException("Puterea trebuie sa fie intre 40 si 2000 CP");
                }

                caiPutere = value;
            }
        }

        public int Greutate
        {
            get { return greutate; }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Greutatea trebuie sa fie mai mare decat 0");
                }

                if (value < 500 || value > 4000)
                {
                    throw new ArgumentException("Greutatea trebuie sa fie intre 500 si 4000 kg");
                }

                greutate = value;
            }
        }

        public string Culoare
        {
            get { return culoare; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Culoarea nu poate fi goala");
                }

                string text = value.Trim();

                if (text.Length < 3 || text.Length > 20)
                {
                    throw new ArgumentException("Culoarea trebuie sa aiba intre 3 si 20 caractere");
                }

                foreach (char caracter in text)
                {
                    bool caracterPermis = char.IsLetter(caracter) || caracter == ' ' || caracter == '-';

                    if (!caracterPermis)
                    {
                        throw new ArgumentException("Culoarea contine caractere nepermise");
                    }
                }

                culoare = text;
            }
        }
    }
}