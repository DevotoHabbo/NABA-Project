﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogAPI.Models.UserModels
{
    public class NewUserRequest
    {
        public string UserId { get; set; }
        public string Name { get; set; }
    }
}
