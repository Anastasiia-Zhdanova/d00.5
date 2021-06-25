using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace d00._5
{
    public class CashRegister
    {
        private string _nameOfCashRegister;

        public string NameOfCashRegister
        {
            get => _nameOfCashRegister;
            protected set => _nameOfCashRegister = value;
        }

        public CashRegister(string nameOfCashRegister)
        {
            _nameOfCashRegister = nameOfCashRegister;
        }

        public override string ToString()
        {
            return $"Name of Cash Register: {_nameOfCashRegister}";
        }

        private bool Equals(CashRegister other)
        {
            return _nameOfCashRegister == other._nameOfCashRegister;
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != this.GetType()) return false;
            return Equals((CashRegister) obj);
        }

        public override int GetHashCode()
        {
            return (_nameOfCashRegister != null ? _nameOfCashRegister.GetHashCode() : 0);
        }

        public static bool operator ==(CashRegister cashRegister1, CashRegister cashRegister2)
        {
            if (ReferenceEquals(null, cashRegister2) || ReferenceEquals(null, cashRegister1)) return false;
            if (ReferenceEquals(cashRegister1, cashRegister2)) return true;
            return cashRegister1.Equals(cashRegister2);
        }

        public static bool operator !=(CashRegister cashRegister1, CashRegister cashRegister2)
        {
            return !(cashRegister1 == cashRegister2);
        }


        Queue<Customer> _customersQueue = new Queue<Customer>();

        public Queue<Customer> CustomersQueue
        {
            get => _customersQueue;
            protected set => _customersQueue = value;
        }
    }
}