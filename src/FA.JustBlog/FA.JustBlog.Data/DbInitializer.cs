using FA.JustBlog.Models.Common;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace FA.JustBlog.Data
{
    public class DbInitializer : CreateDatabaseIfNotExists<JustBlogDbContext>
    {
        protected override void Seed(JustBlogDbContext context)
        {
            
        }
    }
}
