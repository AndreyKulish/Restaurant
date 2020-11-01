using System;
using System.IO;
using System.Xml.Serialization;
using Restaurant.dao;

namespace Restaurant.db
{
    public class PushController
    {
        public void pushData()
        {
            Menu menu = Menu.getInstance();
            Story story = Story.getInstance();
            dao.Restaurant restaurant = dao.Restaurant.getInstance();
            
            XmlSerializer formatter = new XmlSerializer(typeof(Story));
           
            using (FileStream fs = new FileStream("story.xml", FileMode.OpenOrCreate))
            {
                formatter.Serialize(fs, story);
 
                Console.WriteLine("Склад сериализован");
            }
            
            formatter = new XmlSerializer(typeof(Menu));
            using (FileStream fs = new FileStream("menu.xml", FileMode.OpenOrCreate))
            {
                formatter.Serialize(fs, menu);
 
                Console.WriteLine("Меню сериализованно");
            }
            
            formatter = new XmlSerializer(typeof(dao.Restaurant));
            using (FileStream fs = new FileStream("restaurant.xml", FileMode.OpenOrCreate))
            {
                formatter.Serialize(fs, restaurant);
 
                Console.WriteLine("Ресторан сериализован");
            }
        }
    }
}