using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace com.tweetapp.Model
{
    public class TweetList
    {
        [Key]
        public int TweetId { get; set; }
        [ForeignKey("UserDetails")]
        public int UserId { get; set; }
        public UserDetails UserDetails { get; set; }
        public string TweetContent { get; set; }
    }
}
