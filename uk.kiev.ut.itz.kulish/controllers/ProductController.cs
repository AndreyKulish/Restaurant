using System;

namespace Restaurant.controllers
{
    public class ProductController: AbstractCrudDao
    {
        public override void Create()
        {
            Console.WriteLine("Продукты создать");
        }

        public override void Read()
        {
            Console.WriteLine("Продукты смотреть");
        }

        public override void Update()
        {
            Console.WriteLine("Продукты обновить");
        }

        public override void Delete()
        {
            Console.WriteLine("Продукты удалить");
        }
    }
}