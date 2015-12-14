using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WheelsPrime.Models;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace WheelsPrime.DAL
{
    public class WheelsprimeDBContext : IdentityDbContext<ApplicationUser>
    {
        public WheelsprimeDBContext()
            : base("wheelsprimedb", throwIfV1Schema: false)
        {

        }

        public DbSet<AppliedComponent> AppliedComponent { get; set; }
        
        public DbSet<Brand> Brand { get; set; }
        public DbSet<Component> Component { get; set; }
        public DbSet<FuelType> FuelType { get; set; }
        public DbSet<Model> Model { get; set; }
        public DbSet<Notification> Notification { get; set; }
        public DbSet<VehicleExtra> VehicleExtra { get; set; }
        public DbSet<VehicleSold> VehicleSold { get; set; }
        //public DbSet<Vehicle> Vehicle { get; set; }
        public DbSet<VehicleStand> VehicleStand { get; set; }
        public DbSet<VehicleUser> VehicleUser { get; set; }
        public DbSet<Consumption> Consumption { get; set; }
        public DbSet<Expense> Expense { get; set; }
        public DbSet<ServiceType> ServiceType { get; set; }
        public DbSet<DateInterval> DateInterval { get; set; }
        public DbSet<AppointmentRequest> AppointmentRequest { get; set; }
        public DbSet<Appointment> Appointment { get; set; }
        public DbSet<Repair> Repair { get; set; }
        public DbSet<VehicleCheckIn> VehicleCheckIn { get; set; }
        public DbSet<VehicleCheckOut> VehicleCheckOut { get; set; }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
                base.OnModelCreating(modelBuilder);
                modelBuilder.Entity<VehicleUser>().Map(m =>
              {
                  m.MapInheritedProperties();
                  m.ToTable("VehicleUsers");
              });

                modelBuilder.Entity<VehicleStand>().Map(m =>
                {
                    m.MapInheritedProperties();
                    m.ToTable("VehicleStands");
                });

                modelBuilder.Entity<VehicleSold>().Map(m =>
                {
                    m.MapInheritedProperties();
                    m.ToTable("VehicleSolds");
                });

        }


        public static WheelsprimeDBContext Create()
        {
            return new WheelsprimeDBContext();
        }
    }
}