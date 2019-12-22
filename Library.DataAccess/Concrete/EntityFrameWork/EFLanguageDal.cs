using Core.DataAccess.EntityFramework;
using Library.DataAccess.Abstract;
using Library.DataAccess.Concrete.EntityFrameWork.Contexts;
using Library.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Library.DataAccess.Concrete.EntityFrameWork
{
    public class EFLanguageDal : EfEntityRepositoryBase<Language, LibraryContext>, ILanguageDAL
    {
    }
}
