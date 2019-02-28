using DREAS.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Data
{

   Public class DreasDataContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Address> Addresses { get; set; }
        public DbSet<BaseModel> BaseModels { get; set; }
        public DbSet<CompanyProfile> CompanyProfiles{get; set;}
        public DbSet<Contact> Contacts{get; set;}
        public DbSet<Enquiry> Enquiries{get; set;}
        public DbSet<Feedback> Feedbacks{get; set;}
        public DbSet<Log> Logs{get; set;}
        public DbSet<Notification> Notifications{get; set;}
        public DbSet<Payment> Payments{get; set;}
        public DbSet<Promotion> Promotions{get; set;}
        public DbSet<Property> Property{get; set;}
        public DbSet<PropertyCategory> PropertyCategories{get; set;}
        public DbSet<PropertyList> PropertyLists{get; set;}
        public DbSet<Referal> Referals{get; set;}
        public DbSet<Role> Roles{get; set;}
        public DbSet<Service> Services{get; set;}
        public DbSet<Settlement> Settlements{get; set;}
        public DbSet<Transaction> Transactions{get; set;}
        public DbSet<UserProfile> UserProfiles{get; set;}


        public DreasDataContext(DbContextOptions options):base(options)            
          {
            this.Database.EnsureCreated();
          }
    }

}
