using System;

namespace Restaurant.controllers
{
    public class ClientController: AbstractCrudDao
    {
        public override void Create()
        {
            Console.WriteLine("Клиент создать");
        }

        public override void Read()
        {
            Console.WriteLine("Клиент смотреть");
        }

        public override void Update()
        {
            Console.WriteLine("Клиент обновить");
        }

        public override void Delete()
        {
            Console.WriteLine("Клиент удалить");
        }
    }
}