using com.tweetapp.Data_Acess_Layer;
using com.tweetapp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace com.tweetapp.User_Interface_Layer
{
    class LoginCorner
    {
        public static void LoginScreen()
        {
            var userInfo = new UserDetails();
            var loginUser = new LoginUser();

            Console.WriteLine("Hola There! It is a login corner, Please provide below details for login.");
            Console.WriteLine("Enter your email: ");
            userInfo.Email = Console.ReadLine();
            Console.WriteLine("Enter your Password: ");
            userInfo.Password = Console.ReadLine();

            bool isUserExist = loginUser.Login(userInfo);
            if (isUserExist)
            {
                Console.WriteLine("Logged in successfully!!");

                var loggedInWelcome = new LoggedInScreen();
                loggedInWelcome.LoggedInOptions();
            }
            else
            {
                Console.WriteLine("Invalid username or Password!");
            }
        }
    }
}
