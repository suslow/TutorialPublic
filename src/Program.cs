using System;

namespace TutorialCS
{
    class Program
    {
        static void Main(string[] args)
        {
            var player = new Man();

            var bmw1 = new Car("BMW1", 120, new Engine());
            var bmw2 = new Car("BMW2", 120, new Engine());
            var horse = new Horse() { Name = "Horse" };

            player.MoveFromAtoB(bmw1);
            player.MoveFromAtoB(bmw2);
            player.MoveFromAtoB(horse);
        }
    }
}