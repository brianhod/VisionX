using System;
using System.Collections.Generic;

namespace VisionX.Data.Models
{
    public partial class User
    {
        public long UserId { get; set; }
        public string Username { get; set; }
        public string EmailAddress { get; set; }
        public string Password { get; set; }
        public bool? Locked { get; set; }
        public string UserGuid { get; set; }
    }
}
