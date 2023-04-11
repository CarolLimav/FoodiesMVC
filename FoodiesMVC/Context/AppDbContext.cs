using FoodiesMVC.Models;
using Microsoft.EntityFrameworkCore;

namespace FoodiesMVC.Context
{
    public class AppDbContext : DbContext //a classe DbContext serve para fazer a interação com o banco de dados
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
        public DbSet<Categoria> Categorias { get; set; }//coleções que irei trabalhar 
        public DbSet<Lanche> Lanches { get; set; }
    }
}
