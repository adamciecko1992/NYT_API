using System;
using Microsoft.EntityFrameworkCore;
using NYT_API.Data.Models;

namespace NYT_API.Data
{
    public class MyDbContext : DbContext
    {
        public MyDbContext(){}
        public MyDbContext(DbContextOptions options) : base(options)
        {}

        public virtual DbSet<Customer> Customers { get; set; }

    }
}
