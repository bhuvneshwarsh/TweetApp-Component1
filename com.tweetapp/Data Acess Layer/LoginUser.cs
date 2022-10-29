using com.tweetapp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace com.tweetapp.Data_Acess_Layer
{
    class LoginUser
    {
        private StorageContext _context;
        public LoginUser()
        {
            _context = new StorageContext();
        }
        public bool Login(UserDetails userInfo)
        {
            bool isUserExist = _context.UserDetails.Any(u => u.Email == userInfo.Email && u.Password == userInfo.Password);
            if (isUserExist == true)
            {
                userInfo.IsloggedIn = true;
                _context.SaveChanges();
                return true;
            }
            else
            {
                return false;
            }
            
        }
    }
}
