using System;

namespace Restaurant.controllers
{
    public class StoryController: AbstractCrudDao
    {
        public override void Create()
        {
            Console.WriteLine("Склад создать");
        }

        public override void Read()
        {
            Console.WriteLine("Склад смотреть");
        }

        public override void Update()
        {
            Console.WriteLine("Склад обновить");
        }

        public override void Delete()
        {
            Console.WriteLine("Склад удалить");
        }
    }
}