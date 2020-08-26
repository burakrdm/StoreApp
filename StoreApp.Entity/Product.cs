using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreApp.Entity
{
    public class Product
    {
        public int Id { get; set; }

        public int CategoryId { get; set; }

        public Category Category { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public int Stock { get; set; }
        public string Image { get; set; }
        public bool? isApproved { get; set; }
        public bool? isHome { get; set; }
        public bool? isFeatured { get; set; }
        public DateTime UpdateDate { get; set; }
        public int UpdateBy { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime InsertDate { get; set; }
        public int InsertBy { get; set; }


    }
}
