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
    public class IndexModel : PageModel
    {
        private readonly DemetraShop.Data.DemetraShopContext _context;

        public IndexModel(DemetraShop.Data.DemetraShopContext context)
        {
            _context = context;
        }

        public IList<Plant> Plant { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Plant != null)
            {
                Plant = await _context.Plant.ToListAsync();
            }
        }
    }
}
