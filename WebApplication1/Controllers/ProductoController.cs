using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models; 
using Microsoft.EntityFrameworkCore;

public class ProductoController : Controller
{
    private readonly ApplicationDbContext _context;

    public ProductoController(ApplicationDbContext context)
    {
        _context = context;
    }

    public IActionResult Index()
    {
        var productos = _context.Productos.ToList();
        return View(productos);
    }
}