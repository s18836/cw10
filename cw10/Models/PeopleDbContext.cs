using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Threading.Tasks;

namespace cw10.Models
{
    public class PeopleDbContext : DbContext
    {

        public DbSet<Person> People { get; set; }
        public DbSet<Subject> Subjects { get; set; }
        public PeopleDbContext() { }


        public PeopleDbContext(DbContextOptions options) : base(options)
        {

        }


    }
}
