using NFine.Application.test;
using NFine.Domain._03_Entity.test;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NFine.Web.Controllers
{
    public class TestController : Controller
    {


        private TestApp testApp = new TestApp();
        //
        // GET: /Test/

        public ActionResult Index()
        {

            DzkTest dzk = new DzkTest();
            dzk.NAME = "dzk";
            testApp.Insert(dzk);
            return View();
        }

    }
}
