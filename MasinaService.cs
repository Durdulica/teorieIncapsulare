using System;
using System.Collections.Generic;

namespace teorieIncapsulare
{
    public class MasinaService
    {
        private readonly List<Masina> masini;

        public MasinaService()
        {
            masini = new List<Masina>
            {
                new Masina("BMW", "M4", 2020, 480, 1725, "gri"),
                new Masina("Audi", "A4", 2018, 190, 1500, "negru"),
                new Masina("Mercedes", "C220", 2021, 200, 1680, "alb"),
                new Masina("Dacia", "Logan", 2019, 90, 1150, "albastru"),
                new Masina("Volkswagen", "Golf", 2017, 150, 1340, "rosu"),
                new Masina("Porsche", "911", 2022, 385, 1565, "galben")
            };
        }

        public void AfiseazaToateMasinile()
        {
            Console.WriteLine("Lista initiala de masini:");

            foreach (Masina masina in masini)
            {
                Console.WriteLine(
                    $"- {masina.Marca} {masina.Model}, an {masina.AnFabricare}, {masina.CaiPutere} CP, {masina.Greutate} kg, culoare {masina.Culoare}");
            }
        }

        public void AfiseazaExercitii()
        {
            Console.WriteLine();
            Console.WriteLine("Exercitii cu liste:");
            Console.WriteLine("1. TODO: Afiseaza toate masinile cu mai mult de 200 CP.");
            Console.WriteLine("2. TODO: Afiseaza toate masinile fabricate dupa anul 2019.");
            Console.WriteLine("3. TODO: Calculeaza suma cailor putere pentru toate masinile.");
            Console.WriteLine("4. TODO: Calculeaza greutatea medie a masinilor.");
            Console.WriteLine("5. TODO: Gaseste masina cu cei mai multi cai putere.");
            Console.WriteLine("6. TODO: Gaseste masina cea mai veche.");
            Console.WriteLine("7. TODO: Numara cate masini au culoarea \"gri\".");
            Console.WriteLine("8. TODO: Afiseaza doar marcile masinilor, fara duplicate.");
            Console.WriteLine("9. TODO: Sorteaza masinile crescator dupa anul fabricarii.");
            Console.WriteLine("10. TODO: Sorteaza masinile descrescator dupa cai putere.");
            Console.WriteLine("11. TODO: Verifica daca exista cel putin o masina cu peste 400 CP.");
            Console.WriteLine("12. TODO: Verifica daca toate masinile au greutatea mai mare de 1000 kg.");
            Console.WriteLine("13. TODO: Creeaza o lista noua doar cu masinile de culoare alba sau gri.");
            Console.WriteLine("14. TODO: Afiseaza prima masina care are modelul \"Golf\".");
            Console.WriteLine("15. TODO: Grupeaza masinile dupa culoare si afiseaza cate sunt din fiecare culoare.");
        }

        public List<Masina> GetMasini()
        {
            return masini;
        }

        public void AfiseazaMasiniPeste200CP()
        {
            foreach(Masina m in masini)
            {
                if(m.CaiPutere > 200)
                {
                    Console.WriteLine($"{m.Marca}, {m.Model}, an {m.AnFabricare}, {m.CaiPutere} CP, {m.Greutate} kg, {m.Culoare}");
                }
            }
        }

        public void AfiseazaMasiniFabricateDupa2019()
        {
            foreach(Masina m in masini)
            {
                if(m.AnFabricare > 2019)
                {
                    Console.WriteLine($"{m.Marca}, {m.Model}, an {m.AnFabricare}, {m.CaiPutere} CP, {m.Greutate} kg, {m.Culoare}");
                }
            }
        }

        public int SumaCaiPutere()
        {
            int suma = 0;
            foreach(Masina m in masini)
            {
                suma += m.CaiPutere;
            }
            return suma;
        }

        public double GreutateaMedie()
        {
            int suma = 0;
            foreach(Masina m in masini)
            {
                suma += m.Greutate;
            }

            return (double)suma / masini.Count;
        }

        public Masina MaxCaiPutere()
        {
            int maxim = int.MinValue;
            Masina aux = new Masina();

            foreach (Masina m in masini)
            {
                if (m.CaiPutere > maxim)
                {
                    maxim = m.CaiPutere;
                    aux = m;
                }
            }

            return aux;
        }

        public Masina CeaMaiVeche()
        {
            int minim = int.MaxValue;
            Masina aux = new Masina();

            foreach (Masina m in masini)
            {
                if (m.AnFabricare < minim)
                {
                    minim = m.AnFabricare;
                    aux = m;
                }
            }

            return aux;
        }

        public int CtMasiniGri()
        {
            int index = 0;
            foreach(Masina m in masini)
            {
                if(m.Culoare.ToLower() == "gri")
                {
                    index++;
                }
            }
            return index;
        }

        public void AfisareMarci()
        {
            string rez = string.Empty;

            foreach (Masina m in masini)
            {
                if (!rez.Contains(m.Marca))
                {
                    rez += m.Marca + " ";
                }
            }

            rez = rez.TrimEnd();
            Console.WriteLine(rez);
        }

        public void SortareCrescAnFabricare()
        {
            for (int i = 0; i < masini.Count; i++) {
                for (int j = i + 1; j < masini.Count; j++)
                {
                    if (masini[j].AnFabricare < masini[i].AnFabricare)
                    {
                        Masina aux = masini[i];
                        masini[i] = masini[j];
                        masini[j] = aux;
                    }
                }
            }
        }

        public void SortareDescrescCaiPutere()
        {
            for (int i = 0; i < masini.Count; i++)
            {
                for (int j = i + 1; j < masini.Count; j++)
                {
                    if (masini[j].CaiPutere > masini[i].CaiPutere)
                    {
                        Masina aux = masini[i];
                        masini[i] = masini[j];
                        masini[j] = aux;
                    }
                }
            }
        }

        public bool ExistaMasinaPeste400CP()
        {
            foreach(Masina m in masini)
            {
                if(m.CaiPutere > 400)
                {
                    return true;
                }
            }
            return false;
        }

        public bool ToatePeste1000kg()
        {
            foreach(Masina m in masini)
            {
                if(m.Greutate <= 1000)
                {
                    return false;
                }
            }
            return true;
        }

        public List<Masina> nouaListaAlbSiGri()
        {
            List<Masina> rez = new List<Masina>();

            foreach (Masina m in masini)
            {
                if (m.Culoare.ToLower() == "gri" || m.Culoare.ToLower() == "alb")
                {
                    rez.Add(m);
                }
            }

            return rez;
        }

        public void AfisarePrimulGolf()
        {
            foreach(Masina m in masini)
            {
                if(m.Model.ToLower() == "golf")
                {
                    Console.WriteLine($"{m.Marca}, {m.Model}, an {m.AnFabricare}, {m.CaiPutere} CP, {m.Greutate} kg, {m.Culoare}");
                    return;
                }
            }
            Console.WriteLine("Nu este niciul model Golf in service");
        }

        public void GrupareCuloare()
        {
            for (int i = 0; i < masini.Count; i++)
            {
                for (int j = i + 1; j < masini.Count; j++)
                {
                    if (masini[i].Culoare.CompareTo(masini[i + 1].Culoare) > 0)
                    {
                        Masina aux = masini[i];
                        masini[i] = masini[j];
                        masini[j] = aux;
                    }
                }
            }
        }

        public void AfisareCntCulori()
        {
            for(int i = 0; i < masini.Count; i++)
            {
                Console.Write(masini[i].Culoare + " ");
                int ct = 1;
                if (i < masini.Count - 1)
                {
                    while (masini[i].Culoare.CompareTo(masini[i + 1].Culoare) == 0)
                    {
                        i++;
                        ct++;
                    }
                }
                Console.WriteLine(ct);
            }
        }

        public void AdaugareMasina(string marca, string model, int anFabricare, int caiPutere, int greutate, string culoare)
        {
            if(masini.Count + 1 > masini.Capacity)
            {
                throw new ArgumentException("Service plin");
            }

            foreach (Masina m in masini) {
                if (m.Marca.ToLower() == marca.ToLower() && m.Model.ToLower() == model.ToLower()) { 
                    throw new ArgumentException("Aceasta masina se afla deja in service");
                }
            }

            Masina newCar = new Masina(marca, model, anFabricare, caiPutere, greutate, culoare);

            masini.Add(newCar);
        }

        public void StergereMasina(string marca, string model)
        {
            for(int i = 0; i < masini.Count; i++)
            {
                if (masini[i].Marca.CompareTo(marca) == 0 && masini[i].Model.CompareTo(model) == 0)
                {
                    masini.RemoveAt(i);
                }
            }
        }
    }
}
