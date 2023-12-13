using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Servicios.ContactosServices;

namespace ExaApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuarioController : ControllerBase
    {
            private const string connectionString = "Server=localhost;" + "Port=5432; User Id=postgres; Password=root; Database=Parcial;";
            private UsuarioService servicio;

            public UsuarioController()
            {
                servicio = new UsuarioService(connectionString);
            }

        [HttpGet("por-ruta/{id}")]
        public IActionResult ObtenerUsuarioAccion([FromRoute] int id)
        {
            var usuario = servicio.obtenerUsuarioPorId(id);
            return Ok(usuario);
        }

            [HttpPost]
            public IActionResult InsertarUsuarioAccion([FromBody] Infraestructura.Modelos.UsuarioModel usuario)
            {
                servicio.insertarUsuario(usuario);

                return Created("Se inserto con exito", usuario);
            }

            [HttpPut]

            public IActionResult ModificarPersonaAccion([FromBody] Infraestructura.Modelos.UsuarioModel usuario)
            {
                servicio.modificarUsuario(usuario);
                return Ok("Se actualizo con exito");
            }
        }
}
