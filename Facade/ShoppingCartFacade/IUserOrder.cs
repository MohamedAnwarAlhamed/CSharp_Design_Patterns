
namespace ShoppingCartFacade
{
    public interface IUserOrder
    {
        int AddToCart(int itemId, int qty);
        int PlaceOrder(int cartID, int userID);
    }
}
