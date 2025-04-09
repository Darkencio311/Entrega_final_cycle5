using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;
using Microsoft.AspNetCore.Http.Extensions;
using Microsoft.AspNetCore.Http.Features;
using Microsoft.AspNetCore.Session;

public class AuthController : Controller
{
    private readonly ApplicationDbContext _context;

    public AuthController(ApplicationDbContext context)
    {
        _context = context;
    }

    [HttpPost]
    public IActionResult Login(string nombreUsuario, string contraseña)
    {
        var usuario = _context.Usuarios.FirstOrDefault(u => u.NombreUsuario == nombreUsuario && u.Contraseña == contraseña);
        if (usuario != null)
        {
            HttpContext.Session.SetString("usuario", usuario.NombreUsuario);
            return RedirectToAction("Index", "Producto");
        }

        ViewBag.Error = "Usuario o contraseña incorrecta.";
        return View();
    }
}