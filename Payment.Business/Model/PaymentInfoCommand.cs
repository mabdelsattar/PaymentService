using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace Payment.Business.Model
{
    [DataContract]
    public class PaymentInfoCommand
    {
        [DataMember]
        public string EncyptedBody { get; set; }

        [DataMember]
        public string Key { get; set; }
    }
}