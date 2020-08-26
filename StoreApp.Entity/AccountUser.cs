using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreApp.Entity
{
    public class AccountUser
    {
        public int ID { get; set; }

        public int PersonID { get; set; }
        public int AccountRoleID { get; set; }
        [StringLength(100)]
        public string UserName { get; set; }
        [StringLength(50)]
        public string UserMailAddress { get; set; }
        [StringLength(50)]
        public string Password { get; set; }
        public DateTime LastLoginDate { get; set; }
        public bool LockedOut { get; set; }
        public DateTime UpdateDate { get; set; }
        public int UpdateBy { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime InsertDate { get; set; }
        public int InsertBy { get; set; }
       

    }
}
