using teorieIncapsulare;

internal class Program
{
    private static void Main(string[] args)
    {
        //Masina m1 = new Masina();
        //m1.marca = "BMW";
        //m1.model = "M4";
        //m1.anFabricare = 2007;
        //m1.culoare = "negru";
        //m1.caiPutere = 200;
        //m1.greutate = 1350;

        //    Masina m2 = new();
        //    m2.marca = "Skoda";
        //    m2.model = "Yeti";
        //    m2.anFabricare = 2013;
        //    m2.culoare = "bej";
        //    m2.caiPutere = 135;
        //    m2.greutate = 1560;

        //    Masina m3 = new();
        //    m3.marca = "Dacia";
        //    m3.model = "Logan";
        //    m3.model = "Logan";
        //    m3.anFabricare = 2004;
        //    m3.culoare = "galben";
        //    m3.caiPutere = 110;
        //    m3.greutate = 1050;

        //    Masina m4 = new();
        //    m4.marca = "Honda";
        //    m4.model = "CRV";
        //    m4.anFabricare = 2020;
        //    m4.culoare = "visiniu";
        //    m4.caiPutere = 165;
        //    m4.greutate = 1680;

        //    Masina m5 = new();
        //    m5.marca = "Ford";
        //    m5.model = "Focus";
        //    m5.anFabricare = 2006;
        //    m5.culoare = "albastru";
        //    m5.caiPutere = 120;
        //    m5.greutate = 1100;

        //    m5.anFabricare = -9;
        //

        try
        {
            Caine x = new Caine("Pheoby", "masculin", 6, 30, 7, "Shi Tzu", "tarcat", false);
            x.AfisareDetalii();
        }
        catch (ArgumentException ex) { 
            Console.WriteLine(ex.Message);
        }

        
    }
}