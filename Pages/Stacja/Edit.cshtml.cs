using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SacjaMedyczna.Model;

namespace SacjaMedyczna.Pages.Stacja
{
    public class EditModel : PageModel
    {
        private ApplicationDbContext _db;
        public EditModel(ApplicationDbContext db)
        {
            _db = db;
        }
        [BindProperty]
        public DaneOsobowe daneOs { get; set; }
        public async Task OnGet(int id)
        {
            daneOs = await _db.DaneOsosboweDB.FindAsync(id);

        }
        public async Task<IActionResult> OnPost()
        {
            if (ModelState.IsValid)
            {
                var daneOFromDB = await _db.DaneOsosboweDB.FindAsync(daneOs.ID);
                daneOFromDB.Imie = daneOs.Imie;
                daneOFromDB.Nazwisko = daneOs.Nazwisko;
                daneOFromDB.Pesel = daneOs.Pesel;
                daneOFromDB.NumerDowodu = daneOs.NumerDowodu;
                daneOFromDB.DataUrodzenia = daneOs.DataUrodzenia;
                daneOFromDB.NumerTelefonu = daneOs.NumerTelefonu;
                daneOFromDB.Name = daneOs.Name;

                await _db.SaveChangesAsync();
                return RedirectToPage("Testing");
            }
            return RedirectToPage();
            
        }
        public async Task<IActionResult> OnPostDelete(int id)
        {
            return RedirectToPage("Testing");
        }
    }
}