using Microsoft.AspNetCore.Mvc;
using System.Linq;

// Asegúrate de que el espacio de nombres sea correcto.
namespace ServiciosDeFacturacion
{
    [Route("Empresa")]
    [ApiController]
    public class EmpresaController : ControllerBase
    {
        // Mock de datos de empresas para demostración.
        private Empresa[] empresas = new Empresa[]
        {
            new Empresa
            {
                NombreCliente = "Johan Andres",
                ApellidosCliente = "Zamudio",
                EdadCliente = 20,
                GiroEmpresa = "Restaurante",
                MontoIVAaPagar = 6,
                MontoUtilidades = 87587,
                MontoVentas = 3000000,
                NombreEmpresa = "Juanito's",
                RutCliente = "23435324",
                RutEmpresa = "324323",
                TotalVentas = 300
            },
            new Empresa
            {
                NombreCliente = "Andres Julio",
                ApellidosCliente = "Gonzales",
                EdadCliente = 56,
                GiroEmpresa = "Supermercado",
                MontoIVAaPagar = 12,
                MontoUtilidades = 878768,
                MontoVentas = 3000000,
                NombreEmpresa = "Acuenta",
                RutCliente = "2342234",
                RutEmpresa = "5322534",
                TotalVentas = 300
            },
            new Empresa
            {
                NombreCliente = "Mariano jose",
                ApellidosCliente = "Perez gutierres",
                EdadCliente = 43,
                GiroEmpresa = "Botilleria",
                MontoIVAaPagar = 15,
                MontoUtilidades = 554033,
                MontoVentas = 3000000,
                NombreEmpresa = "Juanito boti",
                RutCliente = "92839",
                RutEmpresa = "7236787",
                TotalVentas = 300
            }
        };

        // Obtener la lista de todas las empresas.
        [HttpGet("Empresa")]
        public IActionResult GetEmpresas()
        {
            return Ok(empresas);
        }

        // Obtener las primeras tres empresas.
        [HttpGet("tres-empresas")]
        public IActionResult GetTresEmpresas()
        {
            var tresEmpresas = empresas.Take(3).ToList();
            return Ok(tresEmpresas);
        }

        // Obtener una empresa por su número de identificación (RUT).
        [HttpGet("Empresa/{rutEmpresa}")]
        public IActionResult GetEmpresa(string rutEmpresa)
        {
            var empresa = empresas.FirstOrDefault(e => e.RutEmpresa == rutEmpresa);
            if (empresa == null)
            {
                return NotFound("Empresa no encontrada");
            }
            return Ok(empresa);
        }

        // Crear una nueva empresa.
        [HttpPost("Empresa")]
        public IActionResult CrearEmpresa([FromBody] Empresa empresa)
        {
            // Añadir código para agregar la empresa a la lista de empresas si es necesario.
            // Empresas.Add(empresa);
            return CreatedAtAction("GetEmpresa", new { rutEmpresa = empresa.RutEmpresa }, empresa);
        }
    }
}
