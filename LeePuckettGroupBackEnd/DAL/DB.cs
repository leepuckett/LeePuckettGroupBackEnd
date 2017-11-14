using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using LeePuckettGroupBackEnd.Models;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions; 


namespace LeePuckettGroupBackEnd.DAL
{
    public class DB : DbContext
    {
        public DB() : base("DB")
        {
        }

        public DbSet<Contact> Contact { get; set; }
       

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }


    }

}