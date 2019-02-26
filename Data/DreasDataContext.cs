using DREAS.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Data
{
    public class DreasDataContext : DbContext
    {
        public DbSet<User> Users { set; get; }
        public DbSet<Address> Addresses { set; get; }
        public DbSet<BaseModel> BaseModels {set; get;}
        public DbSet<CompanyProfile> CompanyProfiles { set; get;}
        public DbSet<Contact> Contacts {set; get;}
        public DbSet<Enquiry> Enquiries  {set; get;}
        public DbSet<Feedback>  FeedBacks{set; get;}
        public DbSet<Log> Logs  {set; get;}
        public DbSet<Notification> Notifications  {set; get;}
        public DbSet<Payment> Payments {set; get;}
        public DbSet<Promotion> Promotions  {set; get;}
        public DbSet<Property> Properties  {set; get;}
        public DbSet<PropertyCategory> propertyCategories  {set; get;}
        public DbSet<PropertyList> PropertyLists  { set; get; }
        public DbSet<Referal> Referals  { set; get; }
        public DbSet<Role> Roles  { set; get; }
        public DbSet<Service> Services  { set; get; }
        public DbSet<Settlement> Settlements  { set; get; }
        public DbSet<Transaction> Transactions  { set; get; }
        public DbSet<UserProfile> UserProfiles  { set; get; }


        public DreasDataContext(DbContextOptions options):base(options)            
            {
                this.Database.EnsureCreated();
            }
    }
}
