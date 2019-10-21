using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Entities
{
    public class ApplicationRole : IdentityRole<Guid>
    {
        public string Descriptions { get; set; }
    }
}
