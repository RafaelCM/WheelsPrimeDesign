using System.Data.Entity;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using WheelsPrime.DAL;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace WheelsPrime.Models
{
    // You can add profile data for the user by adding more properties to your ApplicationUser class, please visit http://go.microsoft.com/fwlink/?LinkID=317594 to learn more.
    public class ApplicationUser : IdentityUser
    {
        public async Task<ClaimsIdentity> GenerateUserIdentityAsync(UserManager<ApplicationUser> manager)
        {
            // Note the authenticationType must match the one defined in CookieAuthenticationOptions.AuthenticationType
            var userIdentity = await manager.CreateIdentityAsync(this, DefaultAuthenticationTypes.ApplicationCookie);
            // Add custom user claims here
            userIdentity.AddClaim(new Claim("FirstName", this.FirstName));
            userIdentity.AddClaim(new Claim("LastName", this.LastName));
            return userIdentity;
        }

        //extra user data
        [DisplayName("Primeiro Nome")]
        public string FirstName { get; set; }

        [DisplayName("Último Nome")]
        public string LastName { get; set; }
        
        public string NIF { get; set; }

        [DisplayName("Telefone")]
        public string Telephone { get; set; }

        [DisplayName("Telemóvel")]
        public string MobilePhone { get; set; }


        //user vehicles
        public virtual ICollection<VehicleUser> Vehicle { get; set; }

        public virtual ICollection<VehicleStand> StandVehicle { get; set; }

        public virtual ICollection<Notification> Notifications { get; set; }

        public virtual ICollection<VehicleSold> BoughtVehicle { get; set; }

    }
}