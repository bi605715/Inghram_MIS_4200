using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Inghram_MIS_4200.Models; 
using System.Data.Entity;

namespace Inghram_MIS_4200.DAL
{
    public class Context : DbContext
    {
        public Context() : base("name=DefaultConnection")
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<Context, Inghram_MIS_4200.Migrations.MISContext.Configuration>("DefaultConnection"));


            // this method is a 'constructor' and is called when a new context is created
            // the base attribute says which connection string to use
        }
        // Include each object here. The value inside <> is the name of the class,
        // the value outside should generally be the plural of the class name
        // and is the name used to reference the entity in code
        public DbSet<course> course { get; set; }
        public DbSet<student> student { get; set; }
        public DbSet<courseDetail> courseDetails { get; set; }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
   
