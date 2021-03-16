using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SampleDemoMVC.Models;

namespace SampleDemoMVC.Data
{
    public class SampleDemoMVCContext : DbContext
    {
        public SampleDemoMVCContext (DbContextOptions<SampleDemoMVCContext> options)
            : base(options)
        {
        }

        public DbSet<SampleDemoMVC.Models.Users> User { get; set; }

    }
}
