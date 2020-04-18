using Newtonsoft.Json;
using Payment.Business.Model;
using Payment.Business.Services.Encryption;
using Payment.Business.Services.Payment;
using System;
using System.Collections.Generic;

namespace PaymentService
{
    public class TransactionService : ITransactionService
    {
        public PaymentInfoResponse Pay(PaymentInfoCommand paymentInfoCommand)
        {
            TransactionsService transactionsService = new TransactionsService();
            return transactionsService.Pay(paymentInfoCommand);
        }

        public string GetKey() {
            return Guid.NewGuid().ToString().Substring(0,8);
        }
    }
}
