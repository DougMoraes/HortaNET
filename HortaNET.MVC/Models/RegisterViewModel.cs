﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HortaNET.MVC.Models
{
    public class RegisterViewModel
    {
        public string email { get; set; }
        public string password { get; set; }
        public string confirmPassword { get; set; }

    }
}