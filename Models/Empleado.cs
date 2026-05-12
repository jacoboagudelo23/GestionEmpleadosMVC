namespace GestionEmpleadosMVC.Models
{
    public class Empleado
    {
        public int Id { get; set; }

        public string Nombre { get; set; }

        public string Cargo { get; set; }

        public DateTime FechaIngreso { get; set; }

        public bool Activo { get; set; }

        public int Antiguedad
        {
            get
            {
                return DateTime.Now.Year - FechaIngreso.Year;
            }
        }
    }
}