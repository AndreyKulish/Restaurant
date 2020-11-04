using System;
using Restaurant.dao;

namespace Restaurant.controllers
{
    public class DishController: AbstractCrudDao
    {
        public DishController()
        {
            
        }
        
        public override void Create()
        {
            Console.WriteLine("Блюдо создать");
        }

        public override void Read()
        {
            Console.WriteLine("Блюдо которые есть");
            Menu menu = Menu.getInstance();

            foreach (Dish dish in menu.Dish)
            {
                Console.WriteLine("Блюдо: " + dish.Name);
            }
        }

        public override void Update()
        {
            Console.WriteLine("Блюдо обновить");
        }

        public override void Delete()
        {
            Console.WriteLine("Блюдо удалить");
        }
    }
}