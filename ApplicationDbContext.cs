using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Crud_3._0.Data;

namespace Crud_3._0.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<Crud_3._0.Data.Departments> Departments { get; set; }
        public DbSet<Crud_3._0.Data.Employee> Employee { get; set; }
    }
}
