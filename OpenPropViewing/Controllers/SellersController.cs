using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using OpenPropViewing.Models.User;

namespace OpenPropViewing.Controllers
{
    public class SellersController : Controller
    {
        // GET: Sellers
        public ActionResult Index()
        {
            var sellers = GetSellers();
            return View();
        }

        public ActionResult Details(int id)
        {
            var seller = GetSellers().SingleOrDefault(s => s.SellerId == id);

            if (seller == null)
                return HttpNotFound();
            return View(seller);
        }


        private IEnumerable<Seller> GetSellers()
        {
            return new List<Seller>
            {
                new Seller {SellerId = 1, FirstName = "Morna", LastName = " Carrick"}
            };
        }

    }
}