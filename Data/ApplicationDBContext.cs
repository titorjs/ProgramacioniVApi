using Microsoft.EntityFrameworkCore;
using ProgramacionIV.Models;

namespace ProgramacionIVAPI
{
	public class ApplicationDBContext:DbContext
	{
		public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options ) 
			: base( options ) { }

		public DbSet<Producto> Producto { get; set; }

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			modelBuilder.Entity<Producto>().HasData(
				new Producto
				{
					IdProducto = 1,
					Nombre = "P1",
					Descripcion = "D1",
					Cantidad = 23,
				},
				new Producto
				{
					IdProducto = 2,
					Nombre = "P2",
					Descripcion = "D2",
					Cantidad = 12,
				},
				new Producto
				{
					IdProducto = 4,
					Nombre = "P3",
					Descripcion = "D3",
					Cantidad = 76,
				}
				);;
		}
	}
}
