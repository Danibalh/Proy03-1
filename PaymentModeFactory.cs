using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Interfaces
{
    public enum Mode{
        creditCard,
        debitCard,
        payPalpay,
        pse
    }
    public class PaymentModeFactory
    {
        public static IPaymentMode Create (Mode mode){
            if(mode == Mode.creditCard)
                return new CreditCardPaymment();
            else if(mode == Mode.debitCard)
                return new DebitCardPaymment();
            else if(mode == Mode.pse)
                return new PsePayment();
            else 
                return new PyPalPayment();
        }
    }
}