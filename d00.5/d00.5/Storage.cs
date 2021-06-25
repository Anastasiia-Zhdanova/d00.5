using System;

namespace d00._5
{
    public class Storage
    {
        private int _product;

        public int Product
        {
            get => _product;
            set => _product = value;
        }

        public Storage(int countProducts)
        {
            _product = countProducts;
        }

        public bool IsEmpty() => _product <= 0;
    }
}