using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProgramacionIV.Models
{
    public class Producto
    {
        [Key]
		[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		public int IdProducto { get; set; }
        [Required]
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        [Required]
        public int Cantidad { get; set; }
    }
}
