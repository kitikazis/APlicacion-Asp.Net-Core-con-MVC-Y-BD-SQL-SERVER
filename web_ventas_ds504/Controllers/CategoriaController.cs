using Microsoft.AspNetCore.Mvc;
using web_ventas_ds504.Data;
using web_ventas_ds504.Models;

namespace web_ventas_ds504.Controllers
{
    public class CategoriaController : Controller
    {
        private readonly ApplicationDbContext _context;

        public CategoriaController(ApplicationDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            IEnumerable<Categoria> ListarCategoria = _context.Categoria;
            return View(ListarCategoria);
        }
    }
}
