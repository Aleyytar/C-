using BankDemo;
using System;
using System.Collections.Generic;

public class CustomerManager
{
    private List<Customer> customers;

    public CustomerManager()
    {
        customers = new List<Customer>();
    }

    public void AddCustomer(string name, string address, string city, string country, string phone)
    {
        Customer newCustomer = new Customer(name, address, city, country, phone);
        customers.Add(newCustomer);
    }

    public void RemoveCustomer(string name)
    {
        Customer customerToRemove = customers.Find(c => c.Name == name);
        if (customerToRemove != null)
        {
            customers.Remove(customerToRemove);
        }
        else
        {
            Console.WriteLine("Müşteri bulunamadı.");
        }
    }

    public void ListCustomers()
    {
        foreach (Customer customer in customers)
        {
            Console.WriteLine($"Ad: {customer.Name}, Adres: {customer.Address}, Şehir: {customer.City}, Ülke: {customer.Country}, Telefon: {customer.Phone}");
        }
    }
}