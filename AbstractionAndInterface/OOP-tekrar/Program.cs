using OOP_tekrar.Classes;

namespace OOP_tekrar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //IT it = new IT();
            //it.setName("kdwands");
            //Console.WriteLine(it.GetName());
            //it.Name = "dksnfdlksn";
            //Console.WriteLine(it.GetName());

            /// It-in instance-i
            IT it = new IT("nlkfendfv");
            Console.WriteLine(it.FullInfo());
            /// Programming-in instance-i
            Programing programing = new Programing("mkcnszlxc","C#");
            Console.WriteLine(programing.FullInfo());

            /// static
            //Console.WriteLine(StaticClass.StaticMethod());
            //StaticClass.Id = 5;
            //Console.WriteLine(StaticClass.Id);

            //string str = Console.ReadLine();
            //Console.WriteLine(str.ExtensionMethod());

            //Rectangle rectangle = new Rectangle(20, 15);
            //Triangle triangle = new Triangle(30, 25, 20);
            //Console.WriteLine(rectangle.Area());
            //Console.WriteLine(triangle.Area());

            //Eagle eagle = new Eagle("Qartal");
            //Duck duck = new Duck("Ordek");
            //eagle.Fly();
            //duck.Fly();
            //duck.Swim();
        }
    }
}