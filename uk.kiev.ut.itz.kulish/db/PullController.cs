using System;
using System.IO;
using System.Xml.Serialization;
using Restaurant.dao;

namespace Restaurant.db
{
    public class PullController
    {
        public void pullData()
        {
            XmlSerializer formatter = new XmlSerializer(typeof(Menu));
            using (FileStream fs = new FileStream("menu.xml", FileMode.OpenOrCreate))
            {
                Menu menu = (Menu) formatter.Deserialize(fs);
 
                Console.WriteLine("Меню десериализованно");
            }
            
            formatter = new XmlSerializer(typeof(Story));
            using (FileStream fs = new FileStream("story.xml", FileMode.OpenOrCreate))
            {
                Story story = (Story) formatter.Deserialize(fs);
 
                Console.WriteLine("Склад десериализован");
            }
            
            formatter = new XmlSerializer(typeof(dao.Restaurant));
            using (FileStream fs = new FileStream("restaurant.xml", FileMode.OpenOrCreate))
            {
                dao.Restaurant restaurant = (dao.Restaurant) formatter.Deserialize(fs);
 
                Console.WriteLine("Ресторан десериализован");
            }
        }
    }
}