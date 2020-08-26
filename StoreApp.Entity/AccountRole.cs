using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreApp.Entity
{
    public class AccountRole
    {
        public int ID { get; set; }
        [StringLength(30)]
        public string RoleName { get; set; }
        [StringLength(30)]
        public string Description { get; set; }

        public DateTime UpdateDate { get; set; }
        public int UpdateBy { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime InsertDate { get; set; }
        public int InsertedBy { get; set; }

    }
}
