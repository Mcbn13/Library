using Core.Utilities.Results;
using Library.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Library.Business.Abstract
{
    public interface ICategoryService
    {
        IDataResult<Category> GetById(int bookId);

        IDataResult<List<Category>> GetList();

        IDataResult<List<Category>> GetListByCategory(int categoryId);

        IResult Insert(Category category);

        IResult Delete(Category category);

        IResult Update(Category category);
    }
}
