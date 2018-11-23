using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace SearchClient.Models
{
    public class SearchClientContext : DbContext
    {
        public SearchClientContext (DbContextOptions<SearchClientContext> options)
            : base(options)
        {
        }

        public DbSet<SearchClient.Models.Employee> Employee { get; set; }
    }
}
