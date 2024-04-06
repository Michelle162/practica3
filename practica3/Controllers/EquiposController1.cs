using practica3.Models;
using Microsoft.AspNetCore.Server;  
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace practica3.Controllers
{
    public class EquiposController1 : Controller
    {
        private readonly equiposDbContext _equiposDbContext;

        public EquiposController1(equiposDbContext equiposDbContext)
        {
            _equiposDbContext = equiposDbContext;
        }

        public IActionResult Index()
        {
            var ListaDeMarcas = (from m in _equiposDbContext.marcas select m).ToList();
            ViewData["listadoDeMarcas"] = new SelectList(ListaDeMarcas, "id_marcas", "nombre_marcas");

            var listadoDeEquipos = (from e in _equiposDbContext.equipos
                                    join m in _equiposDbContext.marcas on
                                    e.marca_id equals m.id_marcas
                                    select new
                                    {
                                        nombre = e.marca_id,
                                        descripcion = e.descripcion,
                                        marca = e.marca_id,
                                        nombre_marca = m.nombre_marca
                                    });



            return View();
        }
    }
}
