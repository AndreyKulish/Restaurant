using System.Collections.Generic;

namespace Restaurant.dao
{
    public class Client
    {
        private string _name;
        private int _tablePosition;
        private int _money;
        private List<Dish> _orderDishes;

        public string Name
        {
            get => _name;
            set => _name = value;
        }

        public int TablePosition
        {
            get => _tablePosition;
            set => _tablePosition = value;
        }

        public int Money
        {
            get => _money;
            set => _money = value;
        }

        public List<Dish> OrderDishes
        {
            get => _orderDishes;
            set => _orderDishes = value;
        }
    }
}