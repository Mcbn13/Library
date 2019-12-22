using Core.Utilities.Results;
using Library.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Library.Business.Abstract
{
    public interface IAuthorService
    {
        IDataResult<Author> GetById(int authorId);

        IDataResult<List<Author>> GetList();

        IResult Insert(Author author);

        IResult Delete(Author author);

        IResult Update(Author author);
    }
}
