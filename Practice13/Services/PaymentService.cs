using Practice13.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace Practice13.Services;

internal class PaymentService
{
    private List<Payment> payments = new List<Payment>();
    private AccountService accountService;

    public PaymentService(AccountService _accountService)
    {
        accountService = _accountService;
    }

    public void Transfer(Guid fromAccountId, Guid toAccountId, int amount)
    {
        Account fromAccount = accountService.GetById(fromAccountId);
        Account toAccount = accountService.GetById(toAccountId);

        if (fromAccount == null || toAccount == null)
        {
            Console.WriteLine("One or both accounts not found.");
            return;
        }

        if (fromAccount.Currency != toAccount.Currency)
        {
            Console.WriteLine("Cannot transfer: currencies do not match.");
            return;
        }

        if (fromAccount.Balance < amount)
        {
            Console.WriteLine("Not enough Balance");
            return;
        }

        fromAccount.Balance -= amount;
        toAccount.Balance += amount;

        Payment payment = new Payment
        {
            Id = Guid.NewGuid(),
            FromAccountId = fromAccountId,
            ToAccountId = toAccountId,
            Amount = amount,
            Currency = fromAccount.Currency,
            CreatedOn = DateTime.Now,
        };

        payments.Add(payment);

        Console.WriteLine($"Transferred {amount} {fromAccount.Currency}");
    }

    public void Add(Payment payment)
    {
        payment.Id = Guid.NewGuid();
        payment.CreatedOn = DateTime.Now;
        payments.Add(payment);
        Console.WriteLine("Added payment");
    }

    public void Update(Payment payment)
    {
        Payment paymentToUpdate = GetById(payment.Id);
        if (paymentToUpdate != null)
        {
            paymentToUpdate.FromAccountId = payment.FromAccountId;
            paymentToUpdate.ToAccountId = payment.ToAccountId;
            paymentToUpdate.Amount = payment.Amount;
            paymentToUpdate.Currency = payment.Currency;
            Console.WriteLine("Updated payment");
        }
        else
        {
            Console.WriteLine("Payment not found");
        }
    }

    public void Delete(Payment payment)
    {
        if (payments.Contains(payment))
        {
            payments.Remove(payment);
            Console.WriteLine("Deleted payment");
        }
        else
        {
            Console.WriteLine("Payment not found");
        }
    }

    public List<Payment> GetAll()
    {
        return payments;
    }

    public Payment GetById(Guid Id)
    {
        foreach (Payment p in payments)
        {
            if (p.Id == Id)
                return p;
        }
        return null;
    }
}
