using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Restaurant.dao
{
    [Serializable] 
    public class Story
    {
        private List<Product> _products;
        private static Story INSTANCE;
        
        private Story()
        {
        }

        /*
         * Привет костылям))
         */
        public static void setInstance(Story story)
        {
            INSTANCE = story;
        }
        
        public static Story getInstance()
        {
            if (INSTANCE == null)
            {
                INSTANCE = new Story();
            }
            return INSTANCE;
        }
        
        public List<Product> Products
        {
            get => _products;
            set => _products = value;
        }
    }
}