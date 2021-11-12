using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WE_Asgn_2_a.Models;
using WE_Asgn_2_a.DAL;

namespace WE_Asgn_2_a.Controllers
{
    public class UserController : Controller
    {
        // GET: User
        public ActionResult Index()
        {
            ViewBag.RowsAffected = 0;
            ViewBag.CountryList = CountryList();
            return View();
        }
        [HttpPost]
        public ActionResult Index(MUser mUser)
        {
            ViewBag.CountryList = CountryList();
            UserEntity userEntity = new UserEntity();
            ViewBag.RowsAffected = userEntity.AddUser(mUser);
            ViewBag.message = userEntity.exMsg;
            return View(); 
        }
        private List<SelectListItem> CountryList()
        {
            List<SelectListItem> countryList = new List<SelectListItem>();
            countryList.Add(new SelectListItem { Value = "Pakistan", Text = "Pakistan", });
            countryList.Add(new SelectListItem { Value = "Afghanistan", Text = "Afghanistan" });
            countryList.Add(new SelectListItem { Value = "China", Text = "China"  });
            countryList.Add(new SelectListItem { Value= "Russia", Text= "Russia" });
            return countryList;
        }
    }
}