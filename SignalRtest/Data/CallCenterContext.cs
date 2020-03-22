using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using SignalRtest.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SignalRtest.Data
{
    public class CallCenterContext : DbContext
    {
        private readonly IConfiguration _config;
        public CallCenterContext(IConfiguration configuration)
        {
            _config = configuration;
        }

        public DbSet<Call> Calls { set; get;}


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(_config.GetConnectionString("CallCenterConnectionStrings"));
        }

    }
}
