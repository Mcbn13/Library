using Core.Utilities.Results;
using Library.Business.Abstract;
using Library.Business.Constants;
using Library.DataAccess.Abstract;
using Library.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Library.Business.Concrete
{
    public class CategoryManager : ICategoryService
    {
        private ICategoryDAL _categoryDal;

        public CategoryManager(ICategoryDAL categoryDal)
        {
            _categoryDal = categoryDal;
        }

        public IDataResult<Category> GetById(int categoryId)
        {
            //Business codes
            return new SuccessDataResult<Category>(_categoryDal.Get(filter: x => x.CategoryId == categoryId));
        }

        public IDataResult<List<Category>> GetList()
        {
            //Business codes
            return new SuccessDataResult<List<Category>>(_categoryDal.GetList().ToList());
        }

        public IDataResult<List<Category>> GetListByCategory(int categoryId)
        {
            //Business codes
            return new SuccessDataResult<List<Category>>(_categoryDal.GetList(filter: x => x.CategoryId == categoryId).ToList());
        }

        public IResult Insert(Category category)
        {
            //Business codes
            _categoryDal.Insert(category);
            return new SuccessResult(message: Messages.CategoryInserted);
        }

        public IResult Update(Category category)
        {
            //Business codes
            _categoryDal.Update(category);
            return new SuccessResult(message: Messages.CategoryUpdated);
        }

        public IResult Delete(Category category)
        {
            //Business codes
            _categoryDal.Delete(category);
            return new SuccessResult(message: Messages.CategoryDeleted);
        }
    }
}
