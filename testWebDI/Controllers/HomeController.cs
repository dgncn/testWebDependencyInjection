using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using testWebDI.Class;

namespace testWebDI.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public string Index()
        {
            Araba araba = new Araba(new Ferrari());
            return araba.Yaz();
        }
    }
}