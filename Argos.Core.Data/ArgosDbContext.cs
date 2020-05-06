using Argos.Core.Model.Master;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Argos.Core.Data
{
    public class ArgosDbContext : DbContext
    {
        public ArgosDbContext(DbContextOptions<ArgosDbContext> dbContextOptions)
            :base(dbContextOptions) {}

        public DbSet<Fleet> Fleets { get; set; }
    }
}
