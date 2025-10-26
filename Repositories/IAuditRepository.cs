using API_de_Conversion_de_Unidades.Models;

namespace API_de_Conversion_de_Unidades.Repositories
{
    public interface IAuditRepository
    {
        Task AddRecordAsync(AuditRecord record);
    }
}
