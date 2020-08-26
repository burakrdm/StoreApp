using StoreApp.Business.Abstract1;
using StoreApp.Business.Manager1;
using StoreApp.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace StoreApp.MVCWebUI.Controllers
{
    public class AccountPersonController : Controller
    {
        // GET: AccountPerson
        IAccountPersonManager _AccountPersonManager;

        public AccountPersonController()
        {
            //dependecy injection

            _AccountPersonManager = new AccountPersonManager();
        }
        public ActionResult Index()
        {
            var accountpersons = _AccountPersonManager.GetAll().ToList();
            return View(accountpersons);
        }
        public ActionResult Details(int id)
        {
            return View();
        }
        public ActionResult Create()
        {

            return View();
        }
        [HttpPost]
        public ActionResult Create(AccountPerson entity)
        {
            try
            {
                entity.UpdateDate = DateTime.Now;
                entity.UpdateBy = 1;
                entity.IsDeleted = false;
                entity.InsertDate = DateTime.Now;
                entity.InsertedBy = 1;

                _AccountPersonManager.Add(entity);

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
        public ActionResult Edit(int id)
        {
            var accountpersons = _AccountPersonManager.Get(id);
            return View(accountpersons);
        }
        [HttpPost]
        public ActionResult Edit(AccountPerson entity)
        {
            try
            {
                _AccountPersonManager.Update(entity);
                TempData["Updated"] = entity.FirstName;
                TempData["Updated"] = entity.LastName;
                TempData["Updated"] = entity.Phone;
                TempData["Updated"] = entity.PicturePath;
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}