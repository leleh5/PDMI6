using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ASPAPI.Models;

namespace ASPAPI.Data
{
    public class ASPAPIdbContext : DbContext
    {
        public ASPAPIdbContext (DbContextOptions<ASPAPIdbContext> options)
            : base(options)
        {
        }

        public DbSet<ASPAPI.Models.Login> Login { get; set; } = default!;
    }
}
