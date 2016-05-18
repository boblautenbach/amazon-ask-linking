using OAuth.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OAuth.Logic.Interfaces
{
    public interface IUserService
    {
        Task<User> FindUser(string email);
        Client GetClientById(string clientId);
    }
}
