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
    }
}
