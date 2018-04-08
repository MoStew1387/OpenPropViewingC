using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using OpenPropViewing.Models.User;

namespace OpenPropViewing.Controllers
{
    public class BuyersController : Controller
    {
        // GET: Buyers
        public ActionResult Index()
        {
            var buyers = GetBuyers();
            return View();
        }

        public ActionResult Details(int id)
        {
            var buyer= GetBuyers().SingleOrDefault(s => s.BuyerId == id);

            if (buyer == null)
                return HttpNotFound();
            return View(buyer);
        }


        private IEnumerable<Buyer> GetBuyers()
        {
            return new List<Buyer>
            {
                new Buyer {BuyerId = 1, FirstName = "Morna", LastName = "Carrick"}
            };
        }
    }
}