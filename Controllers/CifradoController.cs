using Microsoft.AspNetCore.Mvc;

namespace CesarApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CifradoController : ControllerBase
    {
        [HttpGet("{mensaje}/{desplazamiento}")]
        public IActionResult Cifrar(string mensaje, int desplazamiento)
        {
            string resultado = CifradoCesar(mensaje, desplazamiento);
            return Ok(new { original = mensaje, cifrado = resultado });
        }

        private string CifradoCesar(string texto, int desplazamiento)
        {
            string resultado = "";
            foreach (char c in texto)
            {
                if (char.IsLetter(c))
                {
                    char offset = char.IsUpper(c) ? 'A' : 'a';
                    char cifrado = (char)(((c - offset + desplazamiento) % 26) + offset);
                    resultado += cifrado;
                }
                else
                {
                    resultado += c;
                }
            }
            return resultado;
        }
    }
}

