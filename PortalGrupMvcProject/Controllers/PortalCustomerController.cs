using PortalGrupMvcProject.Abstract;
using PortalGrupMvcProject.Concrete;
using PortalGrupMvcProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PortalGrupMvcProject.Controllers
{
    public class PortalCustomerController : Controller
    {
        // GET: PortalCustomer
        BaseCustomerManager bm = new PortalCustomerManager();
        public ActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public ActionResult AddCustomerPortal()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddCustomerPortal(Customer c)
        {
            bm.Save(c);
            return RedirectToAction("Index");
        }
    }
}
//Portal Firmasına ait kişi ekleme yapılırken sorgulama işlemlerinin olduğu kısımdır. 