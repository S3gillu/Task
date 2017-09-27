using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Task.Models
{
    public class UserContext:DbContext
    {
        public UserContext():base("MyConnection")
        {

        }

        public DbSet<User> Users { get; set; }
    }
}