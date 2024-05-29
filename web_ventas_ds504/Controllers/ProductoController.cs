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

        [HttpGet]
        public JsonResult Listar()
        {
            List<Producto> arr_producto = _context.Producto.ToList();
            return Json(new { data = arr_producto });
        }

        [HttpGet]
        public JsonResult Consultar(string codigo_producto)
        {
            Producto producto = _context.Producto.FirstOrDefault(p => p.CodigoProducto == codigo_producto);
            return Json(producto);
        }

        [HttpPost]
        public IActionResult Grabar([FromBody] Producto producto)
        {
            bool rpta = true;
            try
            {
                Producto tmp_producto = _context.Producto.FirstOrDefault(p => p.CodigoProducto == producto.CodigoProducto);

                if (tmp_producto == null)
                {
                    _context.Producto.Add(producto);
                }
                else
                {
                    tmp_producto.producto = producto.producto;
                    tmp_producto.StockDisponible = producto.StockDisponible;
                    tmp_producto.Costo = producto.Costo;
                    tmp_producto.Ganancia = producto.Ganancia;
                    tmp_producto.ProductoCodigoMarca = producto.ProductoCodigoMarca;
                    tmp_producto.ProductoCodigoCategoria = producto.ProductoCodigoCategoria;
                }

                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                rpta = false;
            }
            return Json(new { resultado = rpta });
        }

        [HttpGet]
        public JsonResult Borrar(string codigo_producto)
        {
            bool rpta = true;

            try
            {
                Producto producto = _context.Producto.FirstOrDefault(p => p.CodigoProducto == codigo_producto);
                _context.Producto.Remove(producto);
                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                rpta = false;
            }
            return Json(new { resultado = rpta });
        }
    }
}
