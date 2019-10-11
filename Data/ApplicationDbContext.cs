using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using KrazyKookiesWeb.Data;

namespace KrazyKookiesWeb.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<KrazyKookiesWeb.Data.KookieStore> KookieStore { get; set; }
        public DbSet<KrazyKookiesWeb.Data.Manufacturer> Manufacturer { get; set; }
        public DbSet<KrazyKookiesWeb.Data.KKs> KKs { get; set; }
    }
}
