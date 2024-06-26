using System.ComponentModel.DataAnnotations;

namespace ConexionEF.Entities
{
    public class TipoProducto
    {
        public TipoProducto()
        {
        }

        public Guid Id { get; set; }
        [StringLength(100)]
        [Required]
        public string Nombre { get; set; }
        [StringLength(250)]
        public string Descripcion { get; set; }
    }
}