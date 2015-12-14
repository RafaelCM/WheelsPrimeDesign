using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.AspNet.Identity.Owin;
using Microsoft.AspNet.Identity;
using System.Security.Principal;
using System.Security.Claims;

namespace WheelsPrime.Extensions
{
    public static class IdentityExtensions
    {
        
        public static string GetFirstName(this IIdentity identity)
        {
            var claimsIdentity = identity as System.Security.Claims.ClaimsIdentity;
            var displayNameClaim = claimsIdentity != null? claimsIdentity.Claims.SingleOrDefault(x => x.Type == "FirstName") : null;
            var nameToDisplay = displayNameClaim == null ? identity.Name : displayNameClaim.Value;
            return nameToDisplay;
        }
        public static string GetFullName(this IIdentity identity)
        {
            string FullName = "";
            var claimsIdentity = identity as System.Security.Claims.ClaimsIdentity;
            var displayNameClaim = claimsIdentity != null ? claimsIdentity.Claims.SingleOrDefault(x => x.Type == "FirstName") : null;
            var nameToDisplay = displayNameClaim == null ? identity.Name : displayNameClaim.Value;
            FullName += nameToDisplay;
            displayNameClaim = claimsIdentity != null ? claimsIdentity.Claims.SingleOrDefault(x => x.Type == "LastName") : null;
            nameToDisplay = displayNameClaim == null ? "" : displayNameClaim.Value;
            FullName += " " + nameToDisplay;
            return FullName;
        }
    }
}