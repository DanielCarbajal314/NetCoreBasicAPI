using DataAccess.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DataAccess.Context
{
    public class Shop : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"data source=localhost;
                                          initial catalog=ClaseWeb;
                                          persist security info=True;
                                          user id=sa;
                                          password=macedonio;
                                          MultipleActiveResultSets=True;");
        }



        public DbSet<Product> Products { get; set; }
    }
}
