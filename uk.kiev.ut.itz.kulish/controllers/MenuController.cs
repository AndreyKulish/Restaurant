﻿using System;

namespace Restaurant.controllers
{
    public class MenuController: AbstractCrudDao
    {
        public override void Create()
        {
            Console.WriteLine("Меню создать");
        }

        public override void Read()
        {
            Console.WriteLine("Меню смотреть");
        }

        public override void Update()
        {
            Console.WriteLine("Меню обновить");
        }

        public override void Delete()
        {
            Console.WriteLine("Меню удалить");
        }
    }
}