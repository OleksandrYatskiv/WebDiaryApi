using Microsoft.EntityFrameworkCore;
using WebDiaryApi.Models;

namespace WebDiaryApi.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
            
        }

        public DbSet<DiaryEntry> DiaryEntries { get; set; }
    }
}
