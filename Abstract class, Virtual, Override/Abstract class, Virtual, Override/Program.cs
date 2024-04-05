namespace Abstract_class__Virtual__Override
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car car1 = new Car("Mercedes", "c300", "white", 1.5, 50, 6, false);
            Car car2 = new Car("Mercedes", "c300", "black", 4.9, 200, 4, false);


            Bicycle bicycle1 = new Bicycle("Toyota", "Corolla", "black", 5.0, 35, "Hybrid"); // velosiped adi bilmedim ucun masin yazdim :)
            Bicycle bicycle2 = new Bicycle("Tesla", "Corolla", "red", 6.3, 10, "Hybrid");



            Car[] cars = { car1, car2 };
            Bicycle[] bicycles = { bicycle1, bicycle2 };

            foreach (var full in cars)
            {
                full.GetInfo();
            }

            Console.WriteLine(" ");
            foreach (var full in bicycles)
            {
                full.GetInfo();
            }
        }
    }
}