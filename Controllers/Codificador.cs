using Microsoft.AspNetCore.Mvc;

namespace CesarApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CesarController : ControllerBase
    {
        [HttpGet("decodificar")]
        public IActionResult Decodificar([FromQuery] string texto, [FromQuery] int desplazamiento)
        {
            if (string.IsNullOrWhiteSpace(texto))
            {
                return BadRequest("El texto no puede estar vacío.");
            }

            string resultado = DecodificarCesar(texto, desplazamiento);
            return Ok(new { mensajeDecodificado = resultado });
        }

        private string DecodificarCesar(string texto, int desplazamiento)
        {
            string resultado = "";

            foreach (char caracter in texto)
            {
                if (char.IsLetter(caracter))
                {
                    char baseChar = char.IsUpper(caracter) ? 'A' : 'a';
                    char decodificado = (char)(((caracter - baseChar - desplazamiento + 26) % 26) + baseChar);
                    resultado += decodificado;
                }
                else
                {
                    resultado += caracter;
                }
            }

            return resultado;
        }
    }
}
