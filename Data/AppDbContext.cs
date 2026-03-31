using ExpenseTrackerAPI_backed.Model; // ඔයාගේ Model folder එකේ නම මෙතන තියෙන්න ඕනේ
using Microsoft.EntityFrameworkCore;

namespace ExpenseTrackerAPI_backed.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Expense> Expenses { get; set; }
    }
}