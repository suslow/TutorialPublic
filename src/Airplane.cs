namespace TutorialCS
{
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