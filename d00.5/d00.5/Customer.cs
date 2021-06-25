using System;

namespace d00._5
{
    public class Customer
    {
        private int _number;
        private string _name;
        private int _countOfProductsInBasket;

        public int Number
        {
            get => _number;
            protected set => _number = value;
        }

        public string Name
        {
            get => _name;
            protected set => _name = value;
        }

        public int CountOfProductsInBasket
        {
            get => _countOfProductsInBasket;
            protected set => _countOfProductsInBasket = value;
        }

        public Customer(string name, int number)
        {
            this._number = number;
            this._name = name;
            this._countOfProductsInBasket = 0;
        }

        public override string ToString()
        {
            return $"name: {_name}, number: {_number}";
        }

        protected bool Equals(Customer other)
        {
            return _number == other._number && _name == other._name;
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false; //если объект пришел null
            if (ReferenceEquals(this, obj)) return true; //если второй экземпляр класса равен текущему объекту (первому экземаляру класса) в плане ссылок (адрес памяти такой же)
            if (obj.GetType() != this.GetType()) return false; //если типы разные у customer2 и customer1
            return Equals((Customer) obj); //если можно сравнить, то возвращаем результат сравнения
        }

        public override int GetHashCode() //для map (мой объект - это ключ в map)
        {
            return HashCode.Combine(_number, _name);
        }
        
        public static bool operator ==(Customer customer1, Customer customer2)
        {
            if (ReferenceEquals(null, customer2) || ReferenceEquals(null, customer1)) return false;
            if (ReferenceEquals(customer1, customer2)) return true;
            return customer1.Equals(customer2);
        }

        public static bool operator !=(Customer customer1, Customer customer2)
        {
            return !(customer1 == customer2);
        }

        public int FillCart(int maxCart)
        { 
            Random random = new Random();
            return _countOfProductsInBasket = random.Next(1, maxCart);
        }
    }
}