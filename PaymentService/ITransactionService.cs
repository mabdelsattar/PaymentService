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
    [ServiceContract]
    public interface ITransactionService
    {     
        [OperationContract]
        [WebInvoke(Method = "POST", UriTemplate = "/Pay", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json
            , BodyStyle = WebMessageBodyStyle.Bare)]
        PaymentInfoResponse Pay(PaymentInfoCommand paymentInfo);
        
        [OperationContract]
        [WebInvoke(Method = "GET", UriTemplate = "/GetKey", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json
          , BodyStyle = WebMessageBodyStyle.Wrapped)]
         string GetKey();

    }

}
