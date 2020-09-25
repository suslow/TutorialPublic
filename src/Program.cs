using System;

namespace TutorialCS
{
    class Program
    {
        static void Main(string[] args)
        {   
            var bmw = new Car("Bmw",200, new OilEngine());
            System.Console.WriteLine("BMW");
            bmw.Init();

            

            var teslaEngine = new ElectricEngine();
            var tesla = new Car("Tesla",200, teslaEngine);
            System.Console.WriteLine("TESLA");
            tesla.Init();
        }
    }
}