using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogAPI.MVC.Models.PostModels
{
    public class ChangePostRequest
    {
        public string Title { get; set; }
        public string Content { get; set; }
    }
}
