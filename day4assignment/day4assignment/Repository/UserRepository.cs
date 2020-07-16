using day4assignment.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace day4assignment.Repository
{
    public class UserRepository: User, IuserRepository
    {
        private readonly ApplicationdbContext _db;
        public UserRepository()
        {
            _db = new ApplicationdbContext();
        }
        public User GetUser(int id)
        {
            var user = _db.users.Where(a => a.Id == id).FirstOrDefault();
            return user;
        }
        public List<User> ActiveUsers()
        {
            var active = _db.users.Where(a => a.IsActive == 1).ToList();
            return active;
        }
        public List<User> AddUser(User user)
        {
            _db.users.Add(user);
            _db.SaveChanges();
            return _db.users.ToList();


        }
        public List<User> DeleteUser(int id)
        {
            var user = _db.users.Where(a => a.Id == id).FirstOrDefault();
            _db.SaveChanges();
            return _db.users.ToList();


        }
        public List<User> Users()
        {
            var users = _db.users.ToList();
            return users;
        }

        List<User> IuserRepository.Users()
        {
            throw new NotImplementedException();
        }

        User IuserRepository.GetUser(int id)
        {
            throw new NotImplementedException();
        }

        List<User> IuserRepository.DeleteUser(int id)
        {
            throw new NotImplementedException();
        }

        List<User> IuserRepository.ActiveUsers()
        {
            throw new NotImplementedException();
        }

        public List<User> AddUsers(User user)
        {
            throw new NotImplementedException();
        }
    }
}
