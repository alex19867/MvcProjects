using SalesWebMVC.Models;
using SalesWebMVC.Models.Enums;
using System;
using System.Linq;

namespace SalesWebMVC.Data
{
    public class SeedingService
    {
        private SalesWebMVCContext _context;

        public SeedingService( SalesWebMVCContext context)
        {
            _context = context;
        }

        public void Seed()
        {
            if (_context.Department.Any() ||
                _context.Seller.Any() ||
                _context.SalesRecord.Any() )
            {
                return; //DB has been seeded
            }

            Department d1 = new Department(1, "Computers");
            Department d2 = new Department(2, "Electronics");
            Department d3 = new Department(3, "Fashion");
            Department d4 = new Department(4, "Books");

            Seller s1 = new Seller(1, "Bob Brown", "bob@gmail.com", new DateTime(1998, 4, 21), 1000.0, d1);
            Seller s2 = new Seller(2, "Maria Green", "mgreen@gmail.com", new DateTime(1979, 9, 1), 955.4, d2);
            Seller s3 = new Seller(3, "Alex Grey", "agrey@gmail.com", new DateTime(1998, 4, 2), 1410.0, d1);
            Seller s4 = new Seller(4, "Martha Red", "red@gmail.com", new DateTime(1972, 4, 25), 1050.0, d4);
            Seller s5 = new Seller(5, "Donald Blue", "blueob@gmail.com", new DateTime(1990, 6, 20), 1300.0, d3);
            Seller s6 = new Seller(6, "Alex Pink", "pink@gmail.com", new DateTime(1988, 4, 21), 1030.0, d2);

            SalesRecord sr1 = new SalesRecord(1, new DateTime(2018, 09, 13), 1100.23, SaleStatus.Billed, s1);
            SalesRecord sr2 = new SalesRecord(2, new DateTime(2018, 08, 25), 1100.23, SaleStatus.Billed, s1);
            SalesRecord sr3 = new SalesRecord(3, new DateTime(2018, 01, 05), 200, SaleStatus.Billed, s2);
            SalesRecord sr4 = new SalesRecord(4, new DateTime(2018, 02, 15), 115.23, SaleStatus.Billed, s5);
            SalesRecord sr5 = new SalesRecord(5, new DateTime(2018, 10, 23), 11078.23, SaleStatus.Billed, s3);


            _context.Department.AddRange(d1, d2, d3, d4);
            _context.Seller.AddRange(s1, s2, s3, s4, s5);
            _context.SalesRecord.AddRange(sr1, sr2, sr3, sr4, sr5);

            _context.SaveChanges();
        }

    }
}
