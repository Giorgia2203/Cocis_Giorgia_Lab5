using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Cocis_Giorgia_Lab5.Model
{
    public class ExpenseContext : DbContext
    {
        public ExpenseContext(DbContextOptions<ExpenseContext>options):base(options)
        {

        }

        public DbSet<ExpenseDTO> ExpenseDTO { get; set; }
    }
}
