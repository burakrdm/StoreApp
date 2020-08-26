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
    public class AccountPersonManager : IAccountPersonManager
    {
        IAccountPersonDal _AccountPersonDal;
        public AccountPersonManager()
        {
            _AccountPersonDal = new EfAccountPersonDal();
        }
        public ResultMessage Add(AccountPerson entity)
        {
            ResultMessage result = new ResultMessage();
            result.isSuccess = false;

            if (entity.FirstName.Length == 0)
            {
                result.Message = "Adınızı belirtmelisiniz.";
                return result;
            }
            if (entity.FirstName.Length > 50)
            {
                result.Message = "Adınız için fazla karakter girdiniz.";
                return result;
            }

            try
            {
                _AccountPersonDal.Add(entity);
                result.isSuccess = true;
            }
            catch (Exception e)
            {

                result.Message = string.Format("Bir hata oluştu:{0}", e.Message);
                return result;
            }
            return result;
        }

        public ResultMessage Delete(AccountPerson entity)
        {
            ResultMessage result = new ResultMessage();
            result.isSuccess = false;

            #region Validation

            #endregion
            try
            {
                _AccountPersonDal.Delete(entity);
                result.isSuccess = true;
            }
            catch (Exception e)
            {
                result.Message = string.Format("Bir hata oluştu:{0}", e.Message);
                return result;
            }
            return result;
        }

        public AccountPerson Get(int id)
        {
            return _AccountPersonDal.Get(id);
        }

        public IQueryable<AccountPerson> GetAll()
        {
            return _AccountPersonDal.GetAll();
        }

        public ResultMessage Update(AccountPerson entity)
        {
            ResultMessage result = new ResultMessage();
            result.isSuccess = false;

            #region Validation

            if (entity.FirstName.Length == 0)
            {
                result.Message = "Adınızı belirtmelisiniz.";
                return result;
            }
            if (entity.FirstName.Length > 50)
            {
                result.Message = "Adınıziçin fazla karakter girdiniz.";
                return result;
            }
            #endregion
            try
            {
                _AccountPersonDal.Update(entity);
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
