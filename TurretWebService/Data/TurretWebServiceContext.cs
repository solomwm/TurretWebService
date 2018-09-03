using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace TurretWebService.Models
{
    public class TurretWebServiceContext : DbContext
    {
        public TurretWebServiceContext (DbContextOptions<TurretWebServiceContext> options)
            : base(options)
        {
        }

        public DbSet<TurretWebService.Models.User> User { get; set; }
    }
}
