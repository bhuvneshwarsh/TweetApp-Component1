using com.tweetapp.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace com.tweetapp.Data_Acess_Layer
{
    public class StorageContext : DbContext
    {
        public StorageContext() : base("Connection")
        {

        }
        public DbSet<UserDetails> UserDetails { get; set; }
        public DbSet<TweetList> TweetLists { get; set; }
    }
}
