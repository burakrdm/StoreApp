using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreApp.Entity
{
  public class Order
    {
        public int ID { get; set; }

        public int ProductID { get; set; }

        public decimal? Price { get; set; }

        public decimal? Amount { get; set; }

        public int? Piece { get; set; }

        public DateTime? OrderDate { get; set; }

        public int? UserID { get; set; }
        public DateTime UpdateDate { get; set; }
        public int UpdateBy { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime InsertDate { get; set; }
        public int InsertBy { get; set; }


    }
}
