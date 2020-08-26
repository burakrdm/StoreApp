using StoreApp.Business.Abstract1;
using StoreApp.DataAccess.Abstract;
using StoreApp.DataAccess.Concrete.EntityFramework;
using StoreApp.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreApp.Business.Manager1
{
    public class AccountUserManager : IAccountUserManager
    {
        IAccountUserDal _AccountUserDal;
        public AccountUserManager()
        {
            _AccountUserDal = new EfAccountUserDal();
        }
        public ResultMessage Add(AccountUser entity)
        {
            ResultMessage result = new ResultMessage();
            result.isSuccess = false;

            if (entity.UserName.Length == 0)
            {
                result.Message = "Adınızı belirtmelisiniz.";
                return result;
            }
            if (entity.UserName.Length > 50)
            {
                result.Message = "Adınız için fazla karakter girdiniz.";
                return result;
            }

            try
            {
                _AccountUserDal.Add(entity);
                result.isSuccess = true;
            }
            catch (Exception e)
            {

                result.Message = string.Format("Bir hata oluştu:{0}", e.Message);
                return result;
            }
            return result;
        }

        public ResultMessage Delete(AccountUser entity)
        {
            ResultMessage result = new ResultMessage();
            result.isSuccess = false;

            #region Validation

            #endregion
            try
            {
                _AccountUserDal.Delete(entity);
                result.isSuccess = true;
            }
            catch (Exception e)
            {
                result.Message = string.Format("Bir hata oluştu:{0}", e.Message);
                return result;
            }
            return result;
        }

        public AccountUser Get(int id)
        {
            return _AccountUserDal.Get(id);
        }

        public IQueryable<AccountUser> GetAll()
        {
            return _AccountUserDal.GetAll();
        }

        public ResultMessage Update(AccountUser entity)
        {
            ResultMessage result = new ResultMessage();
            result.isSuccess = false;

            #region Validation

            if (entity.UserName.Length == 0)
            {
                result.Message = "Adınızı belirtmelisiniz.";
                return result;
            }
            if (entity.UserName.Length > 50)
            {
                result.Message = "Adınıziçin fazla karakter girdiniz.";
                return result;
            }
            #endregion
            try
            {
                _AccountUserDal.Update(entity);
                result.isSuccess = true;
            }
            catch (Exception e)
            {
                result.Message = string.Format("Bir hata oluştu:{0}", e.Message);
                return result;
            }
            return result;
        }
    }
}
