using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using d00._5;

var store = new Store(40,3); //for first algorithm
var store2 = new Store(40,3); //for second algorithm

Queue<Customer> listCustomers = new Queue<Customer>();
listCustomers.Enqueue(new Customer("Ana", 1));
listCustomers.Enqueue(new Customer("Artem", 2));
listCustomers.Enqueue(new Customer("Igor", 3));
listCustomers.Enqueue(new Customer("Arina", 4));
listCustomers.Enqueue(new Customer("Avgust", 5));
listCustomers.Enqueue(new Customer("Marina", 6));
listCustomers.Enqueue(new Customer("Veronika", 7));
listCustomers.Enqueue(new Customer("Tatiana", 8));
listCustomers.Enqueue(new Customer("Yana", 9));
listCustomers.Enqueue(new Customer("Pavel", 10));

Queue<Customer> listCustomers2 = new Queue<Customer>(listCustomers);
//first algorithm
while (store.IsOpen() && listCustomers.Count != 0)
{
    var itemListCustomer = listCustomers.Dequeue();
    var countProductsInCart = itemListCustomer.FillCart(7);
    store.Storage.Product -= countProductsInCart;
    var cashRegisterForCustomer = itemListCustomer.ChoosenCashRegisterMinimumCustumers(store.ListOfCashRegisters);
    cashRegisterForCustomer.CustomersQueue.Enqueue(itemListCustomer);
    Console.WriteLine($"{itemListCustomer},  count of products = {itemListCustomer.CountOfProductsInBasket}, " +
                      $"{cashRegisterForCustomer}, count of people in queue = {cashRegisterForCustomer.CustomersQueue.Count}, " +
                      $"count products in baskets = {cashRegisterForCustomer.CustomersQueue.Select(customerFromQueue => customerFromQueue.CountOfProductsInBasket).Sum()}");
}

Console.WriteLine("");
//second algorithm
while (store2.IsOpen() && listCustomers2.Count != 0)
{
    var itemListCustomer = listCustomers2.Dequeue();
    var countProductsInCart = itemListCustomer.CountOfProductsInBasket;
    store2.Storage.Product -= countProductsInCart;
    var cashRegisterForCustomer = itemListCustomer.ChoosenCashRegisterMinimumProducts(store2.ListOfCashRegisters);
    cashRegisterForCustomer.CustomersQueue.Enqueue(itemListCustomer);
    Console.WriteLine($"{itemListCustomer},  count of products = {itemListCustomer.CountOfProductsInBasket}, " +
                      $"{cashRegisterForCustomer}, count of people in queue = {cashRegisterForCustomer.CustomersQueue.Count}, " +
                      $"count products in baskets = {cashRegisterForCustomer.CustomersQueue.Select(customerFromQueue => customerFromQueue.CountOfProductsInBasket).Sum()}");
}



/*
//task 01
var customer1 = new Customer("Andrew", 1);
var customer2 = new Customer("Andrew", 1);

Console.WriteLine(customer1);
Console.WriteLine(customer2);

Console.WriteLine(customer1 == customer2);


//task 02 - FillCart 
var customer3 = new Customer("Ana", 2);
var customer4 = new Customer("Artem", 3);
var customer5 = new Customer("Igor", 4);
customer3.FillCart(15);
customer4.FillCart(15);
customer5.FillCart(15);
Console.WriteLine($"\n{customer3}, count of products = {customer3.CountOfProductsInBasket}");
Console.WriteLine($"{customer4},  count of products = {customer4.CountOfProductsInBasket}");
Console.WriteLine($"{customer5},  count of products = {customer5.CountOfProductsInBasket}\n");

//task04 - Store
var store1 = new Store(8, 4);

foreach (var cashRegister in store1.ListOfCashRegisters)
{
    Console.WriteLine(cashRegister);
}
*/
