using Core.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Library.Entities.Concrete
{
    public class Book : IEntity
    {
        public int BookId { get; set; }

        public string Title { get; set; }

        public decimal LoanPrice { get; set; }

        public short UnitInStock { get; set; }

        public int Page { get; set; }

        public short Edition { get; set; }

        public DateTime PublishDate { get; set; }

        public string ImageUrl { get; set; }

        public string ImageThumbnailUrl { get; set; }

        public int LanguageId { get; set; }

        [ForeignKey("Publisher")]
        public int PublisherId { get; set; }

        [ForeignKey("Author")]
        public int AuthorId { get; set; }

        public int CategoryId { get; set; }

        public virtual Author Author { get; set; }

        public virtual Publisher Publisher { get; set; }

        public virtual Category Category { get; set; }

        public virtual Language Language { get; set; }

        public virtual ICollection<Loan> Loan { get; set; }
    }
}
