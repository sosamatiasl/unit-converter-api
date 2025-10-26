using API_de_Conversion_de_Unidades.Models;
using Microsoft.EntityFrameworkCore;

namespace API_de_Conversion_de_Unidades.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<AuditRecord> AuditRecords { get; set; }
    }
}
