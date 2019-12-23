using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Library.Data;
using Library.Models;

namespace Library.Pages.Admin.Book
{
    public class CreateModel : PageModel
    {
        private readonly Library.Data.ApplicationDbContext _context;

        public CreateModel(Library.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
        ViewData["AuthorId"] = new SelectList(_context.Authors, "AuthorId", "FirstName");
        ViewData["CategoryId"] = new SelectList(_context.Categories, "CategoryId", "Name");
        ViewData["LanguageId"] = new SelectList(_context.Languages, "LanguageId", "LanguageName");
        ViewData["PublisherId"] = new SelectList(_context.Publishers, "PublisherId", "PublisherName");
            return Page();
        }

        [BindProperty]
        public Library.Models.Book Book { get; set; }

        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Books.Add(Book);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
