﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogAPI.MVC.Models.PostModels
{
    public class NewPostRequest
    {
        public string Title { get; set; }
        public string Content { get; set; }
        public string UserId { get; set; }
        public string UserName { get; set; }
    }
}
