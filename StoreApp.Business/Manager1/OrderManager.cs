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
    public class OrderManager:IOrderManager
    {
        IOrderDal _OrderDal;

        public OrderManager()
        {
            _OrderDal = new EfOrderDal();
        }

        public ResultMessage Add(Order entity)
        {

            ResultMessage result = new ResultMessage();
            result.isSuccess = false;

            if (entity.ProductID == 0)
            {
                result.Message = "Ürün belirtmelisiniz.";
                return result;
            }
            if (entity.ProductID > 500)
            {
                result.Message = "Ürün için karakter girdiniz.";
                return result;
            }

            try
            {
                _OrderDal.Add(entity);
                result.isSuccess = true;
            }
            catch (Exception e)
            {

                result.Message = string.Format("Bir hata oluştu:{0}", e.Message);
                return result;
            }
            return result;
        }

        public ResultMessage Delete(Order entity)
        {
            ResultMessage result = new ResultMessage();
            result.isSuccess = false;

            #region Validation

            #endregion
            try
            {
                _OrderDal.Delete(entity);
                result.isSuccess = true;
            }
            catch (Exception e)
            {
                result.Message = string.Format("Bir hata oluştu:{0}", e.Message);
                return result;
            }
            return result;
        }

        public Order Get(int id)
        {
            return _OrderDal.Get(id);
        }

        public IQueryable<Order> GetAll()
        {
            return _OrderDal.GetAll();
        }

        public ResultMessage Update(Order entity)
        {
            ResultMessage result = new ResultMessage();
            result.isSuccess = false;

            #region Validation

            if (entity.ProductID == 0)
            {
                result.Message = "Ürün belirtmelisiniz.";
                return result;
            }
            if (entity.ProductID > 5000)
            {
                result.Message = "Ürün için fazla karakter girdiniz.";
                return result;
            }
            #endregion
            try
            {
                _OrderDal.Update(entity);
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
