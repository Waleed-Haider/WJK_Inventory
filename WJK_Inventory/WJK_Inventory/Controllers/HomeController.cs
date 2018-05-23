using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WJK_Inventory.Models;

namespace WJK_Inventory.Controllers
{
    public class HomeController : Controller
    {
        private ItemDbContext _itemDbContext = new ItemDbContext();
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Login()
        {
            return View();
        }

        public ActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Add(Item item)
        {
            return View();
        }
    }
}