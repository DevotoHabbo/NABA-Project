using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogAPI.Models.CommentModels
{
    public class CommentGet
    {
        public int CommentId { get; set; }
        public string Content { get; set; }
        public string UserName { get; set; }
        public DateTime Created {get;set;}
    }
}
