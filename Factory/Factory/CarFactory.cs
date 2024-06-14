
    class CarFactory
    {

        public Car getYourCar(string type)
        {
            switch (type)
            {
                case "S":
                    return new SedanCar();
                case "U":
                    return new SUVCar();
                default:
                    return new TruckCar();
            }
        }

    }

