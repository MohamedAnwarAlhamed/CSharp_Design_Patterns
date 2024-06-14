
    abstract class Car
    {
        public string carName { get; set; }
        public int modelNumber { get; set; }


        public void RunCar()
        {
            Console.WriteLine(carName + "is running ");
        }

        public void ShowCar()
        {
            Console.WriteLine(modelNumber + "is showing");
        }
    }

