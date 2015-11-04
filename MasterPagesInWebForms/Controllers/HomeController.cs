using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MasterPagesInWebForms.Extensions;
using MasterPagesInWebForms.Models;

namespace MasterPagesInWebForms.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return this.RazorView("Index", new IndexModel { FoSho = true });
        }
    }
}