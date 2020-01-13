//using MVCSample.Models;
//using Syncfusion.EJ.Export;
using Syncfusion.JavaScript;
using Syncfusion.JavaScript.DataSources;
using Syncfusion.JavaScript.Models;
using Syncfusion.XlsIO;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Web;
using System.Web.Mvc;
using System.Web.Script.Serialization;

namespace MVCSample.Controllers
{
    public class HomeController : Controller
    {
        public static List<OrderDetails> order = new List<OrderDetails>();

        public ActionResult Index()
        {
            if (order.Count() == 0)
                BindDataSource();
            ViewBag.datasource = order;
            return View();
        }
    
        public void BindDataSource()
        {
            if (order.Count() == 0)
            {
                int code = 10000;
                for (int i = 1; i < 10; i++)
                {
                    order.Add(new OrderDetails(code + 1, "ALFKI", i + 0, 2.3 * i, "Berlin", new DateTime(2019, 12, 12, 23, 40, 20), true));
                    order.Add(new OrderDetails(code + 2, "ANATR", i + 2, 3.3 * i, "Madrid", new DateTime(2019, 12, 11, 23, 50, 20), true));
                    order.Add(new OrderDetails(code + 3, "ANTON", i + 1, 4.3 * i, "Cholchester", new DateTime(2019, 12, 10, 23, 30, 50), false));
                    order.Add(new OrderDetails(code + 4, "BLONP", i + 3, 5.3 * i, "Marseille", new DateTime(2019, 12, 13, 23, 50, 50), true));
                    order.Add(new OrderDetails(code + 5, "BOLID", i + 4, 6.3 * i, "Tsawassen", new DateTime(2019, 12, 14, 23, 55, 55), false));
                    code += 5;
                }
            }

        }
        public void MyTestMethod(OrderDetails records)
        {
            var rowDetail = records;
        }
        public class OrderDetails
        {
            public OrderDetails()
            {

            }
            public OrderDetails(int OrderID, string CustomerId, int EmployeeId, double Freight, string ShipCity, DateTime OrderDate, Boolean CheckBox)
            {
                this.OrderID = OrderID;
                this.CustomerID = CustomerId;
                this.EmployeeID = EmployeeId;
                this.Freight = Freight;
                this.ShipCity = ShipCity;
                this.OrderDate = OrderDate;
                this.CheckBox = CheckBox;
            }

            public int? OrderID { get; set; }
            public string CustomerID { get; set; }
            public int? EmployeeID { get; set; }
            public double? Freight { get; set; }
            public string ShipCity { get; set; }

            public DateTime OrderDate { get; set; }
            public Boolean CheckBox { get; set; }
        }
        
    }
}