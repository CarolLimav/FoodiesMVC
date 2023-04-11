using FoodiesMVC.Context;
using FoodiesMVC.Models;
using FoodiesMVC.Repositories.Interfaces;

namespace FoodiesMVC.Repositories
{
    public class CategoriaRepository : ICategoriaRepository //classe que controla o que ireos fazer no banco de dados 
    {
        private readonly AppDbContext _context; //instancia do banco de dados 

        public CategoriaRepository(AppDbContext context) //construtor 
        {
            this._context = context;    
        }
        public IEnumerable<Categoria> Categorias => _context.Categorias; //pegando o contexto 


    }
}
