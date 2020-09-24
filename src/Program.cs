using System;

namespace TutorialCS
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            // var counter = new int();

            var bmw = new Car("Bmw", 250);

            bmw.GetInfo();

            System.Console.WriteLine(bmw.MaxSpeed);
            bmw.MaxSpeed = 1000;
            System.Console.WriteLine(bmw.MaxSpeed);

            // System.Console.WriteLine(bmw.GetMaxSpeed());

            // bmw.SetMaxSpeed(300);
            // System.Console.WriteLine(bmw.GetMaxSpeed());
            bmw.Move();
            var su31 = new Airplane("su31");
            su31.Move();
        }
    }

    public class Vehicle
    {
        internal readonly string _name;

        public Vehicle(string name)
        {
            this._name = name;
        }
        public virtual void Move()
        {
            System.Console.WriteLine($"Трансорт {_name} движется");
        }
    }

    public class Car : Vehicle
    {
        public Car(string name, int maxSpeed)
        : base(name)
        {
            // _name = name;
            this.MaxSpeed = maxSpeed;
        }


        private int _maxSpeed;
        public int MaxSpeed
        {
            get
            {
                return _maxSpeed;
            }
            set
            {
                if (value > 999)
                {
                    System.Console.WriteLine("MaxSpeed not valid!");
                    return;
                }
                _maxSpeed = value;
            }
        }

        // public void Move () {
        //     System.Console.WriteLine ("Машина едет");
        // }

        internal void GetInfo()
        {
            System.Console.WriteLine(_name);
        }
        // private int maxSpeed;

        // public int GetMaxSpeed()
        // {
        //     return maxSpeed;
        // }

        // internal void SetMaxSpeed(int newMaxSpeed)
        // {
        //     maxSpeed = newMaxSpeed; 
        // }
    }

    class Airplane : Vehicle
    {
        public Airplane(string name) : base(name)
        {

        }

        public override void Move()
        {
            System.Console.WriteLine($"Airplane {_name} fly");
        }
    }
}