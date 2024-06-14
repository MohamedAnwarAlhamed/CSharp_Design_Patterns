
namespace singleton.Decorator
{
    class Hyndai : ICar
    {
        public string Make
        {
            get { return "Sedan"; }
        }
        public double GetPrice()
        {
            return 1000000;
        }
    }
}
