using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace PaymentService.Model
{
    [DataContract]
    public class PaymentInfo
    {
        [DataMember]
        public string ProcessingCode { get; set; }
        [DataMember]
        public int SystemTraceNr { get; set; }
        [DataMember]
        public int FunctionCode { get; set; }
        [DataMember]
        public string CardNo { get; set; }
        [DataMember]
        public string CardHolder { get; set; }
        [DataMember]
        public double AmountTrxn  { get; set; }
        [DataMember]
        public int CurrencyCode { get; set; }
    }
}