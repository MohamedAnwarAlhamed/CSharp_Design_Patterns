
    class Program
    {
        static void Main(string[] args)
        {
            Car car = null;

            Console.WriteLine("Select Your Type S=Sedan, U=SUV, T=Truck ??");
            string type = Console.ReadLine();

            car = (new CarFactory()).getYourCar(type);

            runCommand(car);

            Console.ReadKey(true);
        }

        static void runCommand(Car car)
        {
            car.RunCar();
            car.ShowCar();
        }
    }

