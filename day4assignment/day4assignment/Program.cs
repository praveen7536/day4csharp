using day4assignment.Models;
using day4assignment.Repository;
using System;

namespace day4assignment
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Select an option to continue");
            UserRepository ur = new UserRepository();
            Console.WriteLine("1 -AddUser\t 2- RemoveUser\t 3-GetUser\t 4-GetAllUser\t 5-isActive\t");
            try
            {
                int opt = int.Parse(Console.ReadLine());
                switch (opt)
                {
                    case 1:
                        Console.WriteLine("you have selected to add user");
                        AddUser(ur);
                        break;

                    case 2:
                        Console.WriteLine("you have selected to remove user");
                        DeleteUser(ur);
                        break;

                    case 3:
                        Console.WriteLine("you have selected to Getuser");
                        GetUser(ur);
                        break;

                    case 4:
                        Console.WriteLine("you have selected to get allusers");
                        GetAll(ur);
                        break;

                    case 5:
                        Console.WriteLine("you have selected tocheck whether user is active or not");
                        ActiveUser(ur);
                        break;
                }
            }
            catch
            {
                Console.WriteLine("Invalid input");
            }

        }
        private static void AddUser(UserRepository ur)
        {
            Console.WriteLine("Enter user details");
            Console.WriteLine("Enter user name");
            string name = Console.ReadLine();

            Console.WriteLine("Enter user email");
            string email = Console.ReadLine();

            Console.WriteLine("Enter user location");
            string location = Console.ReadLine();

            Console.WriteLine("Enter user address");
            string address = Console.ReadLine();

            Console.WriteLine("Enter user isactive status");
            int isactive = int.Parse(Console.ReadLine());
            var choose= ur.AddUser(new User()
            {
                
                Name = name,
                Email = email,
                Location = location,
                Address = address,
                IsActive = isactive
            });
        }
        private static void DeleteUser(UserRepository ur)
        {
            Console.WriteLine("Enter a specefic id to Delete a User");
            int did = int.Parse(Console.ReadLine());
            var del = ur.DeleteUser(did);
            Console.WriteLine("Id\t Name\t Email\t Location\t Address\t isActive");
            foreach (var item in del)
            {
                Console.WriteLine(item.Id + "\t" + item.Name + "\t" + item.Email + "\t" + item.Location + "\t" + item.Address + "\t" + item.IsActive);
            }


        }
        private static void GetUser(UserRepository ur)
        {
            Console.WriteLine("Enter a specefic id to find a User");
            int gid = int.Parse(Console.ReadLine());
            User u1 = ur.GetUser(gid);
            if (u1 != null)
            {
                Console.WriteLine("Id\t Name\t Email\t Location\t Address\t isActive");
                Console.WriteLine(u1.Id + "\t" + u1.Name + "\t" + u1.Email + "\t" + u1.Location + "\t" + u1.Address + "\t" + u1.IsActive);

            }
            else
            {
                Console.WriteLine("no users found at the entered position");
            }
        }
        private static void GetAll(UserRepository ur)
        {
            //
        }
        private static void ActiveUser(UserRepository ur)
        {
            Console.WriteLine("Enter a specefic id to find the active User");
            var u2 = ur.ActiveUsers();
            
            Console.WriteLine("Id\t Name\t Email\t Location\t Address\t isActive");
            foreach (var item in u2)
            {
                Console.WriteLine(item.Id + "\t" + item.Name + "\t" + item.Email + "\t" + item.Location + "\t" + item.Address + "\t" + item.IsActive);

            }


        }

    }


}
 