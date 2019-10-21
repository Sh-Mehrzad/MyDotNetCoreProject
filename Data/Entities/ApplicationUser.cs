using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Entities
{
    public class ApplicationUser : IdentityUser<Guid>
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string DomainUserName { get; set; }
        public DateTime RegisterDate { get; set; }
        public Nullable<DateTime> DeActivationDate { get; set; }
    }
}
