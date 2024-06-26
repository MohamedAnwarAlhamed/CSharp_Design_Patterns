﻿
    class CarFactory : AbstractFactory
    {
        public void drowTire(string type)
        {
            switch (type)
            {
                case "S":
                    (new TireSmall()).drowSamllTire();
                    break;
                case "U":
                    (new TireLareg()).drowLaregTire();
                    break;
                default:
                    (new TireXLareg()).drowTireXLareg();
                    break;
            }
        }

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

