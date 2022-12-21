namespace Interfaces
{

    internal class Program
    {
        private static void Main(string[] args)
        {
           PaymentModeFactory.Create(Mode.creditCard).MakePayment();
           PaymentModeFactory.Create(Mode.debitCard).MakePayment();
           PaymentModeFactory.Create(Mode.payPalpay).MakePayment();
           PaymentModeFactory.Create(Mode.pse).MakePayment();
        }
    }

}