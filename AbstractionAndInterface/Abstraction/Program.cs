namespace Abstraction
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Machine machine = new Machine(); // error occured
            Car car = new Car(1,"BMW",100);
            Phone phone = new Phone("Xiaomi Redmi 6",4000);
            car.Speed = 150;
            Console.WriteLine(phone.Charge());
            Console.WriteLine(car.Charge());
        }
    }
}