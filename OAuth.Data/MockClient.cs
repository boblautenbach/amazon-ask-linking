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
        static List<Client> _clients = new List<Client>();

        public MockClient()
        {
            //Refresh token mock data for future implementation
            _clients.Add(new Client() { ClientId = "1212", Active = true, AllowedOrigin = "*", ClientName = "app1", ClientSecret = "secret1", RefreshTokenLifetime = 12000, SecretRequired = false });
            _clients.Add(new Client() { ClientId = "1313", Active = true, AllowedOrigin = "*", ClientName = "app2", ClientSecret = "secret2", RefreshTokenLifetime = 12000, SecretRequired = true });

        }
        public Client GetClientById(string clientId)
        {
            return _clients.FirstOrDefault(x => x.ClientId == clientId);
        }
    }
}
