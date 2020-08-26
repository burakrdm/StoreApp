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
    public class CategoryManager : ICategoryManager
    {
        ICategoryDal _CategoryDal;
        
        public CategoryManager()
        {
            //dependecy injection
            _CategoryDal = new EfCategoryDal();
        }


        public ResultMessage Add(Category entity)
        {
            ResultMessage result = new ResultMessage();
            result.isSuccess = false;

            #region Validation

            if (entity.Name.Length==0)
            {
                result.Message = "Kategori adı belirtmelisiniz.";
                return result;
            }
            if (entity.Name.Length > 50)
            {
                result.Message = "Kategori adı için fazla karakter girdiniz.";
                return result;
            }
            #endregion
            try
            {
                _CategoryDal.Add(entity);
                result.isSuccess = true;
            }
            catch (Exception e)
            {

                result.Message=string.Format("Bir hata oluştu:{0}",e.Message);
                return result;
            }
                return result;
        }

        public ResultMessage Delete(Category entity)
        {
            ResultMessage result = new ResultMessage();
            result.isSuccess = false;

            #region Validation

            #endregion
            try
            {
                _CategoryDal.Delete(entity);
                result.isSuccess = true;
            }
            catch (Exception e)
            {
                result.Message = string.Format("Bir hata oluştu:{0}", e.Message);
                return result;
            }
            return result;
        }

        public Category Get(int id)
        {

            return _CategoryDal.Get(id);
        }

        public IQueryable<Category> GetAll()
        {
            return _CategoryDal.GetAll();
        }

        public ResultMessage Update(Category entity)
        {
            ResultMessage result = new ResultMessage();
            result.isSuccess = false;

            #region Validation

            if (entity.Name.Length == 0)
            {
                result.Message = "Kategori adı belirtmelisiniz.";
                return result;
            }
            if (entity.Name.Length > 50)
            {
                result.Message = "Kategori adı için fazla karakter girdiniz.";
                return result;
            }
            #endregion
            try
            {
                _CategoryDal.Update(entity);
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
