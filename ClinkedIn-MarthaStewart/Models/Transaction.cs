using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClinkedIn_MarthaStewart.Models
{
    public struct TransactionRequest
    {
        public int Buyer;
        public int Seller;
        public string RequestedService;
    }

    public struct TransactionResponse
    {
        public TransactionResponse (string buyer, string seller, string service, decimal remainder)
        {
            RemainingFunds = remainder;
            BuyerName = buyer;
            SellerName = seller;
            ServicePerformed = service;
        }
        public decimal RemainingFunds;
        public string BuyerName;
        public string SellerName;
        public string ServicePerformed;
    }
}
