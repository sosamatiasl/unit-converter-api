using API_de_Conversion_de_Unidades.Data;
using API_de_Conversion_de_Unidades.Models;

namespace API_de_Conversion_de_Unidades.Repositories
{
    public class AuditRepository : IAuditRepository
    {
        private readonly AppDbContext _context;

        public AuditRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task AddRecordAsync(AuditRecord record)
        {
            _context.AuditRecords.Add(record);
            await _context.SaveChangesAsync();
        }
    }
}
