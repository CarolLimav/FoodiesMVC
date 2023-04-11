using FoodiesMVC.Models;

namespace FoodiesMVC.Repositories.Interfaces
{
    public interface ILancheRepository
    {
        IEnumerable<Lanche> Lanches { get;} //IEnumerable é tipo uma lista 

        IEnumerable <Lanche> LanchesFavoritos { get;}
        Lanche GetLancheById(int id);//metodo

    }
}
