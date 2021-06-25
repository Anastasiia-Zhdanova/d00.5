using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace d00._5
{
    public static class CustomerExtensions
    {
        public static CashRegister ChoosenCashRegisterMinimumCustumers(this Customer customer, List<CashRegister> listOfCashRegisters)
        {
           return listOfCashRegisters.OrderBy(cashRegister => cashRegister.CustomersQueue.Count).First();
        }
    
        public static CashRegister ChoosenCashRegisterMinimumProducts(this Customer customer, List<CashRegister> listOfCashRegisters)
        {
            return listOfCashRegisters.OrderBy(cashRegister =>
            {
                return cashRegister.CustomersQueue.Select(customerFromQueue => customerFromQueue.CountOfProductsInBasket)
                    .Sum();
            }).First();
        }
    }
}