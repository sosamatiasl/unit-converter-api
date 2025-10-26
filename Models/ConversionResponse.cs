namespace API_de_Conversion_de_Unidades.Models
{
    public class ConversionResponse
    {
        public string UnitFrom { get; set; } = string.Empty;
        public string UnitTo { get; set; } = string.Empty;
        public decimal OriginalValue { get; set; }
        public decimal ConvertedValue { get; set; }
        public DateTime Timestamp { get; set; } = DateTime.UtcNow;
    }
}
