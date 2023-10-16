using Microsoft.EntityFrameworkCore;
using ProgramacionIV.Models;

namespace ProgramacionIVAPI
{
	public class ApplicationDBContext:DbContext
	{
		public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options ) 
			: base( options ) { }

		public DbSet<Producto> Producto { get; set; }
	}
}
