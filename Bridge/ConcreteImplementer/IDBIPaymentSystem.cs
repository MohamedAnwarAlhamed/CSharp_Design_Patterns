
namespace singleton.Bridge
{
    class IDBIPaymentSystem : IPaymentSystem
    {
        public void ProcessPayment(string paymentSystem)
        {
            Console.WriteLine("Using IDBIBank gateway for  " + paymentSystem);
        }
    }
}
