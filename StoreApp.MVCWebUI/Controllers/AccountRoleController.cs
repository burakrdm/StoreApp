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
    public class AccountRoleController : Controller
    {

        IAccountRoleManager _AccountRoleManager;


        // GET: AccountRole
        public AccountRoleController()
        {
            //dependecy injection

            _AccountRoleManager = new AccountRoleManager();
        }
        public ActionResult Index()
        {
            var accountroles = _AccountRoleManager.GetAll().ToList();
            return View(accountroles);
           
        }
        public ActionResult Details(int id)
        {
            return View();
        }

        public ActionResult Create()
        {
            
            return View();
        }

        // POST: Category/Create
        [HttpPost]
        public ActionResult Create(AccountRole entity)
        {
            try
            {
                _AccountRoleManager.Add(entity);

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        public ActionResult Edit(int id)
        {

            //ViewBag.AccountRole = _AccountRoleManager.GetAll().ToList();
            var accountroles = _AccountRoleManager.Get(id);
            return View(accountroles);
        }

        // POST: Category/Edit/5
        [HttpPost]
        public ActionResult Edit(AccountRole entity)
        {
            try
            {
                _AccountRoleManager.Update(entity);
                TempData["Updated"] = entity.RoleName;
                TempData["Updated"] = entity.Description;

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}