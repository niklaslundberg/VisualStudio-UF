using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace WebApplication2.Models
{

    public class GreetingContext : DbContext
    {
        public GreetingContext()
            : base("Greetings")
        {

        }

        public DbSet<Greeting> Greetings { get; set; }
    }
}