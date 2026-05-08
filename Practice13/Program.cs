using Practice13.Models;
using Practice13.Services;

ClientService clientService = new ClientService();
AccountService accountService = new AccountService();
PaymentService paymentService = new PaymentService(accountService);

// Add clients
Client client1 = new Client { Name = "Dato", LastName = "Datoshvili", PrivateNumber = "123456789", PhoneNumber = "888-8888" };
Client client2 = new Client { Name = "soso", LastName = "sosodze", PrivateNumber = "987654321", PhoneNumber = "777-7777" };
clientService.Add(client1);
clientService.Add(client2);

// Add accounts
Account acc1 = new Account { ClientId = client1.Id, Currency = "GEL", Balance = 1000 };
Account acc2 = new Account { ClientId = client2.Id, Currency = "GEL", Balance = 500 };
Account acc3 = new Account { ClientId = client1.Id, Currency = "USD", Balance = 200 };
accountService.Add(acc1);
accountService.Add(acc2);
accountService.Add(acc3);

// Transfer money
paymentService.Transfer(acc1.Id, acc2.Id, 300);

// Attempt invalid transfer (different currency)
paymentService.Transfer(acc1.Id, acc3.Id, 100);

// invalid transfer (not enough balance)
paymentService.Transfer(acc2.Id, acc1.Id, 1000);

// Show balances
Console.WriteLine($"Balance {acc1.AccountNumber}: {acc1.Balance}");
Console.WriteLine($"Balance {acc2.AccountNumber}: {acc2.Balance}");
Console.WriteLine($"Balance {acc3.AccountNumber}: {acc3.Balance}");

// Show payments
Console.WriteLine("\nPayments made:");
foreach (var p in paymentService.GetAll())
{
    int i = 1;
    Console.WriteLine($"payment {i}: {p.Amount} {p.Currency}");
    i++;
}