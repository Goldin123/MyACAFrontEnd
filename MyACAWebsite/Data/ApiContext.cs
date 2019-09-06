using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MyACAWebsite.Models;

namespace MyACAWebsite.Data
{
    public class ApiContext :DbContext
    {
        public ApiContext(DbContextOptions<ApiContext> options)
           : base(options)
        {
        }

        public DbSet<User> Users { get; set; }

     
    }
}
