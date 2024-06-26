namespace ConexionEF.Models
{
    public class TipoProductoModel
    {
        public TipoProductoModel()
        {
        }
        
        public Guid Id { get; set; }

        public string Nombre { get; set; }

        public string Descripcion { get; set; }
    }
}