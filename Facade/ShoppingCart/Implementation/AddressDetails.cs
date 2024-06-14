
namespace ShoppingCart.Implementation
{
    public class AddressDetails : IAddress
    {
        public Address GetAddressDetails(int userID)
        {
            Console.WriteLine("\t SubSystem Address : GetAddressDetails");
            return new Models.Address();
        }
    }
}
