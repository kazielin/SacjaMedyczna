using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using SacjaMedyczna.Model;

namespace SacjaMedyczna.Pages.Stacja
{
    public class TestingModel : PageModel
    {
        private readonly ApplicationDbContext _db;

        public TestingModel(ApplicationDbContext db)
        {
            _db = db;
        }

        public IEnumerable<Example> Examples { get; set; }
        public IEnumerable<DaneOsobowe> DaneOs { get; set; }
        public async Task OnGet()
        {
            Examples = await _db.Ecample.ToListAsync();
            DaneOs = await _db.DaneOsosboweDB.ToListAsync();
        }
        public async Task<IActionResult> OnPostDelete(int id)
        {
            var dane = await _db.DaneOsosboweDB.FindAsync(id);
            _db.DaneOsosboweDB.Remove(dane);
            await _db.SaveChangesAsync();
            return RedirectToPage("Testing");
        }
    }
}