using OAuth.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OAuth.Data
{
    public class MockClient
    {
        List<Client> _clients = new List<Client>();

        public MockClient()
        {
            _clients.Add(new Client() { ClientId = 1, Active = true, AllowedOrigin = "*", ClientName = "app1", ClientSecret = "secret1", RefreshTokenLifetime = 1200, SecretRequired = true });
            _clients.Add(new Client() { ClientId = 2, Active = true, AllowedOrigin = "*", ClientName = "app2", ClientSecret = "secret2", RefreshTokenLifetime = 1200, SecretRequired = true });

        }
        public Client GetClientsDB(string clientName, string clientSecret)
        {
            return _clients.FirstOrDefault(x => x.ClientName == clientName && x.ClientSecret == clientSecret);
        }
    }
}
