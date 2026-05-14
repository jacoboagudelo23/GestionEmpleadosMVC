using Microsoft.AspNetCore.Mvc;
using GestionEmpleadosMVC.Models;
using System.Collections.Generic;
using System.Linq;

namespace GestionEmpleadosMVC.Controllers
{
    public class ProductoController : Controller
    {
        // Lista estática con URLs de imágenes optimizadas para carga rápida
        private static List<Producto> ObtenerProductos()
        {
            return new List<Producto>()
            {
                new Producto {
                    Id = 1,
                    Nombre = "HP Pavilion 15",
                    Descripcion = "Intel i5, 16GB RAM, 512GB SSD. Potencia para tu día a día.",
                    Precio = 2500000,
                    ImagenUrl = "https://images.unsplash.com/photo-1496181133206-80ce9b88a853?w=400&q=80",
                    Especificaciones = "Procesador: Intel Core i5-1235U | RAM: 16GB DDR4 | Almacenamiento: 512GB SSD NVMe",
                    Categoria = "Trabajo y estudio"
                },
                new Producto {
                    Id = 2,
                    Nombre = "Lenovo IdeaPad Slim 5",
                    Descripcion = "Ryzen 7, 16GB RAM. Diseño ultra delgado y elegante.",
                    Precio = 2800000,
                    ImagenUrl = "https://images.unsplash.com/photo-1541807084-5c52b6b3adef?w=400&q=80",
                    Especificaciones = "Procesador: AMD Ryzen 7 7730U | RAM: 16GB DDR4 | Almacenamiento: 512GB SSD",
                    Categoria = "Productividad"
                },
                new Producto {
                    Id = 3,
                    Nombre = "MacBook Air M2",
                    Descripcion = "Chip M2 de Apple. La laptop más delgada y potente.",
                    Precio = 4500000,
                    ImagenUrl = "https://images.unsplash.com/photo-1542393545-10f5cde2c810?w=400&q=80",
                    Especificaciones = "Procesador: Apple M2 | RAM: 8GB Memoria Unificada | Pantalla: 13.6\" Liquid Retina",
                    Categoria = "Premium"
                },
                new Producto {
                    Id = 4,
                    Nombre = "ASUS VivoBook 15",
                    Descripcion = "Intel i3, 8GB RAM, 256GB SSD. La opción ideal para estudiantes.",
                    Precio = 1800000,
                    ImagenUrl =  "https://images.unsplash.com/photo-1588872657578-7efd1f1555ed?w=400&q=80",
                    Especificaciones = "Procesador: Intel Core i3-1215U | RAM: 8GB DDR4 | Almacenamiento: 256GB SSD",
                    Categoria = "Estudiantes"
                },
                new Producto {
                    Id = 5,
                    Nombre = "Dell XPS 13",
                    Descripcion = "Intel i7, 16GB RAM, diseño compacto de alta gama.",
                    Precio = 5200000,
                    ImagenUrl = "https://images.unsplash.com/photo-1593642632559-0c6d3fc62b89?w=400&q=80",
                    Especificaciones = "Procesador: Intel Core i7-1250U | RAM: 16GB LPDDR5 | Pantalla: 13.4\" FHD+",
                    Categoria = "Premium"
                },
                new Producto {
                    Id = 6,
                    Nombre = "Acer Aspire 5",
                    Descripcion = "AMD Ryzen 5, 8GB RAM. Equilibrio perfecto precio-rendimiento.",
                    Precio = 2100000,
                    ImagenUrl = "https://images.unsplash.com/photo-1525547719571-a2d4ac8945e2?w=400&q=80",
                    Especificaciones = "Procesador: AMD Ryzen 5 5500U | RAM: 8GB DDR4 | Almacenamiento: 512GB SSD",
                    Categoria = "Trabajo y estudio"
                }
            };
        }

        // GET: /Producto/Index
        public IActionResult Index(string? categoria)
        {
            var productos = ObtenerProductos();
            if (!string.IsNullOrEmpty(categoria))
                productos = productos.Where(p => p.Categoria == categoria).ToList();
            return View(productos);
        }

        // GET: /Producto/Detalle/{id}
        public IActionResult Detalle(int id)
        {
            var productos = ObtenerProductos();
            var producto = productos.FirstOrDefault(p => p.Id == id);

            if (producto == null)
            {
                return RedirectToAction("Index");
            }

            return View(producto);
        }

        // Acciones adicionales para botones del Footer y Detalle
        public IActionResult ConfirmacionPago()
        {
            return View();
        }

        public IActionResult Info(string tipo)
        {
            ViewBag.Tipo = tipo;
            return View();
        }
    }
}
