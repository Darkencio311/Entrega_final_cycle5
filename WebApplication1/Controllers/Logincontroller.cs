using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc;

public class LoginController : Controller
{
    // Permite acceder a la vista de Login con una solicitud GET
    [HttpGet]
    public IActionResult Index()
    {
        return View();
    }

    // Maneja el envío del formulario con una solicitud POST
    [HttpPost]
    public IActionResult Index(string NombreUsuario, string Contrasena)
    {
        if (NombreUsuario == "admin" && Contrasena == "1234")
        {
            return RedirectToAction("Index", "Producto");
        }

        ViewBag.Error = "Usuario o contraseña incorrectos";
        return View();
    }
}