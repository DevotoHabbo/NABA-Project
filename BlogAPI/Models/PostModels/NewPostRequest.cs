using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogAPI.Models.PostModels
{
    public class NewPostRequest
    {
        public string Title { get; set; }
        public string Content { get; set; }
    }
}
