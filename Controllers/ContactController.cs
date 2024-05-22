using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TatilSeyahatWebSite.Models.classes;

namespace TatilSeyahatWebSite.Controllers
{
    public class ContactController : Controller
    {
        // GET: Contact
        Context c = new Context();
        public ActionResult Index()
        {
            var degerler = c.İletisims.ToList();
            return View(degerler);
        }
    }
}