using Microsoft.EntityFrameworkCore;

using WebApplication1.Models;
using TuProyecto.Models;

namespace WebApplication1.Models; 

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
    {
    }

    public DbSet<Usuario> Usuarios { get; set; }
    public DbSet<Producto> Productos { get; set; }
    public DbSet<Reseña> Reseñas { get; set; } 
}   