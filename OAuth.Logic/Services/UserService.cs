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
            User user = null;
            try
            {
                var dbService = new MockUser();

                user = dbService.GetUserDB(email);
            }
            catch (Exception e)
            {
                return null;
            }
            return user;
        }

        public async Task<bool> Validate(string username, string password)
        {
            User user = null;
            try
            {
                var dbService = new MockUser();

                user = dbService.LoginInUser(username, password);

            }
            catch (Exception e)
            {
                return false;
            }

            return (user != null);
        }
    }
}
