namespace GestionEmpleadosMVC.Models
{
    public class Producto
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public decimal Precio { get; set; }
        public string ImagenUrl { get; set; }
        // Nuevas propiedades para la vista de detalle
        public string Especificaciones { get; set; }
        public string Categoria { get; set; }
    }
}