using System;
using System.Collections.Generic;

namespace VisionX.Data.Models
{
    public partial class Profile
    {
        public long ProfileId { get; set; }
        public string ProfileGuid { get; set; }
        public long? UserId { get; set; }
    }
}
