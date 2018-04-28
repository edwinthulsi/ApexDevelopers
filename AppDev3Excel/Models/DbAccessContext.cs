using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace AppDev3Excel.Models
{
        public class DbAccessContext : DbContext
        {
            public DbAccessContext() : base("Students") { }
            public DbSet<Student> Students
            {
                get;
                set;
            }
        }
    }
