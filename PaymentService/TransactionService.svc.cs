using Newtonsoft.Json;
using PaymentService.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace PaymentService
{
    public class TransactionService : ITransactionService
    {
        public PaymentInfoResponse Pay(PaymentInfoCommand paymentInfoCommand)
        {
            var decryptedPaymentInfo = new AesOperation().Decrypt(paymentInfoCommand.EncyptedBody, paymentInfoCommand.Key);

            PaymentInfo paymentInfo  = JsonConvert.DeserializeObject<PaymentInfo>(decryptedPaymentInfo);
            string approvalCode = processRequest(paymentInfo);

            var response = new PaymentInfoResponse() {
                ApprovalCode = approvalCode,
            DateTime = DateTime.Now,
            Message =  "SUCCESS",
            ResponseCode = ResponseCode.SUCCESS.ToString()
            };

            return response;
        }

        public string GetKey() {
          //  Random rnd = new Random();
           // int index = rnd.Next(10);
            return Guid.NewGuid().ToString().Substring(0,8);//RandomKeys[index];
        }

        private string processRequest(PaymentInfo paymentInfo)
        {
            return Guid.NewGuid().ToString().Substring(0, 6);
        }

        public List<string> RandomKeys = new List<string>() {
        "]Dw2D#@9",
        "L={4<:kP",
        "r7x[!pSt",
        "^9UaFpxq",
        "T>qDc9vJ",
        "nU)w9qJ8",
        "2v;,xPD",
        "mB&r2y-",
        "eV_!W8-",
        "57.f1ZP"
        };
    }
}
