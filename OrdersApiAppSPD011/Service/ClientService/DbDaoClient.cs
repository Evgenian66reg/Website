using OrdersApiAppSPD011.Model.Entity;

namespace OrdersApiAppSPD011.Service.ClientService
{
    //рефлизация методов клиента
    public class DbDaoClient : IDaoClient
    {
        private static List<Client> plugClients = new List<Client>();
        private static int currentId = 1;

        //CRUD
        public Task<Client> AddAsync(Client client)
        {
            client.Id = currentId++;
            plugClients.Add(client);
            return Task.Run(() => client);
        }

        public Task<List<Client>> GetAllAsync()
        {
            return Task.Run(() => plugClients);
        }

        
        public Task<Client> DeleteAsync(int id)
        {
            Client client = plugClients[id];
            plugClients.RemoveAt(id);
            return Task.Run(() => client);
        }

        public Task<Client> GetAsync(int id)
        {
            Client client = plugClients[id]; 
            plugClients.IndexOf(client);
            return Task.Run(() => client);
        }

        public Task<Client> UpdateAsync(Client client)
        {
            plugClients.Insert(client.Id, client);
            return Task.Run(() => client);
        }
    }
}
