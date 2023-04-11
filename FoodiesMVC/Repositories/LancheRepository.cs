using FoodiesMVC.Context;
using FoodiesMVC.Models;
using FoodiesMVC.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace FoodiesMVC.Repositories
{
    public class LancheRepository : ILancheRepository
    {
        private readonly AppDbContext _context;

        public LancheRepository(AppDbContext context)
        {
            this._context = context;
        }

        public IEnumerable<Lanche> Lanches => _context.Lanches;


        public IEnumerable<Lanche> LanchesFavoritos => _context.Lanches
            .Where(lanche => lanche.IsFavorite)
            .Include(c => c.Categoria);

        public Lanche GetLancheById(int id)
        {
            var lanche = _context.Lanches.FirstOrDefault(l => l.Id == id);

            //é o mesmo que isso:
            //foreach(var lanche in _context.Lanches)
            //{
            //    if(lanche.Id == id)
            //    {
            //        return lanche;
            //    }
            //}
            return lanche;

        }
    }
}
