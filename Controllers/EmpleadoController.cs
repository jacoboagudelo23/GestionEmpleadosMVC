using Microsoft.AspNetCore.Mvc;
using GestionEmpleadosMVC.Models;

namespace GestionEmpleadosMVC.Controllers
{
    public class EmpleadoController : Controller
    {
        // Lista simulada de empleados

        private List<Empleado> empleados = new List<Empleado>()
        {
            new Empleado()
            {
                Id = 1,
                Nombre = "Carlos Gómez",
                Cargo = "Desarrollador Backend",
                FechaIngreso = new DateTime(2020, 5, 10),
                Activo = true
            },

            new Empleado()
            {
                Id = 2,
                Nombre = "Laura Martínez",
                Cargo = "Diseñadora UX/UI",
                FechaIngreso = new DateTime(2021, 3, 15),
                Activo = true
            },

            new Empleado()
            {
                Id = 3,
                Nombre = "Andrés Ramírez",
                Cargo = "Administrador BD",
                FechaIngreso = new DateTime(2019, 8, 20),
                Activo = false
            }
        };

        // Vista principal

        public IActionResult Index()
        {
            return View(empleados);
        }
    }
}