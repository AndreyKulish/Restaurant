using System.Collections.Generic;

namespace Restaurant.dao
{
    public class Restaurant
    {
        private string _address;
        private List<Worker> _workers;
        private string _description;

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
    }
}