namespace TutorialCS
{
    public class Car : Vehicle
    {
        public Engine EngineBase {get; set;}

        public Car(string name, int maxSpeed, Engine engine)
        : base(name)
        {
            // _name = name;
            this.MaxSpeed = maxSpeed;
            EngineBase = new OilEngine();

            EngineBase = engine;

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
    
        public override void StartEngine()
        {
            EngineBase.Start();
        }
    }
}