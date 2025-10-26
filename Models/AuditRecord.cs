namespace API_de_Conversion_de_Unidades.Models
{
    public class AuditRecord
    {
        public int Id { get; set; }
        public string OperationType { get; set; } = string.Empty;
        public decimal InputValue { get; set; }
        public decimal OutputValue { get; set; }
        public DateTime ConversionDate { get; set; }
    }
}
