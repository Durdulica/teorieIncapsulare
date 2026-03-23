using teorieIncapsulare;

internal class Program
{
    private static void Main(string[] args)
    {
        MasinaService masinaService = new MasinaService();

        masinaService.AfiseazaToateMasinile();
        masinaService.AfiseazaExercitii();

        Console.WriteLine();
        Console.WriteLine("Exemplu validare obiect:");

        try
        {
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
    }
}
