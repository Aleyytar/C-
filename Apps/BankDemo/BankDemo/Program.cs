using BankDemo;

CustomerManager customerManager = new CustomerManager();


customerManager.AddCustomer("Yunus Emre", "Yalova Merkez", "Yalova ", "Turkiye", "551234");
customerManager.AddCustomer("Ali Haydar", "Merkez Camii", "İstanbul", "Turkiye", "555678");


Console.WriteLine("Müşteriler:");
customerManager.ListCustomers();


customerManager.RemoveCustomer("Ali Haydar");


Console.WriteLine("\nGüncellenmiş Müşteriler:");
customerManager.ListCustomers();