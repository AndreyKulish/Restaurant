﻿using System.Collections.Generic;

namespace Restaurant.dao
{
    public class Dish
    {
        private List<Product> _products;
        private int _price;
        private int _timeCooking;

        public List<Product> Products
        {
            get => _products;
            set => _products = value;
        }

        public int Price
        {
            get => _price;
            set => _price = value;
        }

        public int TimeCooking
        {
            get => _timeCooking;
            set => _timeCooking = value;
        }
    }
}