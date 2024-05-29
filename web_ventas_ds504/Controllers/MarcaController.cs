using Microsoft.AspNetCore.Mvc;
using web_ventas_ds504.Data;
using web_ventas_ds504.Models;

namespace web_ventas_ds504.Controllers
{
    public class MarcaController : Controller
    {
        private readonly ApplicationDbContext _context;
        public MarcaController(ApplicationDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            IEnumerable<Marca> ListarMarca = _context.Marca;
            return View(ListarMarca);
        }
    }
}
