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
    public class AccountUserController : Controller
    {
        // GET: Kullanıcı

        IAccountUserManager _AccountUserManager;
        IAccountRoleManager _AccountRoleManager;
        IAccountPersonManager _AccountPersonManager;
        
        
        public AccountUserController()
        {
            //dependecy injection

            _AccountUserManager = new AccountUserManager();
            _AccountRoleManager = new AccountRoleManager();
            _AccountPersonManager = new AccountPersonManager();
            

            
        }
        public ActionResult Index()
        {
            var accountuser = _AccountUserManager.GetAll().ToList();
            return View(accountuser);
        }
        public ActionResult Details(int id)
        {
            return View();
        }
        public ActionResult Create()
        {
           
            ViewBag.AccountRole = _AccountRoleManager.GetAll().ToList();
            ViewBag.AccountPerson = _AccountPersonManager.GetAll().ToList();
            return View();
        }

        [HttpPost]
        public ActionResult Create(AccountUser entity)
        {
            try
            {
                entity.LastLoginDate = DateTime.Now;
                entity.InsertBy = 1;
                entity.InsertDate = DateTime.Now;
                entity.LockedOut = false;
                entity.UpdateBy = 1;
                entity.UpdateDate = DateTime.Now;
                entity.IsDeleted = false;

                _AccountUserManager.Add(entity);

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }

        }
        // GET: Category/Edit/5
        public ActionResult Edit(int id)
        {

            ViewBag.AccountRole = _AccountRoleManager.GetAll().ToList();
            ViewBag.AccountPerson = _AccountPersonManager.GetAll().ToList();

            var accountuser = _AccountUserManager.Get(id);
            return View(accountuser);
        }

        [HttpPost]
        public ActionResult Edit(AccountUser entity)
        {
            try
            {
                _AccountUserManager.Update(entity);
                TempData["Updated"] = entity.UserName;
                TempData["Updated"] = entity.UserMailAddress;
                TempData["Updated"] = entity.Password;
                TempData["Updated"] = entity.PersonID;
                TempData["Updated"] = entity.AccountRoleID;
                TempData["Updated"] = entity.LastLoginDate;
                TempData["Updated"] = entity.LockedOut;
                TempData["Updated"] = entity.UpdateBy;
                TempData["Updated"] = entity.UpdateDate;
                TempData["Updated"] = entity.IsDeleted;
                TempData["Updated"] = entity.InsertDate;
                TempData["Updated"] = entity.InsertBy;

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        public ActionResult Delete(int id)
        {
            var accountuser = _AccountUserManager.Get(id);
            return View(accountuser);
        }
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {


                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }

        }
    }
}