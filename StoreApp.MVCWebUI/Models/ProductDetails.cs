using StoreApp.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StoreApp.MVCWebUI.Models
{
    public class ProductDetails
    {
        public ProductDetails()
        {
            ProductList = new List<Product>();
            CategoryList = new List<Category>();
            OrderList = new List<Order>();

        }

        public List<Product> ProductList { get; set; }

        public List<Category> CategoryList { get; set; }

        public List<Order> OrderList { get; set; }
        public string Name { get; set; }

        public string Description { get; set; }

        public double Price { get; set; }
    
        public string Image { get; set; }

        public int ProductID { get; set; }
    }
}