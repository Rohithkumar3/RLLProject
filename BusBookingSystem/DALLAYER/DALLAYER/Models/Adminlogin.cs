using System;
using System.Collections.Generic;

namespace DALLAYER.Models
{
    public partial class Adminlogin
    {
        public string Username { get; set; } = null!;
        public string? Pswrd { get; set; }
        public string? Name { get; set; }
    }
}
