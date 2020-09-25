namespace TutorialCS
{
    class Man
    {
        public void MoveFromAtoB(IMoveable vehicle)
        {
            vehicle.Move();
            // System.Console.WriteLine($"Ride on {vehicle.NameVehicle}");
        }
    }
}