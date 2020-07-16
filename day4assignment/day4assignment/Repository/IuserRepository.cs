using System;
using System.Collections.Generic;
using System.Text;
using day4assignment.Models;

namespace day4assignment.Repository
{
    interface IuserRepository
    {  
        public List<User> Users();
        public User GetUser(int id);
        public List<User> DeleteUser(int id);
        public List<User> ActiveUsers();
        public List<User> AddUser(User user);
    }

}
