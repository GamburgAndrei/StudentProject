using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVC5ProjectV1.Models
{
    public class Purchase
    {
        public int PurchaseID { get; set; }
        public string Person { get; set; }
        public string Address { get; set; }
        public int BookID { get; set; }
        public DateTime Date { get; set; }

    }
}