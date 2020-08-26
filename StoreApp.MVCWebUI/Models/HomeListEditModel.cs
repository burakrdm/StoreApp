using StoreApp.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StoreApp.MVCWebUI.Models
{
    public class HomeListEditModel
    {
        public HomeListEditModel()
        {
            ProductList = new List<Product>();
            CategoryList = new List<Category>();
          
           
        }
        public List<Product> ProductList { get; set; }

        public List<Category> CategoryList { get; set; }
       
        public int CategoryId { get; set; }

        
    }
}