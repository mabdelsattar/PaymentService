using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;
using Payment.Business.Model;
using Payment.Business.Services.Encryption;
using Payment.Domain.Model;

namespace Payment.Business.Services.Payment
{
    public class TransactionsService
    {
        public PaymentInfoResponse Pay(PaymentInfoCommand paymentInfoCommand)
        {
            var decryptedPaymentInfo = new AesService().Decrypt(paymentInfoCommand.EncyptedBody, paymentInfoCommand.Key);

            PaymentInfo paymentInfo = JsonConvert.DeserializeObject<PaymentInfo>(decryptedPaymentInfo);
            string approvalCode = createApprovalCode(paymentInfo);

            var response = new PaymentInfoResponse()
            {
                ApprovalCode = approvalCode,
                DateTime = DateTime.Now,
                Message = "SUCCESS",
                ResponseCode = ResponseCode.SUCCESS.ToString()
            };

            return response;
        }

        private string createApprovalCode(PaymentInfo paymentInfo)
        {
            return Guid.NewGuid().ToString().Substring(0, 6);
        }
    }
}
