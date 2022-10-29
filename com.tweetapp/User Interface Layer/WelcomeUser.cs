using com.tweetapp.Business_Layer.NonLoggedUser;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace com.tweetapp.User_Interface_Layer
{
    class WelcomeUser
    {
        public static void WelcomeScreen()
        {
            Console.WriteLine("Welcome to Tweeter!");
            Console.WriteLine("* * * * * * * * * * * * *");
        }
        public static void WelcomeUserOption()
        {
            Console.WriteLine("Press one of the below number to select an option:\n1. Register\n2. Login\n3. Forgot Password.");
            int option = Convert.ToInt32(Console.ReadLine());
            switch (option)
            {
                case 1:
                    RegisterUser.Register();
                    break;
                case 2:
                    LoginCorner.LoginScreen();
                    break;
                case 3:
                    ForgotPassScreen.PasswordReset();
                    break;
                default:
                    Console.WriteLine("Kindly press a valid input!\n\n\n");
                    WelcomeUserOption();
                    break;
            }
        }
    }
}
