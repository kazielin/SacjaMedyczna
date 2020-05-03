using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SacjaMedyczna.Model;


namespace SacjaMedyczna.Pages.Stacja
{
    public class DodajModel : PageModel
    {
        private readonly ApplicationDbContext _db;
        public DodajModel(ApplicationDbContext db)
        {
            _db = db;
        }
        [BindProperty]
        public DaneOsobowe daneOs { get; set; }
        public void OnGet()
        {

        }

        public async Task<IActionResult> OnPost()
        {
            if (ModelState.IsValid)
            {
                await _db.DaneOsosboweDB.AddAsync(daneOs);
                await _db.SaveChangesAsync();
                return RedirectToPage("Testing");
            }
            else
            {
                return Page();
            }
        }
    }
}