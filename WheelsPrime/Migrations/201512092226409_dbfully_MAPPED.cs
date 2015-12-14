namespace WheelsPrime.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class dbfully_MAPPED : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.AppliedComponents",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Amounts = c.Int(nullable: false),
                        Accepted = c.Boolean(nullable: false),
                        Component_ID = c.Int(),
                        Repair_ID = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Components", t => t.Component_ID)
                .ForeignKey("dbo.Repairs", t => t.Repair_ID)
                .Index(t => t.Component_ID)
                .Index(t => t.Repair_ID);
            
            CreateTable(
                "dbo.Components",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Ref = c.String(),
                        Description = c.String(),
                        Price = c.Double(nullable: false),
                        RefCompetition = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Repairs",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        LaborCost = c.Double(nullable: false),
                        LaborHours = c.Double(nullable: false),
                        ReadyToTake = c.Boolean(nullable: false),
                        VehicleCheckIn_ID = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.VehicleCheckIns", t => t.VehicleCheckIn_ID)
                .Index(t => t.VehicleCheckIn_ID);
            
            CreateTable(
                "dbo.VehicleCheckIns",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        DateOfEntrace = c.DateTime(nullable: false),
                        Appointment_ID = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Appointments", t => t.Appointment_ID)
                .Index(t => t.Appointment_ID);
            
            CreateTable(
                "dbo.Appointments",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        DateTime = c.DateTime(nullable: false),
                        AppointmentRequest_ID = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.AppointmentRequests", t => t.AppointmentRequest_ID)
                .Index(t => t.AppointmentRequest_ID);
            
            CreateTable(
                "dbo.AppointmentRequests",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Description = c.String(),
                        ServiceType_ID = c.Int(),
                        VehicleUser_ID = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.ServiceTypes", t => t.ServiceType_ID)
                .ForeignKey("dbo.VehicleUsers", t => t.VehicleUser_ID)
                .Index(t => t.ServiceType_ID)
                .Index(t => t.VehicleUser_ID);
            
            CreateTable(
                "dbo.DateIntervals",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        InitialDate = c.DateTime(nullable: false),
                        EndDate = c.DateTime(nullable: false),
                        AppointmentRequest_ID = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.AppointmentRequests", t => t.AppointmentRequest_ID)
                .Index(t => t.AppointmentRequest_ID);
            
            CreateTable(
                "dbo.ServiceTypes",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.VehicleUsers",
                c => new
                    {
                        ID = c.Int(nullable: false),
                        DateManufacture = c.DateTime(nullable: false),
                        DateRegister = c.DateTime(nullable: false),
                        LicensePlate = c.String(),
                        EngineCapacity = c.Int(nullable: false),
                        NumberRecords = c.Int(nullable: false),
                        Color = c.String(),
                        BodyWork = c.String(),
                        Mileage = c.Int(nullable: false),
                        NumberDoors = c.Int(nullable: false),
                        Warranty = c.Int(nullable: false),
                        User_Id = c.String(maxLength: 128),
                        Model_ID = c.Int(),
                        FuelType_ID = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.AspNetUsers", t => t.User_Id)
                .ForeignKey("dbo.Models", t => t.Model_ID)
                .ForeignKey("dbo.FuelTypes", t => t.FuelType_ID)
                .Index(t => t.User_Id)
                .Index(t => t.Model_ID)
                .Index(t => t.FuelType_ID);
            
            CreateTable(
                "dbo.Consumptions",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Odometer = c.Int(nullable: false),
                        Liters = c.Double(nullable: false),
                        PriceLiter = c.Double(nullable: false),
                        Date = c.DateTime(nullable: false),
                        Full = c.Boolean(nullable: false),
                        VehicleUser_ID = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.VehicleUsers", t => t.VehicleUser_ID)
                .Index(t => t.VehicleUser_ID);
            
            CreateTable(
                "dbo.Expenses",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Description = c.String(),
                        Price = c.Int(nullable: false),
                        VehicleUser_ID = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.VehicleUsers", t => t.VehicleUser_ID)
                .Index(t => t.VehicleUser_ID);
            
            CreateTable(
                "dbo.VehicleExtras",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        VehicleSold_ID = c.Int(),
                        VehicleStand_ID = c.Int(),
                        VehicleUser_ID = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.VehicleSolds", t => t.VehicleSold_ID)
                .ForeignKey("dbo.VehicleStands", t => t.VehicleStand_ID)
                .ForeignKey("dbo.VehicleUsers", t => t.VehicleUser_ID)
                .Index(t => t.VehicleSold_ID)
                .Index(t => t.VehicleStand_ID)
                .Index(t => t.VehicleUser_ID);
            
            CreateTable(
                "dbo.VehicleSolds",
                c => new
                    {
                        ID = c.Int(nullable: false),
                        DateOfSale = c.DateTime(nullable: false),
                        Price = c.Int(nullable: false),
                        DateManufacture = c.DateTime(nullable: false),
                        DateRegister = c.DateTime(nullable: false),
                        LicensePlate = c.String(),
                        EngineCapacity = c.Int(nullable: false),
                        NumberRecords = c.Int(nullable: false),
                        Color = c.String(),
                        BodyWork = c.String(),
                        Mileage = c.Int(nullable: false),
                        NumberDoors = c.Int(nullable: false),
                        Warranty = c.Int(nullable: false),
                        FuelType_ID = c.Int(),
                        User_Id = c.String(maxLength: 128),
                        Model_ID = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.FuelTypes", t => t.FuelType_ID)
                .ForeignKey("dbo.AspNetUsers", t => t.User_Id)
                .ForeignKey("dbo.Models", t => t.Model_ID)
                .Index(t => t.FuelType_ID)
                .Index(t => t.User_Id)
                .Index(t => t.Model_ID);
            
            CreateTable(
                "dbo.FuelTypes",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Type = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.VehicleStands",
                c => new
                    {
                        ID = c.Int(nullable: false),
                        Price = c.Int(nullable: false),
                        DateManufacture = c.DateTime(nullable: false),
                        DateRegister = c.DateTime(nullable: false),
                        LicensePlate = c.String(),
                        EngineCapacity = c.Int(nullable: false),
                        NumberRecords = c.Int(nullable: false),
                        Color = c.String(),
                        BodyWork = c.String(),
                        Mileage = c.Int(nullable: false),
                        NumberDoors = c.Int(nullable: false),
                        Warranty = c.Int(nullable: false),
                        FuelType_ID = c.Int(),
                        InterestedUser_Id = c.String(maxLength: 128),
                        Model_ID = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.FuelTypes", t => t.FuelType_ID)
                .ForeignKey("dbo.AspNetUsers", t => t.InterestedUser_Id)
                .ForeignKey("dbo.Models", t => t.Model_ID)
                .Index(t => t.FuelType_ID)
                .Index(t => t.InterestedUser_Id)
                .Index(t => t.Model_ID);
            
            CreateTable(
                "dbo.Images",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        URL = c.String(),
                        VehicleSold_ID = c.Int(),
                        VehicleStand_ID = c.Int(),
                        VehicleUser_ID = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.VehicleSolds", t => t.VehicleSold_ID)
                .ForeignKey("dbo.VehicleStands", t => t.VehicleStand_ID)
                .ForeignKey("dbo.VehicleUsers", t => t.VehicleUser_ID)
                .Index(t => t.VehicleSold_ID)
                .Index(t => t.VehicleStand_ID)
                .Index(t => t.VehicleUser_ID);
            
            CreateTable(
                "dbo.AspNetUsers",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        FirstName = c.String(),
                        LastName = c.String(),
                        NIF = c.String(),
                        Telephone = c.String(),
                        MobilePhone = c.String(),
                        Email = c.String(maxLength: 256),
                        EmailConfirmed = c.Boolean(nullable: false),
                        PasswordHash = c.String(),
                        SecurityStamp = c.String(),
                        PhoneNumber = c.String(),
                        PhoneNumberConfirmed = c.Boolean(nullable: false),
                        TwoFactorEnabled = c.Boolean(nullable: false),
                        LockoutEndDateUtc = c.DateTime(),
                        LockoutEnabled = c.Boolean(nullable: false),
                        AccessFailedCount = c.Int(nullable: false),
                        UserName = c.String(nullable: false, maxLength: 256),
                    })
                .PrimaryKey(t => t.Id)
                .Index(t => t.UserName, unique: true, name: "UserNameIndex");
            
            CreateTable(
                "dbo.AspNetUserClaims",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        UserId = c.String(nullable: false, maxLength: 128),
                        ClaimType = c.String(),
                        ClaimValue = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.AspNetUsers", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId);
            
            CreateTable(
                "dbo.AspNetUserLogins",
                c => new
                    {
                        LoginProvider = c.String(nullable: false, maxLength: 128),
                        ProviderKey = c.String(nullable: false, maxLength: 128),
                        UserId = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => new { t.LoginProvider, t.ProviderKey, t.UserId })
                .ForeignKey("dbo.AspNetUsers", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId);
            
            CreateTable(
                "dbo.Notifications",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Description = c.String(),
                        Viewed = c.Boolean(nullable: false),
                        Appointment_ID = c.Int(),
                        User_Id = c.String(maxLength: 128),
                        VehicleStand_ID = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Appointments", t => t.Appointment_ID)
                .ForeignKey("dbo.AspNetUsers", t => t.User_Id)
                .ForeignKey("dbo.VehicleStands", t => t.VehicleStand_ID)
                .Index(t => t.Appointment_ID)
                .Index(t => t.User_Id)
                .Index(t => t.VehicleStand_ID);
            
            CreateTable(
                "dbo.AspNetUserRoles",
                c => new
                    {
                        UserId = c.String(nullable: false, maxLength: 128),
                        RoleId = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => new { t.UserId, t.RoleId })
                .ForeignKey("dbo.AspNetUsers", t => t.UserId, cascadeDelete: true)
                .ForeignKey("dbo.AspNetRoles", t => t.RoleId, cascadeDelete: true)
                .Index(t => t.UserId)
                .Index(t => t.RoleId);
            
            CreateTable(
                "dbo.Models",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Brand_ID = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Brands", t => t.Brand_ID)
                .Index(t => t.Brand_ID);
            
            CreateTable(
                "dbo.Brands",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.AspNetRoles",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        Name = c.String(nullable: false, maxLength: 256),
                    })
                .PrimaryKey(t => t.Id)
                .Index(t => t.Name, unique: true, name: "RoleNameIndex");
            
            CreateTable(
                "dbo.VehicleCheckOuts",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        DateOfExit = c.DateTime(nullable: false),
                        Repair_ID = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Repairs", t => t.Repair_ID)
                .Index(t => t.Repair_ID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.VehicleCheckOuts", "Repair_ID", "dbo.Repairs");
            DropForeignKey("dbo.AspNetUserRoles", "RoleId", "dbo.AspNetRoles");
            DropForeignKey("dbo.Repairs", "VehicleCheckIn_ID", "dbo.VehicleCheckIns");
            DropForeignKey("dbo.VehicleCheckIns", "Appointment_ID", "dbo.Appointments");
            DropForeignKey("dbo.Appointments", "AppointmentRequest_ID", "dbo.AppointmentRequests");
            DropForeignKey("dbo.VehicleExtras", "VehicleUser_ID", "dbo.VehicleUsers");
            DropForeignKey("dbo.VehicleUsers", "FuelType_ID", "dbo.FuelTypes");
            DropForeignKey("dbo.VehicleUsers", "Model_ID", "dbo.Models");
            DropForeignKey("dbo.VehicleStands", "Model_ID", "dbo.Models");
            DropForeignKey("dbo.VehicleSolds", "Model_ID", "dbo.Models");
            DropForeignKey("dbo.Models", "Brand_ID", "dbo.Brands");
            DropForeignKey("dbo.VehicleUsers", "User_Id", "dbo.AspNetUsers");
            DropForeignKey("dbo.VehicleStands", "InterestedUser_Id", "dbo.AspNetUsers");
            DropForeignKey("dbo.AspNetUserRoles", "UserId", "dbo.AspNetUsers");
            DropForeignKey("dbo.Notifications", "VehicleStand_ID", "dbo.VehicleStands");
            DropForeignKey("dbo.Notifications", "User_Id", "dbo.AspNetUsers");
            DropForeignKey("dbo.Notifications", "Appointment_ID", "dbo.Appointments");
            DropForeignKey("dbo.AspNetUserLogins", "UserId", "dbo.AspNetUsers");
            DropForeignKey("dbo.AspNetUserClaims", "UserId", "dbo.AspNetUsers");
            DropForeignKey("dbo.VehicleSolds", "User_Id", "dbo.AspNetUsers");
            DropForeignKey("dbo.Images", "VehicleUser_ID", "dbo.VehicleUsers");
            DropForeignKey("dbo.Images", "VehicleStand_ID", "dbo.VehicleStands");
            DropForeignKey("dbo.Images", "VehicleSold_ID", "dbo.VehicleSolds");
            DropForeignKey("dbo.VehicleStands", "FuelType_ID", "dbo.FuelTypes");
            DropForeignKey("dbo.VehicleExtras", "VehicleStand_ID", "dbo.VehicleStands");
            DropForeignKey("dbo.VehicleSolds", "FuelType_ID", "dbo.FuelTypes");
            DropForeignKey("dbo.VehicleExtras", "VehicleSold_ID", "dbo.VehicleSolds");
            DropForeignKey("dbo.Expenses", "VehicleUser_ID", "dbo.VehicleUsers");
            DropForeignKey("dbo.Consumptions", "VehicleUser_ID", "dbo.VehicleUsers");
            DropForeignKey("dbo.AppointmentRequests", "VehicleUser_ID", "dbo.VehicleUsers");
            DropForeignKey("dbo.AppointmentRequests", "ServiceType_ID", "dbo.ServiceTypes");
            DropForeignKey("dbo.DateIntervals", "AppointmentRequest_ID", "dbo.AppointmentRequests");
            DropForeignKey("dbo.AppliedComponents", "Repair_ID", "dbo.Repairs");
            DropForeignKey("dbo.AppliedComponents", "Component_ID", "dbo.Components");
            DropIndex("dbo.VehicleCheckOuts", new[] { "Repair_ID" });
            DropIndex("dbo.AspNetRoles", "RoleNameIndex");
            DropIndex("dbo.Models", new[] { "Brand_ID" });
            DropIndex("dbo.AspNetUserRoles", new[] { "RoleId" });
            DropIndex("dbo.AspNetUserRoles", new[] { "UserId" });
            DropIndex("dbo.Notifications", new[] { "VehicleStand_ID" });
            DropIndex("dbo.Notifications", new[] { "User_Id" });
            DropIndex("dbo.Notifications", new[] { "Appointment_ID" });
            DropIndex("dbo.AspNetUserLogins", new[] { "UserId" });
            DropIndex("dbo.AspNetUserClaims", new[] { "UserId" });
            DropIndex("dbo.AspNetUsers", "UserNameIndex");
            DropIndex("dbo.Images", new[] { "VehicleUser_ID" });
            DropIndex("dbo.Images", new[] { "VehicleStand_ID" });
            DropIndex("dbo.Images", new[] { "VehicleSold_ID" });
            DropIndex("dbo.VehicleStands", new[] { "Model_ID" });
            DropIndex("dbo.VehicleStands", new[] { "InterestedUser_Id" });
            DropIndex("dbo.VehicleStands", new[] { "FuelType_ID" });
            DropIndex("dbo.VehicleSolds", new[] { "Model_ID" });
            DropIndex("dbo.VehicleSolds", new[] { "User_Id" });
            DropIndex("dbo.VehicleSolds", new[] { "FuelType_ID" });
            DropIndex("dbo.VehicleExtras", new[] { "VehicleUser_ID" });
            DropIndex("dbo.VehicleExtras", new[] { "VehicleStand_ID" });
            DropIndex("dbo.VehicleExtras", new[] { "VehicleSold_ID" });
            DropIndex("dbo.Expenses", new[] { "VehicleUser_ID" });
            DropIndex("dbo.Consumptions", new[] { "VehicleUser_ID" });
            DropIndex("dbo.VehicleUsers", new[] { "FuelType_ID" });
            DropIndex("dbo.VehicleUsers", new[] { "Model_ID" });
            DropIndex("dbo.VehicleUsers", new[] { "User_Id" });
            DropIndex("dbo.DateIntervals", new[] { "AppointmentRequest_ID" });
            DropIndex("dbo.AppointmentRequests", new[] { "VehicleUser_ID" });
            DropIndex("dbo.AppointmentRequests", new[] { "ServiceType_ID" });
            DropIndex("dbo.Appointments", new[] { "AppointmentRequest_ID" });
            DropIndex("dbo.VehicleCheckIns", new[] { "Appointment_ID" });
            DropIndex("dbo.Repairs", new[] { "VehicleCheckIn_ID" });
            DropIndex("dbo.AppliedComponents", new[] { "Repair_ID" });
            DropIndex("dbo.AppliedComponents", new[] { "Component_ID" });
            DropTable("dbo.VehicleCheckOuts");
            DropTable("dbo.AspNetRoles");
            DropTable("dbo.Brands");
            DropTable("dbo.Models");
            DropTable("dbo.AspNetUserRoles");
            DropTable("dbo.Notifications");
            DropTable("dbo.AspNetUserLogins");
            DropTable("dbo.AspNetUserClaims");
            DropTable("dbo.AspNetUsers");
            DropTable("dbo.Images");
            DropTable("dbo.VehicleStands");
            DropTable("dbo.FuelTypes");
            DropTable("dbo.VehicleSolds");
            DropTable("dbo.VehicleExtras");
            DropTable("dbo.Expenses");
            DropTable("dbo.Consumptions");
            DropTable("dbo.VehicleUsers");
            DropTable("dbo.ServiceTypes");
            DropTable("dbo.DateIntervals");
            DropTable("dbo.AppointmentRequests");
            DropTable("dbo.Appointments");
            DropTable("dbo.VehicleCheckIns");
            DropTable("dbo.Repairs");
            DropTable("dbo.Components");
            DropTable("dbo.AppliedComponents");
        }
    }
}
