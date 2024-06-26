using ConexionEF.Entities;
using ConexionEF.Models;
using Microsoft.AspNetCore.Mvc;

namespace ConexionEF.Controllers
{
    public class TipoProductoController : Controller
    {
        public readonly ApplicationDbContext _context;

        public TipoProductoController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult TipoProductoAdd()
        {
            return View();
        }

        [HttpPost]
        public IActionResult TipoProductoAdd(TipoProductoModel modelo)
        {
            if (!ModelState.IsValid)
            {
                return View(modelo);
            }

            TipoProducto entity = new TipoProducto();
            entity.Id = new Guid();
            entity.Nombre = modelo.Nombre;
            entity.Descripcion = modelo.Descripcion;

            _context.TiposProductos.Add(entity);
            _context.SaveChanges();

            return RedirectToAction("TipoProductoList", "TipoProducto");
        }

        public IActionResult TipoProductoList()
        {
            List<TipoProductoModel> list = 
            _context.TiposProductos
                .Select(TP => new TipoProductoModel()
                    {
                        Id = TP.Id,
                        Nombre = TP.Nombre,
                        Descripcion = TP.Descripcion
                    })
                .ToList();

            return View(list);
        }

        public IActionResult TipoProductoEdit(Guid Id)
        {
            TipoProducto entity = _context.TiposProductos
                .FirstOrDefault(Tp => Tp.Id == Id);

            if (entity == null)
            {
                return NotFound();
            }

            TipoProductoModel modelo = new TipoProductoModel();
            modelo.Nombre = entity.Nombre;
            modelo.Descripcion = entity.Descripcion;

            return View(modelo);
        }

        [HttpPost]  
        public IActionResult TipoProductoEdit(TipoProductoModel modelo)
        {
            TipoProducto entity = new TipoProducto();
            entity = _context.TiposProductos
                .FirstOrDefault(Tp => Tp.Id == modelo.Id);

            if (entity == null)
            {
                return NotFound();
            }
            
            entity.Nombre = modelo.Nombre;
            entity.Descripcion = modelo.Descripcion;

            _context.TiposProductos.Update(entity);
            _context.SaveChanges();

            return RedirectToAction("TipoProductoList", "TipoProducto");
        }

        public IActionResult TipoProductoDelete(Guid Id)
        {
            TipoProducto entity = _context.TiposProductos
                .FirstOrDefault(Tp => Tp.Id == Id);

            if (entity == null)
            {
                return NotFound();
            }

            TipoProductoModel modelo = new TipoProductoModel();
            modelo.Nombre = entity.Nombre;
            modelo.Descripcion = entity.Descripcion;

            return View(modelo);
        }

        
        [HttpPost]  
        public IActionResult TipoProductoDelete(TipoProductoModel modelo)
        {
            TipoProducto entity = new TipoProducto();
            entity = _context.TiposProductos
                .FirstOrDefault(Tp => Tp.Id == modelo.Id);

            if (entity == null)
            {
                return NotFound();
            }

            _context.TiposProductos.Remove(entity);
            _context.SaveChanges();

            return RedirectToAction("TipoProductoList", "TipoProducto");
        }

    }
}