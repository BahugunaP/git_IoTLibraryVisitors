﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class UserDetail
    {
        public int UserId { get; private set; }
        public string UserName { get; set; }
        public string Email { get; set; }
    }
}