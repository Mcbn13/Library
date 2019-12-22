using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Library.Entities.Concrete
{
    public class Language : IEntity
    {
        public int LanguageId { get; set; }

        public string LanguageName { get; set; }

        public virtual ICollection<Book> Book { get; set; }
    }
}
