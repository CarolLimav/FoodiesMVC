﻿using FoodiesMVC.Models;

namespace FoodiesMVC.ViewModel
{
    public class LancheListViewModel
    {
        public IEnumerable<Lanche> Lanches { get; set; }
        public string Categoria { get; set; }
    }
}
