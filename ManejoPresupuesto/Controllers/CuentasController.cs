using ManejoPresupuesto.Servicios;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace ManejoPresupuesto.Controllers
{
    public class CuentasController : Controller
    {
        public IRepositorioTiposCuentas RepositorioTiposCuentas { get; }
        public IServicioUsuarios ServicioUsuarios { get; }

        public CuentasController(IRepositorioTiposCuentas repositorioTiposCuentas, IServicioUsuarios servicioUsuarios)
        {
            RepositorioTiposCuentas = repositorioTiposCuentas;
            ServicioUsuarios = servicioUsuarios;
        }

        [HttpGet]
        public async Task<IActionResult> Crear()
        {
            var usuarioId = ServicioUsuarios.ObtenerUsuarioId();

            var tiposCuentas = await RepositorioTiposCuentas.Obtener(usuarioId);

            var modelo = new Models.CuentaCreacionViewModel();

            modelo.TiposCuentas = tiposCuentas.Select(x => new SelectListItem(x.Nombre, x.Id.ToString()));

            return View(modelo);
        }
    }
}
