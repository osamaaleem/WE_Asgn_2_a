using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WE_Asgn_2_a.Models
{
    public class MUser
    {
        public string Name { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public char Gender { get; set; }
        public string Country { get; set; }
        public bool IsAdmin { get; set; }

    }
}