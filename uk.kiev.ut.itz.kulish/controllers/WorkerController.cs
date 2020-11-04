using System;

namespace Restaurant.controllers
{
    public class WorkerController: AbstractCrudDao
    {

        public override void Create()
        {
            Console.WriteLine("Рабочий создать");
        }

        public override void Read()
        {
            Console.WriteLine("Рабочий смотреть");
        }

        public override void Update()
        {
            Console.WriteLine("Рабочий обновить");
        }

        public override void Delete()
        {
            Console.WriteLine("Рабочий удалить");
        }
    }
}