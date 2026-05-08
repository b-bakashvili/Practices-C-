using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace Practice13.Services;

internal class AccountService
{
    private List<Account> accounts = new List<Account>();

    private int number = 1;
    private int digits = 1;
    private int checker = 10;
    public void Add(Account account)
    {
        account.Id = Guid.NewGuid();
        account.CreatedOn = DateTime.Now;

        string result = "";

        if (number >= checker)
        {
            digits++;
            checker *= 10;
        }
        for (int i = 10; i > 10 - digits; i--)
        {
            result += '0';
        }
        result += number.ToString();
        account.AccountNumber = result + account.Currency;

        number++;

        accounts.Add(account);
        Console.WriteLine("Added account");
    }

    public void Update(Account account)
    {
        Account accountToUpdate = GetById(account.Id);
        if (accountToUpdate != null)
        {
            accountToUpdate.ClientId = account.ClientId;
            accountToUpdate.AccountName = account.AccountName;
            accountToUpdate.Currency = account.Currency;
            accountToUpdate.Balance = account.Balance;
            Console.WriteLine("Updated account");
        }
        else
        {
            Console.WriteLine("Account not found");
        }
    }

    public void Delete(Account account)
    {
        if (accounts.Contains(account))
        {
            accounts.Remove(account);
            Console.WriteLine("Deleted account");
        }
        else
        {
            Console.WriteLine("Account not found");
        }
    }

    public List<Account> GetAll()
    {
        return accounts;
    }

    public Account GetById(Guid id)
    {
        foreach (Account a in accounts)
        {
            if (a.Id == id)
                return a;
        }
        return null;
    }
}
