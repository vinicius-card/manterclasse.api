using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using manterclasse.api.Models;

namespace manterclasse.api.Data
{
    public class manterclasseapiContext : DbContext
    {
        public manterclasseapiContext (DbContextOptions<manterclasseapiContext> options)
            : base(options)
        {
        }

        public DbSet<manterclasse.api.Models.Class> Class { get; set; }
    }
}
