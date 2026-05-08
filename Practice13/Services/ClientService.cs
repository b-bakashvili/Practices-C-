using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Practice13.Interface;
using Practice13.Models;

namespace Practice13.Services;

internal class ClientService : IService<Client>
{
    private List<Client> clients = new List<Client>();

    public void Add(Client client)
    {
        client.Id = Guid.NewGuid();
        client.CreatedOn = DateTime.Now;
        clients.Add(client);
        Console.WriteLine("Added client");
    }

    public void Update(Client client)
    {
        Client clientToUpdate = GetById(client.Id);
        if (clientToUpdate != null)
        {
            clientToUpdate.Name = client.Name;
            clientToUpdate.LastName = client.LastName;
            clientToUpdate.PrivateNumber = client.PrivateNumber;
            clientToUpdate.PhoneNumber = client.PhoneNumber;
            Console.WriteLine("Updated client");
        }
        else
        {
            Console.WriteLine("Client not found");
        }
    }

    public void Delete(Client client)
    {
        if (clients.Contains(client))
        {
            clients.Remove(client);
            Console.WriteLine("Deleted client");
        }
        else
        {
            Console.WriteLine("Client not found");
        }
    }
    public List<Client> GetAll()
    {
        return clients;
    }

    public Client GetById(Guid id)
    {
        foreach (Client c in clients)
        {
            if (c.Id == id)
                return c;
        }
        return null;
    }
}
