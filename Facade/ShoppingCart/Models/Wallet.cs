
namespace ShoppingCart.Models
{
    public class Wallet : IWallet
    {
        public double GetUserBalance(int userID)
        {
            Console.WriteLine("\t SubSystem Wallet : GetUserBalance");
            return 100;
        }
    }
}
