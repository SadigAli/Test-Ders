using Interfaces.Classes;

namespace Interfaces
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Fish fish = new Fish("Shark");
            Console.WriteLine(fish.Swim());
        }
    }
}