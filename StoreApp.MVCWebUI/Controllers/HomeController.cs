using StoreApp.Business.Abstract1;
using StoreApp.Business.Manager1;
using StoreApp.Entity;
using StoreApp.MVCWebUI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace StoreApp.MVCWebUI.Controllers
{
    public class HomeController : Controller
    {
        IProductManager _productManager;

        ICategoryManager _categoryManager;
       

        public HomeController()
        {
            _productManager = new ProductManager();
            _categoryManager = new CategoryManager();
            
        }
        [HttpGet]
        public ActionResult Index(int? id)
       {
         
            HomeListEditModel model = new HomeListEditModel();
            model.CategoryList = _categoryManager.GetAll().ToList();
            model.ProductList = _productManager.GetAll().ToList();
           

            if(id.HasValue)
            {
                model.ProductList = model.ProductList.Where(p => p.CategoryId == id).ToList();
            }
            
            return View(model);
        }
        [HttpGet]
        public ActionResult Details(int? id)
        {
            ProductDetails model = new ProductDetails();

            model.ProductList = _productManager.GetAll().ToList();
            model.CategoryList = _categoryManager.GetAll().ToList();
            if (id.HasValue)
            {
               
                model.ProductList = model.ProductList.Where(p => p.Id == id).ToList();
            }
            //Session.Add("ActiveUser");


            return View(model);

        }
        

    }

     
}