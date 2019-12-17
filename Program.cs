using System;
using System.Linq;

class BigNumber
{
    static void Main(string[] args)
    {
        Console.WriteLine("Kharkiv");
        Console.WriteLine("Kiev");
        Console.WriteLine("LasVegas \n\n");

        int Kharkiv = int.Parse(Console.ReadLine());
        int Kiev = int.Parse(Console.ReadLine());
        int LasVegas = int.Parse(Console.ReadLine());
        
        //Population

        if (Kharkiv > Kiev)
        {
            if (Kharkiv > LasVegas)
            {
                Console.WriteLine("The biggest population has: Kharkiv \n\n", Kharkiv);
            }
            else
            {
                Console.WriteLine("The biggest population has: LasVegas \n\n", LasVegas);
            }
        }
        else
        {
            if (Kiev > LasVegas)
            {
                Console.WriteLine("The biggest population has: Kiev \n\n", Kiev);
            }
            else
            {
                Console.WriteLine("The biggest population has: LasVegas \n\n", LasVegas);
            }
                

        }

        //Longest name

        var cities = new string[] { "Kharkiv \n\n", "Kiev \n\n", "Las Vegas \n\n", };

        string longest = cities.OrderByDescending(s => s.Length).First();

        Console.WriteLine("The city with longest name is: ");
        Console.WriteLine(longest, longest);


        //Density

       

        double density1stCity = 0; 
        double density2ndCity = 0;
        double density3rdCity = 0;



        double[] density1 = { 4088.57, 3342.07, 1714.20 };

        double biggestDensity = density1.Max();
        
        Console.WriteLine("The biggest density has Kharkiv: ");
        Console.WriteLine(biggestDensity);
        Console.ReadLine();

    }
}

/*class City
{
    public string name;
    public double density;


    public City() { name = "Kharkiv"; density = 4088.57; }
    public City() { name = "Kiev"; density = 3342.07; }
    public City() { name = "LasVegas"; density = 1714.20; }

    public void GetInfo()
    {
        Console.WriteLine($"Name: {name} Density: {density}");
    }
}
static void Main(string[] args)
{
    City Kharkiv = new City();
    City Kiev = new City("Kiev");
    City LasVegas = new City("Las Vegas", 1714.20);

    Kharkiv.GetInfo();
    Kiev.GetInfo();
    LasVegas.GetInfo();
}
*/
