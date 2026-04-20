using Microsoft.AspNetCore.Mvc;

namespace NanoGuardian.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AlertasController : ControllerBase
    {
        [HttpGet]
        public IActionResult ObtenerAlerta()
        {
            return Ok(new
            {
                paciente = "Ismael",
                fuerzaImpactoG = 8,
                estado = "Emergencia"
            });
        }
    }
}