using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity.EntityFramework;
using System.Security.Claims;
using Microsoft.AspNet.Identity;
using Microsoft.Data.Entity;
using System.Security.Principal;

namespace System.Models
{
    public class ApplicationUser : IdentityUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int? AvatarId { get; set; }
        public virtual Avatar Avatar { get; set; }
        public int? Points { get; set; }
    }

    public static class IdentityHelper
    {
        public static string GetFirstName(this IIdentity identity)
        {
            var claimIdent = identity as ClaimsIdentity;
            return claimIdent != null
                && claimIdent.HasClaim(c => c.Type == "FirstName")
                ? claimIdent.FindFirst("ProfilePicture").Value
                : string.Empty;
        }
    }
}
