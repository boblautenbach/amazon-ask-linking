using OAuth.Logic.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OAuth.Models;
using OAuth.Data;

namespace OAuth.Logic.Services
{
    public class UserService : IUserService
    {
        //DB Serivce calls are samples of what woudl be a service call to an endpoint with users, etc
        public async Task<User> FindUser(string email)
        {
            try { 
                var dbService = new MockUser();

                return dbService.GetUserByEmail(email);
            }
            catch (Exception e)
            {
                return null;
            }
        }

        public async Task<bool> ValidateUser(string username, string password)
        {
            try
            {
                var dbService = new MockUser();

                return dbService.LogInUser(username, password);

            }
            catch (Exception e)
            {
                return false;
            }
        }

        public Client GetClientById(string clientId)
        {
            try
            {
                var dbService = new MockClient();

                return dbService.GetClientById(clientId);

            }
            catch (Exception e)
            {
                return null;
            }
        }
    }
}
