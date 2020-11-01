using System;

namespace TutorialCS
{
    public class Engine
    {
        public virtual void Start()
        {
            System.Console.WriteLine("Start Engine");
        }
    }

    public class ElectricEngine : Engine
    {
        public override void Start()
        {
            System.Console.WriteLine("Electric engine start");
        }
    }

    public class OilEngine : Engine
    {
        public override void Start()
        {
            System.Console.WriteLine("Oil engine start");
        }
    }

}