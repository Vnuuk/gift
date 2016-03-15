using System;
using System.Collections.Generic;
using System.Linq;

namespace NS.Elenalife.UI
{
    public class ElContext : System.Data.Entity.DbContext
    {
        public ElContext() : base("DefaultConnection")
        {

        }

        public System.Data.Entity.DbSet<Post> Posts { get; set; }
    }
}