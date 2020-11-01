﻿using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Restaurant.dao
{
    [Serializable] 
    public class Restaurant
    {
        private string _address;
        private List<Worker> _workers;
        private List<Client> _сlients;
        private string _description;
        private static Restaurant INSTANCE;

        private Restaurant()
        {
        }

        public static Restaurant getInstance()
        {
            if (INSTANCE == null)
            {
                INSTANCE = new Restaurant();
            }
            return INSTANCE;
        }
        
        public string Address
        {
            get => _address;
            set => _address = value;
        }

        public List<Worker> Workers
        {
            get => _workers;
            set => _workers = value;
        }

        public string Description
        {
            get => _description;
            set => _description = value;
        }

        public List<Client> Сlients
        {
            get => _сlients;
            set => _сlients = value;
        }

    }
}