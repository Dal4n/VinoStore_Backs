using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using VinoStore.Models;

namespace VinoStore.Controller
{

    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        /* VARIABLE DE CONTEXTO */
        private readonly BDProductsContext _bdTareas;

        public ProductsController(BDProductsContext bdTareas)
        {
            _bdTareas = bdTareas;
        }

        /* METODO API QUE OBTIENE TODOS LOS REGISTROS */
        [HttpGet]
        [Route("categoria")]
        public async Task<IActionResult> Categoria()
        {
            var listaTareas = await _bdTareas.Categorias.ToListAsync();
            return Ok(listaTareas);
        }


        /* METODO API QUE OBTIENE TODOS LOS REGISTROS */
        [HttpGet]
        [Route("listar")]
        public async Task<IActionResult> Lista()
        {
            var listaTareas = await _bdTareas.Productos.Include(p => p.Categoria).ToListAsync();
            return Ok(listaTareas);
        }
        

    }

}
