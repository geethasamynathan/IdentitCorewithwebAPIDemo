using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IdentityCoreDemo.Models
{
    public class ProductDataContext : IdentityDbContext<ApplicationUser>
    {
        public ProductDataContext(DbContextOptions options) : base(options)
        {

        }       
        public DbSet<Product> Products { get; set; }
    }
}
