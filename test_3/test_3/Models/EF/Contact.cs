using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace test_3.Models.EF
{
    public class Contact
    {
        public int Id { get; set; }
        public string Title { get; set; } 
        public string Email { get; set; }
        public string Phone { get; set; }
    }
}