using StoreApp.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StoreApp.MVCWebUI.Models
{
    public class LoginModel
    {

        public LoginModel()
        {
            AccountUserList = new List<AccountUser>();
        }
        public List<AccountUser> AccountUserList { get; set; }
        public string UserName { get; set; }

        public int Password { get; set; }

        public int RoleIdAccountRoleId { get; set; }
    }
}