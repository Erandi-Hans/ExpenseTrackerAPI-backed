using ExpenseTrackerAPI_backed.Model; 
using Microsoft.EntityFrameworkCore;
using ExpenseTrackerAPI_backed.Controllers;

namespace ExpenseTrackerAPI_backed.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Expense> Expenses { get; set; }
    }
}