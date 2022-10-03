using ASPNetAPI.Models;

namespace ASPNetAPI.Interface
{
    public class Person : IPerson
    {
        protected readonly BI_TESTGENContext _context;
        public Person(BI_TESTGENContext context) => _context = context;



        public async Task<Persona> CreateClientAsync(Persona person)
        {
            await _context.Set<Persona>().AddAsync(person);
            await _context.SaveChangesAsync();
            return person;

        }

        public Task<bool> DeleteClientAsync(Persona client)
        {
            throw new NotImplementedException();

        }

        public IEnumerable<Persona> GetClients()
        {
            return _context.Personas.ToList();
        }

        public Persona GetClientsById(int id)
        {
            throw new NotImplementedException();

        }

        public Task<bool> UpdateClientAsync(Persona client)
        {
            throw new NotImplementedException();

        }
    }
}


////
/*
using DB;
using Microsoft.EntityFrameworkCore;

namespace WebAPIClient.Interface
{
    public class ClientR : IClient
    {
        protected readonly BI_TESTGENContext _context;
        public ClientR(BI_TESTGENContext context) => _context = context;

        public async Task<Client> CreateClientAsync(Client client)
        {
            await _context.Set<Client>().AddAsync(client);
            await _context.SaveChangesAsync();
            return client;

        }

        public async Task<bool> DeleteClientAsync(Client client)
        {
            if (client is null)
            {
                return false;
            }
            _context.Set<Client>().Remove(client);
            await _context.SaveChangesAsync();

            return true;
        }

        public IEnumerable<Client> GetClients()
        {
            return _context.Clients.ToList();
        }

        public Client GetClientsById(int id)
        {
            return _context.Clients.Find(id);
        }

        public async Task<bool> UpdateClientAsync(Client client)
        {
            _context.Entry(client).State = EntityState.Modified;
            await _context.SaveChangesAsync();
            return true;
        }
    }
}
*/