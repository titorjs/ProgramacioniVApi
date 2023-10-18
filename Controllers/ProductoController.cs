using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ProgramacionIV.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ProgramacionIVAPI.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class ProductoController : ControllerBase
	{
		private readonly ApplicationDBContext _dbContext;

		public ProductoController(ApplicationDBContext dBContext)
		{
			_dbContext = dBContext;
		}

		// GET: api/<ProductoController>
		[HttpGet]
		public async Task<IActionResult> Get()
		{
			List <Producto> productos = await _dbContext.Producto.ToListAsync();
			return Ok(productos);
		}

		// GET api/<ProductoController>/5
		[HttpGet("{idProducto}")]
		public async Task<IActionResult> Get(int idProducto)
		{
			Producto p = await _dbContext.Producto.FirstOrDefaultAsync(
				op => op.IdProducto == idProducto);

			if (p == null)
			{
				return BadRequest();
			}

			return Ok(p);
		}

		// POST api/<ProductoController>
		[HttpPost]
		public async Task<IActionResult> Post(Producto producto)
		{
			Producto p2 = await _dbContext.Producto.FirstOrDefaultAsync(x => x.IdProducto == producto.IdProducto);

			if (p2 == null && producto != null)
			{
				await _dbContext.AddAsync(producto);
				await _dbContext.SaveChangesAsync();
				return Ok(producto);
			}

			return BadRequest("Eres bobo mmvrg");
		}

		// PUT api/<ProductoController>/5
		[HttpPut("{IdProducto}")]
		public async Task<IActionResult> Put(int IdProducto, [FromBody] Producto p)
		{
			Producto p2 = await _dbContext.Producto.FirstOrDefaultAsync(x => x.IdProducto == IdProducto);

			if(p2 != null)
			{
				p2.Nombre = p.Nombre != null? p.Nombre:p2.Nombre;
				p2.Descripcion = p.Descripcion != null? p.Descripcion: p2.Descripcion;
				p2.Cantidad = p.Cantidad != null? p.Cantidad: p2.Cantidad;
				_dbContext.Producto.Update(p2);
				await _dbContext.SaveChangesAsync();
				return Ok(p2);
			}

			return BadRequest("Como voy a eliminar si no existe tu wevada");
		}

		// DELETE api/<ProductoController>/5
		[HttpDelete("{id}")]
		public async Task<IActionResult> Delete(int id)
		{
			Producto p = await _dbContext.Producto.FirstOrDefaultAsync(x => x.IdProducto == id);
			if (p != null)
			{
				_dbContext.Producto.Remove(p);
				await _dbContext.SaveChangesAsync();
				return Ok(p);
			}

			return BadRequest("No hay tu wevada");
		}
	}
}
