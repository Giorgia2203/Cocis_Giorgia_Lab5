using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Cocis_Giorgia_Lab5.Model;

namespace Cocis_Giorgia_Lab5.Model
{
    public class ExpenseContext : DbContext
    {
        public ExpenseContext(DbContextOptions<ExpenseContext>options):base(options)
        {

        }

        public DbSet<ExpenseDTO> ExpenseDTO { get; set; }

        public DbSet<Budget> Budget { get; set; }
    }
}
