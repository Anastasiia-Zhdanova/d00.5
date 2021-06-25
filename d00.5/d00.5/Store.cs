using System.Collections.Generic;

namespace d00._5
{
    public class Store
    {
        private Storage _storage;
        private List<CashRegister> _listOfCashRegisters;

        public Storage Storage
        {
            get => _storage;
            protected set => _storage = value;
        }

        public List<CashRegister> ListOfCashRegisters
        {
            get => _listOfCashRegisters;
            protected set => _listOfCashRegisters = value;
        }

        public Store(int maxCapacityOfStorage, int maxCountOfCashRegisters)
        {
            _storage = new Storage(maxCapacityOfStorage);
            _listOfCashRegisters = new List<CashRegister>(maxCountOfCashRegisters);
            for (var i = 1; i <= maxCountOfCashRegisters; i++)
            {
                _listOfCashRegisters.Add(new CashRegister($"{i}"));
            }
        }

        public bool IsOpen() => !_storage.IsEmpty();
    }
}