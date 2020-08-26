using StoreApp.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using System.ComponentModel.DataAnnotations;
using StoreApp.Business.Abstract1;
using StoreApp.Business.Manager1;
using StoreApp.MVCWebUI.Models;
using StoreApp.DataAccess.Concrete.EntityFramework;


namespace StoreApp.MVCWebUI.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login

       
        public ActionResult ForgotPassword()
        {
            return View();
        }

        public ActionResult Index()
        {

            return View();
        }

        [HttpPost]

        [ValidateAntiForgeryToken]
        public ActionResult Login(AccountUser objUser)
        {


            if (ModelState.IsValid)
            {


                using (StoreContext db = new StoreContext())
                {

                    var obj = db.AccountUsers.Where(a => a.UserName.Equals(objUser.UserName) && a.Password.Equals(objUser.Password)).FirstOrDefault();
                    if (obj == null)
                    {
                        TempData["LoginMessage"] = "Kullanıcı adı veya şifre yanlış!";
                        return Redirect("/Login/Index");
                    }

                    var obj1 = db.AccountUsers.Where(a => a.UserName.Equals(objUser.UserName) && a.Password.Equals(objUser.Password) && a.AccountRoleID == 1).FirstOrDefault();
                    if (obj1 != null)
                    {
                        Session.Add("ActiveUser", objUser.UserName);
                        Session.Add("ActiveUserID", obj1.ID);
                        return Redirect("/Category/Index");


                    }

                    else
                    {
                        Session.Add("ActiveUser", obj.UserName);
                        Session.Add("ActiveUserID", obj.ID);
                        return Redirect("/Home/Index/");
                    }
                }
            }
            return View(objUser);
        }


        public ActionResult Logout()
        {
            // Oluşturulan session ismi ile o Session silinir.
            Session.Remove("ActiveUser");

            // Session Clear ile de tüm oluşturulanlar silinir.
            //Session.Clear();

            //return RedirectToAction("Logout", "Login");
            return View();
        }





    }



}
