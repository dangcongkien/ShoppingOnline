using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingOnlineWeb.Models
{
    public class Comment
    {
        public int CommentID { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public int ProductID { get; set; }
        public string CommentHeader { get; set; }
        public string CommentText { get; set; }
        public DateTime CommentTime { get; set; }

        public Product Product { get; set; }
    }
}
