using eShopSolution.Data.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace eShopSolution.Data.Entity
{
    public class Transaction
    {
        public int ID { get; set; }
        public DateTime TransactionDate { get; set; }
        public int ExternalTransactionID { get; set; }
        public int Amount { get; set; }
        public decimal Fee { get; set; }
        public string Result { get; set; }
        public string Message { get; set; }
        public Status status { get; set; }
        public string Provider { get; set; }
    }
}
