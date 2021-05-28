using System;
using SalesWebMVC.Models.Enums;

namespace SalesWebMVC.Models
{
    public class SalesRecord
    {
        //private int v1;
        //private DateTime dateTime;
        //private double v2;
        //private SaleStatus billed;
        //private Seller s1;

        public int id { get; set; }
        public DateTime Date{ get; set; }
        public double Amount { get; set; }
        public SaleStatus Status { get; set; }
        public Seller Seller{ get; set; }
        public SalesRecord()
        {

        }

        public SalesRecord(int id, DateTime date, double amount, SaleStatus status, Seller seller)
        {
            Date = date;
            Amount = amount;
            Status = status;
            Seller = seller;
        }

      

    }
}
