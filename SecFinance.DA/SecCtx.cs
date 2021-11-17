using Microsoft.EntityFrameworkCore;

using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Configuration.Json;
using SecFinance.Domain.FIN;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecFinance.DA
{
    public class SecCtx: DbContext
    {
            
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {       
            //https://stackoverflow.com/questions/38982387/entity-framework-core-1-0-connection-strings
            //https://stackoverflow.com/questions/46843367/how-to-setbasepath-in-configurationbuilder-in-core-2-0
            // get the configuration from the app settings
            var config = new ConfigurationBuilder()
                  .SetBasePath(Directory.GetCurrentDirectory())
                  .AddJsonFile("appsettings.json")
                  .Build();
            // define the database to use
            optionsBuilder.UseSqlServer(config.GetConnectionString("SecCtx"));
        }

        public virtual DbSet<Applicant> Applicants { get; set; }
        public virtual DbSet<Bank> Banks { get; set; }
        public virtual DbSet<Developer> Developers { get; set; }
        public virtual DbSet<LookUpDepartment> LookUpDepartments { get; set; }
        public virtual DbSet<LookUpSecType> LookUpSecTypes { get; set; }        
        public virtual DbSet<Security> Securities { get; set; }
        public virtual DbSet<SecurityHist> GetSecurityHists { get; set; }
        public virtual DbSet<SecurityLegal> GetSecurityLegals { get; set; }
        
        protected override void OnModelCreating(ModelBuilder builder)
        {

        }

        //https://stackoverflow.com/questions/56686093/unable-to-create-an-object-of-type-dbcontext
        //Make sure you have default constructor without parameter
        //public SecCtx(DbContextOptions<SecCtx> options):base(options)
        //{
        //}

        public SecCtx()
        {

        }

    }
}
