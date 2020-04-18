using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Payment.Business.Model
{
    public class PaymentInfoResponse
    {
        public string ResponseCode { get; set; }
        public string Message { get; set; }
        public string ApprovalCode { get; set; }
        public DateTime DateTime { get; set; }
    }

    public enum ResponseCode
    { 
      SUCCESS = 00,
      FAILED = 01
    }
}