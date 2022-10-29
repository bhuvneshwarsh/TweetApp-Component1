using com.tweetapp.Data_Acess_Layer;
using com.tweetapp.Model;
using com.tweetapp.User_Interface_Layer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace com.tweetapp.Business_Layer.NonLoggedUser
{
    class RegisterUser
    {
        public static void Register()
        {
            var userInfo = new UserDetails();
            var userRegistration = new UserRegistration();

            Console.WriteLine("Welcome to Registration corner! Please provide following details.");
            Console.WriteLine("First Name: ");
            userInfo.FirstName = Console.ReadLine();
            Console.WriteLine("Last Name: ");
            userInfo.LastName = Console.ReadLine();
            Console.WriteLine("Gender (male/female): ");
            userInfo.Gender = Console.ReadLine();
            Console.WriteLine("DOB (DD-MM-YYYY): ");
            userInfo.Dob = Console.ReadLine();
            Console.WriteLine("Your Email: ");
            userInfo.Password = Console.ReadLine();
            Console.WriteLine("Password: ");
            userInfo.Email = Console.ReadLine();

            userRegistration.Registration(userInfo);

            Console.WriteLine("Congrats!! You have been registered Successfully.");
            WelcomeUser.WelcomeUserOption();
        }
    }
}
