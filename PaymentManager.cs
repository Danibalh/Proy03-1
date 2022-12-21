using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Interfaces
{
    public class PaymentManager
    {
        private readonly IPaymentMode _paymentMode;

        public PaymentManager (IPaymentMode paymentMode){
            _paymentMode = paymentMode;
        }

        public void ManagePayment()
        {
            _paymentMode.MakePayment();
        }

    }
}