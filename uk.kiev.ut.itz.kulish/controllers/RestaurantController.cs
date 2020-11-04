using System;

namespace Restaurant.controllers
{
    public class RestaurantController: AbstractCrudDao
    {
        public override void Create()
        {
            Console.WriteLine("Ресторан создать");
        }

        public override void Read()
        {
            Console.WriteLine("Ресторан смотреть");
        }

        public override void Update()
        {
            Console.WriteLine("Ресторан обновить");
        }

        public override void Delete()
        {
            Console.WriteLine("Ресторан удалить");
        }
    }
}