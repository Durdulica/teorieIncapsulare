using teorieIncapsulare;

internal class Program
{
    private static void Main(string[] args)
    {

        //Masina m1 = new Masina("BMW","M3",2007,"benzina",5600,156132,"negru");
        //Masina m2 = new Masina("Skoda", "Yeti", 2013, "diesel", 5340, 134670, "visiniu");
        //Masina m3 = new Masina("Honda", "CRV", 2020, "benzina", 28000, 76000, "visiniu");
        //Masina m4 = new Masina("Dacia", "Logan", 2004, "GPL", 1500, 300000, "gri");
        //Masina m5 = new Masina("Volvo", "XC60", 2015, "benzina",11000, 187000, "negru");


        MasinaService service = new MasinaService();

        service.GrupareCuloare();
        service.AfisareCntCulori(); 
    }
}
