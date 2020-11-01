using System.Collections.Generic;

namespace Restaurant.dao
{
    public class Product
    {
        private string _name;
        private string _description;

        public string Name
        {
            get => _name;
            set => _name = value;
        }

        public string Description
        {
            get => _description;
            set => _description = value;
        }
    }
}