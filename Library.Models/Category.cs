using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Library.Models
{
    public class Category
    {
        [Key]
        public int CategoryId { get; set; }
        [Required]
        [Display(Name="Category Name")]
        public string Name { get; set; }

        public virtual ICollection<Book> Book { get; set; }
    }
}
