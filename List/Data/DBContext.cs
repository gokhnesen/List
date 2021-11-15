using List.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace List.Data
{
    public class DBContext:DbContext
    {
        public DBContext(DbContextOptions<DBContext> options) :base(options)
        {


        }
        public DbSet<Item> Items { get; set; }
        public DbSet<Expense> Expenses { get; set; }
    }
}
