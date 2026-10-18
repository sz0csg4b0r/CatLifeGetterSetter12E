using CatLife.Model;

internal class Program
    {

    private static void Main(string[] args)
        {
        Macska margit = new Macska("Margit", 4.2, false);
        Macska dugó = new Macska("Dugó", 5.1);

        Console.WriteLine("1. Kiindulási állapot");
        Console.WriteLine(margit.ToString());
        Console.WriteLine(dugó.ToString());

        Console.WriteLine("2. Első etetés zajlik");
        margit.Eszik(0.5);
        dugó.Eszik(0.3);

        Console.WriteLine("3. Állapot az első etetés után");
        Console.WriteLine(margit.ToString());
        Console.WriteLine(dugó.ToString());

        margit.Futkos();
        dugó.Futkos();

        Console.WriteLine("4. Állapot az első futkosás után");
        Console.WriteLine(margit.ToString());
        Console.WriteLine(dugó.ToString());
        Console.WriteLine("==========================");

        // Új kódrészek tesztje
        Console.WriteLine("Extra.1. feladat");
        Macska cirmi = new Macska("  cirmi ", 3.8);
        Console.WriteLine(cirmi);                 // Cirmi, 3,80 kg, éhes
        Console.WriteLine();
        Console.WriteLine("Extra.2. feladat");
        try
            {
            Macska nevtelen = new Macska("   ", 4.0);
            }
        catch (ArgumentException ex)
            {
            Console.WriteLine(ex.Message);
            Console.WriteLine();
            }

        Console.WriteLine("Extra.3. feladat");
        Macska pici = new Macska("Pici", 1.5);
        Console.WriteLine(pici);
        pici.Futkos();
        Console.WriteLine(pici);
        pici.Futkos();
        Console.WriteLine(pici);
        pici.Futkos();
        Console.WriteLine(pici);            // Pici, 1,00 kg, éhes
        Console.WriteLine();
        Macska nagy = new Macska("Nagy", 11.8);
        Console.WriteLine(nagy);
        nagy.Eszik(1.5);
        Console.WriteLine(nagy);

        }
    }

