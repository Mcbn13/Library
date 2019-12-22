using Core.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Library.Entities.Concrete
{
    public class Loan : IEntity
    {
        [Key]
        public int UserId { get; set; }

        [Key]
        public int BookId { get; set; }

        public bool IsBack { get; set; }

        public DateTime LoanDate { get; set; }

        public DateTime ReturnDate { get; set; }

        public virtual Book Book { get; set; }

        public virtual User User { get; set; }
    }
}
