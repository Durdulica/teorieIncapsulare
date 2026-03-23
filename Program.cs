using teorieIncapsulare;

internal class Program
{
    private static void Main(string[] args)
    {
        try
        {
<<<<<<< HEAD
            Caine x = new Caine("Pheoby", "masculin", 6, 30, 7, "Shi Tzu", "tarcat", false);
            x.AfisareDetalii();
        }
        catch (ArgumentException ex) { 
            Console.WriteLine(ex.Message);
        }

        
=======
            Masina masinaValida = new Masina("BMW", "M4", 2020, 480, 1725, "gri");
            Console.WriteLine(
                $"Masina valida: {masinaValida.Marca} {masinaValida.Model}, {masinaValida.AnFabricare}");

            Masina masinaInvalida = new Masina("B", "M4", 2020, 20, 300, "gri1");
            Console.WriteLine(masinaInvalida.Model);
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine($"Eroare: {ex.Message}");
        }
>>>>>>> 46b1dd23dadcafb9654c692632ad8de7f7a8a2cb
    }
}
