using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace MVC.RestAPI.Controllers
{
    public class UsersController : Controller
    {
        public ActionResult Index()
        {
            return new HttpStatusCodeResult(HttpStatusCode.OK);
        }

        [HttpPost]
        public ActionResult Create()
        {

            return new HttpStatusCodeResult(HttpStatusCode.Created);
        }

        [HttpPut]
        public ActionResult Update()
        {
            return new HttpStatusCodeResult(HttpStatusCode.OK);
        }

        [HttpPut]
        public ActionResult Delete()
        {
            return new HttpStatusCodeResult(HttpStatusCode.OK);
        }

    }
}
