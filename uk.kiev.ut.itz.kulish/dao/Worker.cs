namespace Restaurant.dao
{
    public class Worker
    {
        private string _name;
        private string _position;
        private int _age;
        private string _homeAddress;
        private int _salary;

        public string Name
        {
            get => _name;
            set => _name = value;
        }

        public string Position
        {
            get => _position;
            set => _position = value;
        }

        public int Age
        {
            get => _age;
            set => _age = value;
        }

        public string HomeAddress
        {
            get => _homeAddress;
            set => _homeAddress = value;
        }

        public int Salary
        {
            get => _salary;
            set => _salary = value;
        }
    }
}