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
    public class OrderManagerController : Controller
    {
        // GET: OrderManager
        IOrderManager _orderManager;

        public OrderManagerController()
        {
            //dependecy injection

            _orderManager = new OrderManager();
        }

        // GET: Category
        public ActionResult Index()
        {

            int UserID = Convert.ToInt32(Session["ActiveUserID"]);
            var orders = _orderManager.GetAll().ToList();
            return View(orders);
        }

        // GET: Product/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Product/Create
        public ActionResult Create()
        {
            //ViewBag.Categories = _orderManager.GetAll().ToList();
            return View();
        }

        // POST: Product/Create
        [HttpPost]
        public ActionResult Create(Order entity)
        {
            try
            {
                _orderManager.Add(entity);

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Product/Edit/5
        public ActionResult Edit(int id)
        {
            var order = _orderManager.Get(id);
        

            return View(order);
        }

        // POST: Product/Edit/5
        [HttpPost]
        public ActionResult Edit(Order entity)
        {
            try
            {
                _orderManager.Update(entity);
                TempData["Updated"] = entity.ProductID;

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Product/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Product/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}