using teorieIncapsulare;

internal class Program
{
    private static void Main(string[] args)
    {
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
