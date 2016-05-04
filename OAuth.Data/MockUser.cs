using OAuth.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OAuth.Data
{
    public class MockUser
    {
        List<User> _users = new List<User>();

        public MockUser()
        {
            _users.Add(new User() { FirstName = "Bob", LastName = "Lautenbach", Email = "bob@braneworks.com", Password = "password" });
            _users.Add(new User() { FirstName = "Walter", LastName = "Quesada", Email = "walt.quesada@walt.com", Password = "password" });
            _users.Add(new User() { FirstName = "Tom", LastName = "Jones", Email = "tomjones@tom.com", Password = "password" });

        }
        public User LoginInUser(string email, string password)
        {
            return _users.FirstOrDefault(x => x.Email == email && x.Password == password);
        }

        public User GetUserDB(string email)
        {
            return _users.FirstOrDefault(x => x.Email == email);
        }
    }
}
