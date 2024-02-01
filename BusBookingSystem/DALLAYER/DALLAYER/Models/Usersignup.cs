using System;
using System.Collections.Generic;

namespace DALLAYER.Models
{
    public partial class Usersignup
    {
        public string? Fullname { get; set; }
        public string? Dob { get; set; }
        public string? Mobile { get; set; }
        public string? Email { get; set; }
        public string? Stat { get; set; }
        public string? City { get; set; }
        public string? Pincode { get; set; }
        public string? Adress { get; set; }
        public string Username { get; set; } = null!;
        public string? Pswrd { get; set; }
    }
}
