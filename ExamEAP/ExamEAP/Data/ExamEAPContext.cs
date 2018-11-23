using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace ExamEAP.Models
{
    public class ExamEAPContext : DbContext
    {
        public ExamEAPContext (DbContextOptions<ExamEAPContext> options)
            : base(options)
        {
        }

        public DbSet<ExamEAP.Models.Employee> Employee { get; set; }
    }
}
