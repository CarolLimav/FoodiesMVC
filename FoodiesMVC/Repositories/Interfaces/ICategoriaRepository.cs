using FoodiesMVC.Models;

namespace FoodiesMVC.Repositories.Interfaces
{
    public interface ICategoriaRepository //interface 
    {
        IEnumerable<Categoria> Categorias { get; } 
    }
}
