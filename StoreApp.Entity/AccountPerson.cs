using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreApp.Entity
{
    public class AccountPerson
    {
        public int ID { get; set; }

        [StringLength(100)]
        public string FirstName { get; set; }

        [StringLength(150)]
        public string LastName { get; set; }
        [StringLength(512)]
        public string PicturePath { get; set; }
        [StringLength(15)]
        public string Phone { get; set; }
        public DateTime UpdateDate { get; set; }
        public int UpdateBy { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime InsertDate { get; set; }
        public int InsertedBy{ get; set; }
    }
}
