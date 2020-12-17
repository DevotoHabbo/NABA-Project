﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogAPI.Models.PostModels
{
    public class PostGetOne
    {
        public int PostId { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public string UserId { get; set; }
        public DateTime Created { get; set; }
    }
}
