namespace FA.JustBlog.Data.Migrations
{
    using FA.JustBlog.Models.Common;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<FA.JustBlog.Data.JustBlogDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(FA.JustBlog.Data.JustBlogDbContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.
            var categories = new Category[]
            {
                new Category
                {
                    Id = Guid.NewGuid(),
                    Name = "Armand Fintano",
                    UrlSlug =   "Robinson",
                    Description ="The All-New ASICS GEL-KAYANO® 28 delivers FF Blast™ for a more stable ride and a lower-profile heel to cradle your foot.",
                    IsDeleted = false
                },
                new Category
                {
                    Id = Guid.NewGuid(),
                    Name = "Oscar Cardozo",
                    UrlSlug =   "recipe",
                    Description ="The All-New ASICS GEL-KAYANO® 28 delivers FF Blast™ for a more stable ride and a lower-profile heel to cradle your foot.",
                    IsDeleted = false
                },
                new Category
                {
                    Id = Guid.NewGuid(),
                    Name = "Grizzy",
                    UrlSlug =   "tips",
                    Description ="The All-New ASICS GEL-KAYANO® 28 delivers FF Blast™ for a more stable ride and a lower-profile heel to cradle your foot.",
                    IsDeleted = false
                },
                new Category
                {
                    Id = Guid.NewGuid(),
                    Name = "Bernwood",
                    UrlSlug =   "life-style",
                    Description ="The All-New ASICS GEL-KAYANO® 28 delivers FF Blast™ for a more stable ride and a lower-profile heel to cradle your foot.",
                    IsDeleted = false
                }
            };

            var tag1 = new Tag
            {
                Id = Guid.NewGuid(),
                Name = "Camel",
                UrlSlug = "travel",
                Description = "Automatically earn a total of 5% back on all Zappos purchases when using your Amazon Rewards Visa Card.*",
                IsDeleted = false
            };

            var tag2 = new Tag
            {
                Id = Guid.NewGuid(),
                Name = "Xahara",
                UrlSlug = "food",
                Description = "Automatically earn a total of 5% back on all Zappos purchases when using your Amazon Rewards Visa Card.*",
                IsDeleted = false
            };

            var tag3 = new Tag
            {
                Id = Guid.NewGuid(),
                Name = "Futre",
                UrlSlug = "recipe",
                Description = "Automatically earn a total of 5% back on all Zappos purchases when using your Amazon Rewards Visa Card.*",
                IsDeleted = false
            };

            var tag4 = new Tag
            {
                Id = Guid.NewGuid(),
                Name = "Figo",
                UrlSlug = "tips",
                Description = "Automatically earn a total of 5% back on all Zappos purchases when using your Amazon Rewards Visa Card.*",
                IsDeleted = false
            };

            var tag5 = new Tag
            {
                Id = Guid.NewGuid(),
                Name = "Germany",
                UrlSlug = "study",
                Description = "Automatically earn a total of 5% back on all Zappos purchases when using your Amazon Rewards Visa Card.*",
                IsDeleted = false
            };

            var tag6 = new Tag
            {
                Id = Guid.NewGuid(),
                Name = "Gasperini",
                UrlSlug = "life-style",
                Description = "Automatically earn a total of 5% back on all Zappos purchases when using your Amazon Rewards Visa Card.*",
                IsDeleted = false
            };

            var tag7 = new Tag
            {
                Id = Guid.NewGuid(),
                Name = "Scroll",
                UrlSlug = "setup",
                Description = "Automatically earn a total of 5% back on all Zappos purchases when using your Amazon Rewards Visa Card.*",
                IsDeleted = false
            };

            var posts = new List<Post>
            {
                new Post
                {
                    Id = Guid.NewGuid(),
                    Title = "Post 01",
                    UrlSlug = "post-01",
                    ShortDescription = "Request blocked. We can't connect to the server for this app or website at this time. There might be too much traffic or a configuration error. Try again later, or contact the app or website owner.",
                    ImageUrl = "white1.jpg",
                    PostContent = "All Vehicles Prices Exclude Sales Taxes, DMV Lic." +
                    " Fees, Finance Charges if Any, $80 Dealer Document Preparation Charge, " +
                    "Any Emission Testing Charge, Rebates in Lieu of Special Financing, All Vehicles " +
                    "Subject to Prior Sale, Prices Subject to Change. We are not responsible for misprints " +
                    "or errors. Folsom Buick GMC Makes Every Effort to Assure Accurate Information, Should an " +
                    "Error Occur, We will Make Updates Promptly. See Dealer for complete details. EPA Estimates " +
                    "Only No Cooling Off Period on Home Deliveries",
                    PublishedDate = DateTime.Now,
                    IsDeleted = false,
                    Published = true,
                    Category = categories.Single(x => x.Name == categories[0].Name),
                    Tags = new List<Tag>{tag1, tag2,tag3}
                },
                new Post
                {
                    Id = Guid.NewGuid(),
                    Title = "Post 02",
                    UrlSlug = "post-02",
                    ShortDescription = "Request blocked. We can't connect to the server for this app or website at this time. There might be too much traffic or a configuration error. Try again later, or contact the app or website owner.",
                    ImageUrl = "white2.jpg",
                    PostContent = "All Vehicles Prices Exclude Sales Taxes, DMV Lic." +
                    " Fees, Finance Charges if Any, $80 Dealer Document Preparation Charge, " +
                    "Any Emission Testing Charge, Rebates in Lieu of Special Financing, All Vehicles " +
                    "Subject to Prior Sale, Prices Subject to Change. We are not responsible for misprints " +
                    "or errors. Folsom Buick GMC Makes Every Effort to Assure Accurate Information, Should an " +
                    "Error Occur, We will Make Updates Promptly. See Dealer for complete details. EPA Estimates " +
                    "Only No Cooling Off Period on Home Deliveries",
                    PublishedDate = DateTime.Now,
                    IsDeleted = false,
                    Published = true,
                    Category = categories.Single(x => x.Name == categories[3].Name),
                    Tags = new List<Tag>{tag1, tag4,tag3}
                },
                new Post
                {
                    Id = Guid.NewGuid(),
                    Title = "Post 03",
                    UrlSlug = "post-03",
                    ShortDescription = "Request blocked. We can't connect to the server for this app or website at this time. There might be too much traffic or a configuration error. Try again later, or contact the app or website owner.",
                    ImageUrl = "white3.jpg",
                    PostContent = "All Vehicles Prices Exclude Sales Taxes, DMV Lic." +
                    " Fees, Finance Charges if Any, $80 Dealer Document Preparation Charge, " +
                    "Any Emission Testing Charge, Rebates in Lieu of Special Financing, All Vehicles " +
                    "Subject to Prior Sale, Prices Subject to Change. We are not responsible for misprints " +
                    "or errors. Folsom Buick GMC Makes Every Effort to Assure Accurate Information, Should an " +
                    "Error Occur, We will Make Updates Promptly. See Dealer for complete details. EPA Estimates " +
                    "Only No Cooling Off Period on Home Deliveries",
                    PublishedDate = DateTime.Now,
                    IsDeleted = false,
                    Published = true,
                    Category = categories.Single(x => x.Name == categories[1].Name),
                    Tags = new List<Tag>{tag5, tag2,tag3}
                },
                new Post
                {
                    Id = Guid.NewGuid(),
                    Title = "Post 04",
                    UrlSlug = "post-04",
                    ShortDescription = "Request blocked. We can't connect to the server for this app or website at this time. There might be too much traffic or a configuration error. Try again later, or contact the app or website owner.",
                    ImageUrl = "white4.jpg",
                    PostContent = "All Vehicles Prices Exclude Sales Taxes, DMV Lic." +
                    " Fees, Finance Charges if Any, $80 Dealer Document Preparation Charge, " +
                    "Any Emission Testing Charge, Rebates in Lieu of Special Financing, All Vehicles " +
                    "Subject to Prior Sale, Prices Subject to Change. We are not responsible for misprints " +
                    "or errors. Folsom Buick GMC Makes Every Effort to Assure Accurate Information, Should an " +
                    "Error Occur, We will Make Updates Promptly. See Dealer for complete details. EPA Estimates " +
                    "Only No Cooling Off Period on Home Deliveries",
                    PublishedDate = DateTime.Now,
                    IsDeleted = false,
                    Published = true,
                    Category = categories.Single(x => x.Name == categories[2].Name),
                    Tags = new List<Tag>{tag1, tag5,tag3}
                },
                new Post
                {
                    Id = Guid.NewGuid(),
                    Title = "Post 05",
                    UrlSlug = "post-05",
                    ShortDescription = "Request blocked. We can't connect to the server for this app or website at this time. There might be too much traffic or a configuration error. Try again later, or contact the app or website owner.",
                    ImageUrl = "white5.jpeg",
                    PostContent = "All Vehicles Prices Exclude Sales Taxes, DMV Lic." +
                    " Fees, Finance Charges if Any, $80 Dealer Document Preparation Charge, " +
                    "Any Emission Testing Charge, Rebates in Lieu of Special Financing, All Vehicles " +
                    "Subject to Prior Sale, Prices Subject to Change. We are not responsible for misprints " +
                    "or errors. Folsom Buick GMC Makes Every Effort to Assure Accurate Information, Should an " +
                    "Error Occur, We will Make Updates Promptly. See Dealer for complete details. EPA Estimates " +
                    "Only No Cooling Off Period on Home Deliveries",
                    PublishedDate = DateTime.Now,
                    IsDeleted = false,
                    Published = true,
                    Category = categories.Single(x => x.Name == categories[1].Name),
                    Tags = new List<Tag>{tag2,tag3}
                },
                new Post
                {
                    Id = Guid.NewGuid(),
                    Title = "Post 06",
                    UrlSlug = "post-06",
                    ShortDescription = "Request blocked. We can't connect to the server for this app or website at this time. There might be too much traffic or a configuration error. Try again later, or contact the app or website owner.",
                    ImageUrl = "lokonga1.jpeg",
                    PostContent = "All Vehicles Prices Exclude Sales Taxes, DMV Lic." +
                    " Fees, Finance Charges if Any, $80 Dealer Document Preparation Charge, " +
                    "Any Emission Testing Charge, Rebates in Lieu of Special Financing, All Vehicles " +
                    "Subject to Prior Sale, Prices Subject to Change. We are not responsible for misprints " +
                    "or errors. Folsom Buick GMC Makes Every Effort to Assure Accurate Information, Should an " +
                    "Error Occur, We will Make Updates Promptly. See Dealer for complete details. EPA Estimates " +
                    "Only No Cooling Off Period on Home Deliveries",
                    PublishedDate = DateTime.Now,
                    IsDeleted = false,
                    Published = true,
                    Category = categories.Single(x => x.Name == categories[0].Name),
                    Tags = new List<Tag>{tag6,tag3}
                }
            };
            context.Categories.AddRange(categories);
            context.Posts.AddRange(posts);
            context.SaveChanges();
        }
    }
}
