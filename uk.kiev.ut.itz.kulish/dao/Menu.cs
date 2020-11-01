using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Restaurant.dao
{
    [Serializable]
    public class Menu
    {
        private List<Dish> _dish;
        private static Menu INSTANCE;

        private Menu()
        {
        }

        public static Menu getInstance()
        {
            if (INSTANCE == null)
            {
                INSTANCE = new Menu();
            }
            return INSTANCE;
        }

        public List<Dish> Dish
        {
            get => _dish;
            set => _dish = value;
        }
        
    }
}