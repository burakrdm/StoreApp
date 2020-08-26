using StoreApp.Business.Abstract1;
using StoreApp.Business.Manager1;
using StoreApp.DataAccess.Concrete.EntityFramework;
using StoreApp.Entity;
using StoreApp.MVCWebUI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace StoreApp.MVCWebUI.Controllers
{
    public class OrderController : Controller
    {
        IProductManager _productManager;
        IOrderManager _orderManager;
        ICategoryManager _categoryManager;
        public OrderController()
        {
            _productManager = new ProductManager();
            _orderManager = new OrderManager();
            _categoryManager = new CategoryManager();
        
        }
        // GET: Order
        [HttpGet]
        public ActionResult Index(int? id)
        {

            ProductDetails model = new ProductDetails();
            model.CategoryList = _categoryManager.GetAll().ToList();
            model.ProductList = _productManager.GetAll().ToList();
            if (id.HasValue)
            {
                model.ProductList = model.ProductList.Where(p => p.Id == id).ToList();
            }

            return View(model);

        }
      

        //create yap 
        //public ActionResult Details()
        //{
   
        //        return View();
         
        //}
        public ActionResult Create(string id,Order entity)
        {

            ProductDetails model = new ProductDetails();
            
            model.ProductList = _productManager.GetAll().ToList();
            if (id != null)
            {
                model.ProductList = model.ProductList.Where(p => p.Id == Convert.ToInt32(id)).ToList();

                double price = 1 * model.ProductList[0].Price;

                entity.ProductID = model.ProductList[0].Id;
                entity.Price = Convert.ToDecimal(model.ProductList[0].Price);
                entity.Amount = Convert.ToDecimal(price);
                entity.Piece = 1;
                entity.OrderDate = DateTime.Now;
                entity.UserID = Convert.ToInt32(Session["ActiveUserID"]);
                entity.UpdateDate = DateTime.Now;
                entity.UpdateBy = Convert.ToInt32(Session["ActiveUserID"]); 
                entity.IsDeleted = false;
                entity.InsertDate = DateTime.Now;
                entity.InsertBy = Convert.ToInt32(Session["ActiveUserID"]);

                _orderManager.Add(entity);


            }


                return View(model);

           

        }

        [HttpPost]
        public ActionResult Create(Order entity)
        {
            try
            {
               
                entity.Amount = 1;
                entity.Piece = 1;
                entity.OrderDate = DateTime.Now;
                entity.UserID = 2;
                entity.UpdateDate = DateTime.Now;
                entity.UpdateBy = 1;
                entity.IsDeleted = false;
                entity.InsertDate = DateTime.Now;
                entity.InsertBy = 1;
            
                _orderManager.Add(entity);

                return RedirectToAction("~/Home/Index");
            }
            catch
            {
                return View();
            }
        }

    }
}