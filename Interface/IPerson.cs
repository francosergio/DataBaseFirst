using ASPNetAPI.Models;

namespace ASPNetAPI.Interface
{
    public interface IPerson
    {

        /*C             (CREATE)                        */
           Task<Persona> CreateClientAsync(Persona client);

        /*R             (READ)                          */
            IEnumerable<Persona> GetClients();
            Persona GetClientsById(int id); //GET by id (READ)
        /*U             (UPDATE)                        */
            Task<bool> UpdateClientAsync(Persona client);
        /*D             (DELETE)                        */
            Task<bool> DeleteClientAsync(Persona client);


    }
}

