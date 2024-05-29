using Microsoft.AspNetCore.Mvc;
using web_ventas_ds504.Data;
using web_ventas_ds504.Models;

namespace web_ventas_ds504.Controllers
{
    public class VentaController : Controller
    {
        private readonly ApplicationDbContext _context;

        public VentaController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            IEnumerable<Venta> ListarVenta = _context.Venta;
            return View(ListarVenta);
        }
    }
}
