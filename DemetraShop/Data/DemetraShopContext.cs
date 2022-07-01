using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using DemetraShop.Models;

namespace DemetraShop.Data
{
    public class DemetraShopContext : DbContext
    {
        public DemetraShopContext (DbContextOptions<DemetraShopContext> options)
            : base(options)
        {
        }

        public DbSet<DemetraShop.Models.Plant>? Plant { get; set; }
    }
}
