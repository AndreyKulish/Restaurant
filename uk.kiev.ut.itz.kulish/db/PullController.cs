using System;
using System.IO;
using System.Xml.Serialization;
using Restaurant.dao;

namespace Restaurant.db
{
    public class PullController
    {
        public static void pullData()
        {
            XmlSerializer formatter;
            try
            {
                formatter = new XmlSerializer(typeof(Menu));
                using (FileStream fs = new FileStream("menu.xml", FileMode.OpenOrCreate))
                {
                    Menu menu = (Menu) formatter.Deserialize(fs);
                    Menu.setInstance(menu);

                    Console.WriteLine("Меню десериализованно");
                }
            }
            catch (Exception e)
            {
                // Костыль (лень писать чекер на файл-exist)
                Console.WriteLine("Меню еще не создано");
            }

            try
            {
                formatter = new XmlSerializer(typeof(Story));
                using (FileStream fs = new FileStream("story.xml", FileMode.OpenOrCreate))
                {
                    Story story = (Story) formatter.Deserialize(fs);
                    Story.setInstance(story);

                    Console.WriteLine("Склад десериализован");
                }
            }
            catch (Exception e)
            {
                // Костыль (лень писать чекер на файл-exist)
                Console.WriteLine("Склад еще не создан");
            }

            try
            {
                formatter = new XmlSerializer(typeof(dao.Restaurant));
                using (FileStream fs = new FileStream("restaurant.xml", FileMode.OpenOrCreate))
                {
                    dao.Restaurant restaurant = (dao.Restaurant) formatter.Deserialize(fs);
                    dao.Restaurant.setInstance(restaurant);
                
                    Console.WriteLine("Ресторан десериализован");
                }
            }
            catch (Exception e)
            {
                // Костыль (лень писать чекер на файл-exist)
                Console.WriteLine("Ресторан еще не создан");
            }
        }
    }
}