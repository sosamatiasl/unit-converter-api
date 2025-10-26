using API_de_Conversion_de_Unidades.Models;
using API_de_Conversion_de_Unidades.Repositories;
using API_de_Conversion_de_Unidades.Services;
using Microsoft.AspNetCore.Mvc;

namespace API_de_Conversion_de_Unidades.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ConversionsController : ControllerBase
    {
        private readonly IConversionService _conversionService;
        private readonly IAuditRepository _auditRepository;

        public ConversionsController(IConversionService conversionService, IAuditRepository auditRepository)
        {
            _conversionService = conversionService;
            _auditRepository = auditRepository;
        }

        // GET: api/Conversions/celsius-to-fahrenheit?value=25
        [HttpGet("celsius-to-fahrenheit")]
        [ProducesResponseType(typeof(ConversionResponse), 200)]
        public async Task<IActionResult> CelsiusToFahrenheit([FromQuery] decimal value)
        {
            if (value < -273.15m) // Cero absoluto
            {
                return BadRequest("El valor Celsius no puede ser inferior al cero absoluto (-273.15).");
            }

            var response = _conversionService.ConvertCelsiusToFahrenheit(value);

            var auditRecord = new AuditRecord
            {
                OperationType = "CelsiusToFahrenheit",
                InputValue = response.OriginalValue,
                OutputValue = response.ConvertedValue,
                ConversionDate = response.Timestamp
            };
            await _auditRepository.AddRecordAsync(auditRecord);

            return Ok(response);
        }

        // GET: api/Conversions/fahrenheit-to-celsius?value=77
        [HttpGet("fahrenheit-to-celsius")]
        [ProducesResponseType(typeof(ConversionResponse), 200)]
        public async Task<IActionResult> FahrenheitToCelsius([FromQuery] decimal value)
        {
            if (value < -459.67m) // Cero absoluto
            {
                return BadRequest("El valor Fahrenheit no puede ser inferior al cero absoluto (-459.67).");
            }

            var response = _conversionService.ConvertFahrenheitToCelsius(value);

            var auditRecord = new AuditRecord
            {
                OperationType = "FahrenheitToCelsius",
                InputValue = response.OriginalValue,
                OutputValue = response.ConvertedValue,
                ConversionDate = response.Timestamp
            };
            await _auditRepository.AddRecordAsync(auditRecord);

            return Ok(response);
        }
    }
}
