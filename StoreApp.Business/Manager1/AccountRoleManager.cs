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
    public class AccountRoleManager : IAccountRoleManager
    {
        IAccountRoleDal _AccountRoleDal;

        public AccountRoleManager()
        {
            _AccountRoleDal = new EfAccountRoleDal();
        }
        public ResultMessage Add(AccountRole entity)
        {
            ResultMessage result = new ResultMessage();
            result.isSuccess = false;

            if (entity.RoleName.Length == 0)
            {
                result.Message = "Rolünüzü belirtmelisiniz.";
                return result;
            }
            if (entity.RoleName.Length > 30)
            {
                result.Message = "Rolünüz için fazla karakter girdiniz.";
                return result;
            }

            try
            {
                _AccountRoleDal.Add(entity);
                result.isSuccess = true;
            }
            catch (Exception e)
            {

                result.Message = string.Format("Bir hata oluştu:{0}", e.Message);
                return result;
            }
            return result;
        }

        public ResultMessage Delete(AccountRole entity)
        {
            ResultMessage result = new ResultMessage();
            result.isSuccess = false;

            #region Validation

            #endregion
            try
            {
                _AccountRoleDal.Delete(entity);
                result.isSuccess = true;
            }
            catch (Exception e)
            {
                result.Message = string.Format("Bir hata oluştu:{0}", e.Message);
                return result;
            }
            return result;
        }

        public AccountRole Get(int id)
        {
            return _AccountRoleDal.Get(id);
        }

        public IQueryable<AccountRole> GetAll()
        {
            return _AccountRoleDal.GetAll();
        }

        public ResultMessage Update(AccountRole entity)
        {
            ResultMessage result = new ResultMessage();
            result.isSuccess = false;

            #region Validation

            if (entity.RoleName.Length == 0)
            {
                result.Message = "Rolünüzü belirtmelisiniz.";
                return result;
            }
            if (entity.RoleName.Length > 50)
            {
                result.Message = "Rolünüz için fazla karakter girdiniz.";
                return result;
            }
            #endregion
            try
            {
                _AccountRoleDal.Update(entity);
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
