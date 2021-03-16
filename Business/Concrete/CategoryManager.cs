using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class CategoryManager : ICategoryService
    {
        ICategoryDal _ctegoryDal;

        public CategoryManager(ICategoryDal ctegoryDal)
        {
            _ctegoryDal = ctegoryDal;
        }

        public List<Category> GetAll()
        {
            //iş kodları
            return _ctegoryDal.GetAll();
        }

        public Category GetById(int categoryId)
        {
            return _ctegoryDal.Get(c => c.CategoryId == categoryId);
        }
    }
}
