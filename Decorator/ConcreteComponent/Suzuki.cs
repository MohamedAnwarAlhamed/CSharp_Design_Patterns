
namespace singleton.Decorator
{
    class Suzuki : ICar
    {
        public string Make
        {
            get { return "HatchBack"; }
        }
        public double GetPrice()
        {
            return 800000;
        }
    }
}
