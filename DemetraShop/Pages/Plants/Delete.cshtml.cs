using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using DemetraShop.Data;
using DemetraShop.Models;

namespace DemetraShop.Pages.Plants
{
    public class DeleteModel : PageModel
    {
        private readonly DemetraShop.Data.DemetraShopContext _context;

        public DeleteModel(DemetraShop.Data.DemetraShopContext context)
        {
            _context = context;
        }

        [BindProperty]
      public Plant Plant { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Plant == null)
            {
                return NotFound();
            }

            var plant = await _context.Plant.FirstOrDefaultAsync(m => m.Id == id);

            if (plant == null)
            {
                return NotFound();
            }
            else 
            {
                Plant = plant;
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null || _context.Plant == null)
            {
                return NotFound();
            }
            var plant = await _context.Plant.FindAsync(id);

            if (plant != null)
            {
                Plant = plant;
                _context.Plant.Remove(Plant);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
