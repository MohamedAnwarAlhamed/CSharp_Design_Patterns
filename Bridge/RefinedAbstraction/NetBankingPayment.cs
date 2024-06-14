
namespace singleton.Bridge
{
    public class NetBankingPayment : Payment
    {
        public override void MakePayment()
        {
            _IPaymentSystem.ProcessPayment("NetBanking Payment");
        }
    }
}
