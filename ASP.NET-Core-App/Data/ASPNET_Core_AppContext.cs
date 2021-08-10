using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ASP.NET_Core_App.Models;

namespace ASP.NET_Core_App.Data
{
    public class ASPNET_Core_AppContext : DbContext
    {
        public ASPNET_Core_AppContext (DbContextOptions<ASPNET_Core_AppContext> options)
            : base(options)
        {
        }

        public DbSet<ASP.NET_Core_App.Models.Movie> Movie { get; set; }
    }
}
