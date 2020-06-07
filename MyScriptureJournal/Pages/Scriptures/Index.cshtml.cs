using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MyScriptureJournal.Models;

namespace MyScriptureJournal.Pages.Scriptures
{
    public class IndexModel : PageModel
    {
        private readonly MyScriptureJournal.Models.MyScriptureJournalContext _context;

        public IndexModel(MyScriptureJournal.Models.MyScriptureJournalContext context)
        {
            _context = context;
        }

        
        public IList<Scripture> Scripture { get;set; }

        public string BookSort { get; set; }
        public string DateSort { get; set; }

        [BindProperty(SupportsGet = true)]
        public string SearchString { get; set; }

        [BindProperty(SupportsGet = true)]
        public string SearchString1 { get; set; }


        public async Task OnGetAsync(string sortBookAndDate)
        {
            //order
            BookSort = String.IsNullOrEmpty(sortBookAndDate) ? "book_desc" : "";
            DateSort = sortBookAndDate == "Date" ? "date_desc" : "Date";

            
            var scriptures = from m in _context.Scripture
                             select m;

            if (!string.IsNullOrEmpty(SearchString))
            {
                scriptures = scriptures.Where(s => s.BookName.Contains(SearchString));

            }

            if (!string.IsNullOrEmpty(SearchString1))
            {
                scriptures = scriptures.Where(s => s.Note.Contains(SearchString1));

            }
            switch (sortBookAndDate)
            {
                case "book_desc":
                    scriptures = scriptures.OrderByDescending(s => s.BookName);
                    break;
                case "Date":
                    scriptures = scriptures.OrderBy(s => s.DateAdded);
                    break;
                case "date_desc":
                    scriptures = scriptures.OrderByDescending(s => s.DateAdded);
                    break;
                default:
                    scriptures = scriptures.OrderBy(s => s.BookName);
                    break;
            }           
           

            Scripture = await scriptures.ToListAsync();

            
        }
    }
}
