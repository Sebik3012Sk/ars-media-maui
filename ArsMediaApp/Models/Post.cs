using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArsMediaApp.Models
{
    public class Post
    {
        public string PostName { get; set; }
        public int Likes { get; set; }
        public string PostContent { get; set; }
        public string Description { get; set; }
        public string ImageSource { get; set; }
    }
}
