using com.tweetapp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace com.tweetapp.Data_Acess_Layer
{
    class ForgotPassword
    {
        private StorageContext _context;
        public ForgotPassword()
        {
            _context = new StorageContext();
        }
        public bool CheckAuthenticity(UserDetails userInfo)
        {
            var user = (from u in _context.UserDetails
                        where u.Email.Equals(userInfo.Email)
                        select u).FirstOrDefault();
            if(user == null)
            {
                return false;
            }
            else
            {
                return true;
            }
         }
        public void CreateNewPassword(UserDetails userInfo)
        {
            var user = (from u in _context.UserDetails
                        where u.Email.Equals(userInfo.Email)
                        select u).FirstOrDefault();
            user.Password = userInfo.Password;
            _context.SaveChanges();
        }
    }
}
