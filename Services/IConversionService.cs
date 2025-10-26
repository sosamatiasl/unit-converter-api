using API_de_Conversion_de_Unidades.Models;

namespace API_de_Conversion_de_Unidades.Services
{
    public interface IConversionService
    {
        ConversionResponse ConvertCelsiusToFahrenheit(decimal celsius);
        ConversionResponse ConvertFahrenheitToCelsius(decimal fahrenheit);
    }
}
