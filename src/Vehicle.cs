namespace TutorialCS
{
    public abstract partial class Vehicle : IMoveable
    {
        internal readonly string _name;

        public string NameVehicle => _name;

        public Vehicle(string name)
        {
            this._name = name;
            // EngineBase = new Engine();
        }


        public void Init()
        {
            OpenLock();
            StartEngine();
            Move();
            Stop();
            StopEngine();
            CloseLock();
        }

        private void CloseLock()
        {
            System.Console.WriteLine("Close Lock");
        }

        private void StopEngine()
        {
            System.Console.WriteLine("Stop Engine");
        }

        private void Stop()
        {
            System.Console.WriteLine("Stop");
        }

        public virtual void StartEngine()
        {
            System.Console.WriteLine("Start Engine");
        }

        private void OpenLock()
        {
            System.Console.WriteLine("Lock Opened");
        }

        public virtual void Move()
        {
            System.Console.WriteLine($"Трансорт {_name} движется");
        }
    }
}