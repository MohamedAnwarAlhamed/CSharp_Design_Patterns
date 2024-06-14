
namespace singleton.Bridge
{
    class CitiPaymentSystem :IPaymentSystem
    {
        public void ProcessPayment(string paymentSystem)
        {
            Console.WriteLine("Using CitiBank gateway for  " + paymentSystem);
        }
    }
}
