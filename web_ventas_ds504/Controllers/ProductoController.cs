using Microsoft.AspNetCore.Mvc;
using web_ventas_ds504.Data;
using web_ventas_ds504.Models;

namespace web_ventas_ds504.Controllers
{
    public class ProductoController : Controller
    {
        private readonly ApplicationDbContext _context;
        public ProductoController(ApplicationDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            IEnumerable<Producto> ListarProducto = _context.Producto;
            return View(ListarProducto);
        }
    }
}
