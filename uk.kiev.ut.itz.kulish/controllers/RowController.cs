using System;
using Restaurant.db;

namespace Restaurant.controllers
{

    public class RowController
    {

        public void rowProcessor()
        {
            showHelloInfo();
            
            string line = "";
            
            while (!line.Equals("/stop"))
            {
               line = Console.ReadLine();

               lineProcessor(line);
               modeProcessor();
              
            }
        }

        private void lineProcessor(string line)
        {
            if (line.StartsWith("/"))
            {
                actionProcessor(line);
            }
            else
            {
                choiceProcessing(line);
            }
        }

        private void modeProcessor()
        {
            AbstractCrudDao abstractCrudDao = null;
            switch (AppState.selectedDao)
            {
                case AppState.SelectedDao.CLIENT:
                    abstractCrudDao = new ClientController();
                    break;
                case AppState.SelectedDao.PRODUCT:
                    abstractCrudDao = new ProductController();
                    break;
                case AppState.SelectedDao.DISH:
                    abstractCrudDao = new DishController();
                    break;
                case AppState.SelectedDao.WORKER:
                    abstractCrudDao = new WorkerController();
                    break;
                case AppState.SelectedDao.STORY:
                    abstractCrudDao = new StoryController();
                    break;
                case AppState.SelectedDao.MENU:
                    abstractCrudDao = new MenuController();
                    break;
                case AppState.SelectedDao.RESTAURANT:
                    abstractCrudDao = new RestaurantController();
                    break;
                case AppState.SelectedDao.DEFAULT:
                    break;
            }

            abstractCrudDao?.crudSelector();
        }
        
        private void actionProcessor(string text)
        {
            switch (text)
            {
                case "/start" :
                    doStart();
                    break;
                case "/save" :
                    doSave();
                    break;
                case "/info" :
                    doInfo();
                    break;
                case "/help" :
                    doHelp();
                    break;
                case "/refrash" :
                    doRefrash();
                    break;
            }
        }

        private void doStart()
        {
            PullController.pullData();
            if (dao.Restaurant.getInstance().Address == null)
            {
                AppState.crudMode = AppState.CrudMode.CREATE;
                AppState.selectedDao = AppState.SelectedDao.RESTAURANT;
            }
            else
            {
                
                Console.WriteLine("Привет в твоем ресторане: " + dao.Restaurant.getInstance().Name);
                Console.WriteLine("С чем будем работать?");
                Console.WriteLine("1 - Клиенты");      // AppState.SelectedDao.CLIENT
                Console.WriteLine("2 - Продукты");     // AppState.SelectedDao.PRODUCT
                Console.WriteLine("3 - Блюда");        // AppState.SelectedDao.DISH
                Console.WriteLine("4 - Работники");    // AppState.SelectedDao.WORKER
                Console.WriteLine("5 - Склад");        // AppState.SelectedDao.STORY
                Console.WriteLine("6 - Меню");         // AppState.SelectedDao.MENU
                Console.WriteLine("7 - Ресторан");     // AppState.SelectedDao.RESTAURANT
            }
        }

        private void choiceProcessing(string line)
        {
            // Мы в главном меню
            if (AppState.crudMode == AppState.CrudMode.DEFAULT && AppState.selectedDao == AppState.SelectedDao.DEFAULT)
            {
                switch (line)
                {
                    case "1":
                        AppState.selectedDao = AppState.SelectedDao.CLIENT;
                        break;
                    case "2":
                        AppState.selectedDao = AppState.SelectedDao.PRODUCT;
                        break;
                    case "3":
                        AppState.selectedDao = AppState.SelectedDao.DISH;
                        break;
                    case "4":
                        AppState.selectedDao = AppState.SelectedDao.WORKER;
                        break;
                    case "5":
                        AppState.selectedDao = AppState.SelectedDao.STORY;
                        break;
                    case "6":
                        AppState.selectedDao = AppState.SelectedDao.MENU;
                        break;
                    case "7":
                        AppState.selectedDao = AppState.SelectedDao.RESTAURANT;
                        break;
                } 
                
            }
            else if (AppState.crudMode == AppState.CrudMode.DEFAULT 
                     && AppState.selectedDao != AppState.SelectedDao.DEFAULT)
            {
                switch (line)
                {
                    case "1":
                        AppState.crudMode = AppState.CrudMode.CREATE;
                        break;
                    case "2":
                        AppState.crudMode = AppState.CrudMode.READ;
                        break;
                    case "3":
                        AppState.crudMode = AppState.CrudMode.UPDATE;
                        break;
                    case "4":
                        AppState.crudMode = AppState.CrudMode.DELETE;
                        break;
                }
            }
        }

        private void doSave()
        {
            PushController.pushData();
        }

        private void doInfo()
        {
            
        }

        private void doHelp()
        {
            showHelloInfo();
        }

        private void doRefrash()
        {
            
        }

        private void showHelloInfo()
        {
            Console.WriteLine("Йо Браток, ты в псевдо ресторанчике");
            Console.WriteLine("Ты можешь:");
            Console.WriteLine(" - Создать свой ресторан");
            Console.WriteLine(" - Закупить продкуты");
            Console.WriteLine(" - Создать блюда");
            Console.WriteLine(" - Нанимать рабочих");
            Console.WriteLine(" - Увольнять рабочих");
            Console.WriteLine();
            Console.WriteLine("Краткая справочная:");
            Console.WriteLine(" /start - начать с последней точки схранения");
            Console.WriteLine(" /save - сохранить прогресс");
            Console.WriteLine(" /info - вывод полезной инфы по разделу");
            Console.WriteLine(" /help - вывод этого меню повторно");
            Console.WriteLine(" /refrash - удалить все данные и начать по новой");
            Console.WriteLine("Удачи Браток!");
        }
    }
}