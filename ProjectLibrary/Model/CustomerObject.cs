﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectLibrary.Model
{
    public class CustomerObject
    {
        public int CustomerID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string Gender { get; set; }
        public string Telephone { get; set; }
        public string Email { get; set;}
        public string UserName { get; set;}
        public string Password { get; set;}
        public int Role { get; set;}

    }
}
