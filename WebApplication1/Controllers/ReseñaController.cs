using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;
using TuProyecto.Models;


namespace TuProyecto.Controllers
{
    public class ReseñaController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(Reseña model)
        {
            if (ModelState.IsValid)
            {
                ViewBag.Mensaje = "¡Gracias por tu reseña!";
            }

            return View(model);
        }
    }
}