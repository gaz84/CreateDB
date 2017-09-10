using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MemoDAL;
using MemoDAL.EF;
using MemoDAL.Entities;

namespace CreateDBToMemorize.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Title = "Home Page";
            using (UnitOfWork un = new UnitOfWork(new MemoContext()))
            {
                Role r = new Role { Name = "Test" };
                un.Roles.Create(r);

                var roles = un.Roles.GetAll();
                un.Save();
            }
            return View();
        }
    }
}
