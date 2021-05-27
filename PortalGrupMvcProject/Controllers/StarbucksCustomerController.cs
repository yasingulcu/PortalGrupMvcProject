using PortalGrupMvcProject.Abstract;
using PortalGrupMvcProject.Adapters;
using PortalGrupMvcProject.Concrete;
using PortalGrupMvcProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PortalGrupMvcProject.Controllers
{
    public class StarbucksCustomerController : Controller
    {
        // GET: StarbucksCustomer
        BaseCustomerManager bm = new StarbucksCustomerManager(new MernisServiceAdapter());
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult AddCustomer()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddCustomer(Customer c)
        {
            bm.Save(c);
            return RedirectToAction("Index");
        }
    }
}
//Starbucks Firmasına ait kişi ekleme yapılırken sorgulama işlemlerinin olduğu kısımdır. 