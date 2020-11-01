namespace TutorialCS
{
    public class Horse : IMoveable
    {
        public string Name { get; set; }

        public string NameVehicle => Name;

        public void Move()
        {
            System.Console.WriteLine($"Ride on {Name}");
        }
    }
}