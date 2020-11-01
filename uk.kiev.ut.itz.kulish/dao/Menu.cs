using System.Collections.Generic;

namespace Restaurant.dao
{
    public class Menu
    {
        private List<Dish> _dish;

        public List<Dish> Dish
        {
            get => _dish;
            set => _dish = value;
        }
    }
}