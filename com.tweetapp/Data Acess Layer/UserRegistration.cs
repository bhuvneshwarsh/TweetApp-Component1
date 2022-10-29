using com.tweetapp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace com.tweetapp.Data_Acess_Layer
{
    class UserRegistration 
    {
        private StorageContext _context;
        public UserRegistration()
        {
            _context = new StorageContext();
        }
        public void Registration(UserDetails userInfo)
        {
            _context.UserDetails.Add(userInfo);
            _context.SaveChanges();
        }
    }
}
