using System;

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
               if (line.StartsWith("/"))
               {
                   actionProcessor(line);
               }
            }
            
            
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
            
        }

        private void doSave()
        {
            
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