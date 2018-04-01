using Application;
using Data.Context;
using Data.Repositories;
using DomainModel.Entities;
using DomainModel.ObjectValues;
using DomainServices.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    public class Program
    {

        static void Main(string[] args)
        {

            User user1 = new User()
            {
                FirstName = "Bruna",
                Email = "fslkfjslf",
                PhotoProfile = new PhotoProfile() { Url = "sfhskjdf" },
                Birth = DateTime.Now
            };

            User user2 = new User()
            {
                FirstName = "Josevaldo",
                Email = "fslkfjslf",
                PhotoProfile = new PhotoProfile() { Url = "sfhskjdf" },
                Birth = DateTime.Now
        };

            ApplicationServices.GetInstance().AddNewUser(user1);
            ApplicationServices.GetInstance().AddNewUser(user2);

            foreach(var user in ApplicationServices.GetInstance().GetAllUsers())
                Console.WriteLine(user.FirstName);
            
            Console.ReadLine();
        }
    }
}
