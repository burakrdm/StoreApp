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
    public class ProductManager : IProductManager
    {
        IProductDal _productDal;

        public ProductManager()
        {
            _productDal = new EfProductDal();
        }
        public ResultMessage Add(Product entity)
        {
            ResultMessage result = new ResultMessage();
            result.isSuccess = false;

            #region Validation

            if (entity.Name.Length == 0)
            {
                result.Message = "Ürün adı belirtmelisiniz.";
                return result;
            }
            if (entity.Name.Length > 50)
            {
                result.Message = "Ürün adı için fazla karakter girdiniz.";
                return result;
            }
            var _existingProduct = GetAll()
                .Where(i => i.Name == entity.Name)
                .FirstOrDefault();

            if (_existingProduct!=null)
            {
                result.Message = "bu ürün ismiyle aynı ürün zate mevcut lütfen başka isim seçiniz";
                return result;
            }

            #endregion
            try
            {
                _productDal.Add(entity);
                result.isSuccess = true;
            }
            catch (Exception e)
            {
                result.Message = string.Format("Bir hata oluştu:{0}", e.Message);
                return result;
            }
            return result;
        }

        public ResultMessage Delete(Product entity)
        {
            ResultMessage result = new ResultMessage();
            result.isSuccess = false;

            #region Validation

            
            #endregion
            try
            {
                _productDal.Delete(entity);
                result.isSuccess = true;
            }
            catch (Exception e)
            {
                result.Message = string.Format("Bir hata oluştu:{0}", e.Message);
                return result;
            }
            return result;
        }

        public Product Get(int id)
        {
            return _productDal.Get(id);
        }

        public IQueryable<Product> GetAll()
        {
            return _productDal.GetAll();
        }

        public ResultMessage Update(Product entity)
        {
            ResultMessage result = new ResultMessage();
            result.isSuccess = false;

            #region Validation

            if (entity.Name.Length == 0)
            {
                result.Message = "Ürün adı belirtmelisiniz.";
                return result;
            }
            if (entity.Name.Length > 50)
            {
                result.Message = "Ürün adı için fazla karakter girdiniz.";
                return result;
            }
            #endregion
            try
            {
                _productDal.Update(entity);
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
