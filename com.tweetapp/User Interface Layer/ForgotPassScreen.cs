using com.tweetapp.Data_Acess_Layer;
using com.tweetapp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace com.tweetapp.User_Interface_Layer
{
    class ForgotPassScreen
    {
        public static void PasswordReset()
        {
            var userInfo = new UserDetails();
            var forgotPassword = new ForgotPassword();

            Console.WriteLine("In order to Authencticate you, we must need your correct Email id.\nPlease enter your Email ID: ");
            userInfo.Email = Console.ReadLine();

            bool isEmailCorrect = forgotPassword.CheckAuthenticity(userInfo);
            if (isEmailCorrect == true)
            {
                Console.WriteLine("Please Enter new Password: ");
                userInfo.Password = Console.ReadLine();
                forgotPassword.CreateNewPassword(userInfo);
                Console.WriteLine("Password Updated Successsfully");
            }
            else
            {
                Console.WriteLine("Authentication Failed! \n\n");
                PasswordReset();
            }

        }
    }
}
