using API_de_Conversion_de_Unidades.Models;

namespace API_de_Conversion_de_Unidades.Services
{
    public class ConversionService : IConversionService
    {
        // Formula: F = C * (9/5) + 32
        public ConversionResponse ConvertCelsiusToFahrenheit(decimal celsius)
        {
            decimal fahrenheit = celsius * (9m / 5m) + 32m;

            return new ConversionResponse
            {
                OriginalValue = celsius,
                ConvertedValue = fahrenheit,
                UnitFrom = "Celsius",
                UnitTo = "Fahrenheit"
            };
        }

        // Formula: C = (F - 32) * (5/9)
        public ConversionResponse ConvertFahrenheitToCelsius(decimal fahrenheit)
        {
            decimal celsius = (fahrenheit - 32m) * (5m / 9m);

            return new ConversionResponse
            {
                OriginalValue = fahrenheit,
                ConvertedValue = celsius,
                UnitFrom = "Fahrenheit",
                UnitTo = "Celsius"
            };
        }
    }
}
