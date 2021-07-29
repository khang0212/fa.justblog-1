namespace FA.JustBlog.Data.Migrations
{
    using FA.JustBlog.Models.Common;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity.Migrations;
    using System.Globalization;
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
                    UrlSlug =   "Gas",
                    Description ="The All-New ASICS GEL-KAYANO® 28 delivers FF Blast™ for a more stable ride and a lower-profile heel to cradle your foot.",
                    IsDeleted = false
                },
                new Category
                {
                    Id = Guid.NewGuid(),
                    Name = "Grizzy",
                    UrlSlug =   "Rules",
                    Description ="The All-New ASICS GEL-KAYANO® 28 delivers FF Blast™ for a more stable ride and a lower-profile heel to cradle your foot.",
                    IsDeleted = false
                },
                new Category
                {
                    Id = Guid.NewGuid(),
                    Name = "Bernwood",
                    UrlSlug =   "Libertadores",
                    Description ="The All-New ASICS GEL-KAYANO® 28 delivers FF Blast™ for a more stable ride and a lower-profile heel to cradle your foot.",
                    IsDeleted = false
                }
            };

            var tag1 = new Tag
            {
                Id = Guid.NewGuid(),
                Name = "Tottenham Hotspur",
                UrlSlug = "travel",
                Description = "Automatically earn a total of 5% back on all Zappos purchases when using your Amazon Rewards Visa Card.*",
                Count = 3,
                IsDeleted = false
            };

            var tag2 = new Tag
            {
                Id = Guid.NewGuid(),
                Name = "Arsenal FC",
                UrlSlug = "Football Club",
                Description = "Automatically earn a total of 5% back on all Zappos purchases when using your Amazon Rewards Visa Card.*",
                Count = 4,
                IsDeleted = false
            };

            var tag3 = new Tag
            {
                Id = Guid.NewGuid(),
                Name = "LOSC Lille",
                UrlSlug = "Restaurant",
                Description = "Automatically earn a total of 5% back on all Zappos purchases when using your Amazon Rewards Visa Card.*",
                Count = 2,
                IsDeleted = false
            };

            var tag4 = new Tag
            {
                Id = Guid.NewGuid(),
                Name = "Inter Milan",
                UrlSlug = "Football Club",
                Description = "Automatically earn a total of 5% back on all Zappos purchases when using your Amazon Rewards Visa Card.*",
                Count = 6,
                IsDeleted = false
            };

            var tag5 = new Tag
            {
                Id = Guid.NewGuid(),
                Name = "AC Milan",
                UrlSlug = "Football Club",
                Description = "Automatically earn a total of 5% back on all Zappos purchases when using your Amazon Rewards Visa Card.*",
                Count = 3,
                IsDeleted = false
            };

            var tag6 = new Tag
            {
                Id = Guid.NewGuid(),
                Name = "Sevilla FC",
                UrlSlug = "Shop",
                Description = "Automatically earn a total of 5% back on all Zappos purchases when using your Amazon Rewards Visa Card.*",
                Count = 4,
                IsDeleted = false
            };

            var tag7 = new Tag
            {
                Id = Guid.NewGuid(),
                Name = "Manchester City",
                UrlSlug = "Football Club",
                Description = "Automatically earn a total of 5% back on all Zappos purchases when using your Amazon Rewards Visa Card.*",
                Count = 8,
                IsDeleted = false
            };

            var tag8 = new Tag
            {
                Id = Guid.NewGuid(),
                Name = "Manchester United",
                UrlSlug = "Football Club",
                Description = "Automatically earn a total of 5% back on all Zappos purchases when using your Amazon Rewards Visa Card.*",
                Count = 6,
                IsDeleted = false
            };

            var tag9 = new Tag
            {
                Id = Guid.NewGuid(),
                Name = "Real Madrid",
                UrlSlug = "Market",
                Description = "Automatically earn a total of 5% back on all Zappos purchases when using your Amazon Rewards Visa Card.*",
                Count = 5,
                IsDeleted = false
            };

            var tag10 = new Tag
            {
                Id = Guid.NewGuid(),
                Name = "AS Monaco",
                UrlSlug = "Turbo",
                Description = "Automatically earn a total of 5% back on all Zappos purchases when using your Amazon Rewards Visa Card.*",
                Count = 2,
                IsDeleted = false
            };

            var tag11 = new Tag
            {
                Id = Guid.NewGuid(),
                Name = "Paris Saint Germain",
                UrlSlug = "Generated",
                Description = "Automatically earn a total of 5% back on all Zappos purchases when using your Amazon Rewards Visa Card.*",
                Count = 4,
                IsDeleted = false
            };

            var tag12 = new Tag
            {
                Id = Guid.NewGuid(),
                Name = "Liverpool FC",
                UrlSlug = "Control",
                Description = "Automatically earn a total of 5% back on all Zappos purchases when using your Amazon Rewards Visa Card.*",
                Count = 5,
                IsDeleted = false
            };

            var tag13 = new Tag
            {
                Id = Guid.NewGuid(),
                Name = "RB Leipzig",
                UrlSlug = "kamaga",
                Description = "Automatically earn a total of 5% back on all Zappos purchases when using your Amazon Rewards Visa Card.*",
                Count = 1,
                IsDeleted = false
            };

            var tag14 = new Tag
            {
                Id = Guid.NewGuid(),
                Name = "Juventus",
                UrlSlug = "Striker",
                Description = "Automatically earn a total of 5% back on all Zappos purchases when using your Amazon Rewards Visa Card.*",
                Count = 6,
                IsDeleted = false
            };

            var tag15 = new Tag
            {
                Id = Guid.NewGuid(),
                Name = "Chelsea",
                UrlSlug = "Full Back",
                Description = "Automatically earn a total of 5% back on all Zappos purchases when using your Amazon Rewards Visa Card.*",
                Count = 7,
                IsDeleted = false
            };
            var posts = new List<Post>
            {
                new Post
                {
                    Id = Guid.NewGuid(),
                    Title = "Post 01",
                    UrlSlug = "post-01",
                    ShortDescription = "At the close of the year, Messi had scored a record 91 goals " +
                    "in all competitions for Barcelona and Argentina. Although FIFA did not acknowledge" +
                    " the achievement, citing verifiability issues, he received the Guinness World Records title" +
                    " for most goals scored in a calendar year. As the odds-on favourite, Messi again" +
                    " won the FIFA Ballon d'Or, becoming the only player in history to win the Ballon d'Or four times.",
                    ImageUrl = "white1.jpg",
                    PostContent = "All Vehicles Prices Exclude Sales Taxes, DMV Lic." +
                    " Fees, Finance Charges if Any, $80 Dealer Document Preparation Charge, " +
                    "Any Emission Testing Charge, Rebates in Lieu of Special Financing, All Vehicles " +
                    "Subject to Prior Sale, Prices Subject to Change. We are not responsible for misprints " +
                    "or errors. Folsom Buick GMC Makes Every Effort to Assure Accurate Information, Should an " +
                    "Error Occur, We will Make Updates Promptly. See Dealer for complete details. EPA Estimates " +
                    "Only No Cooling Off Period on Home Deliveries",
                    PublishedDate = DateTime.ParseExact("2020-02-02", "yyyy-MM-dd", CultureInfo.InvariantCulture),
                    IsDeleted = false,
                    Published = true,
                    ViewCount = 3,
                    Category = categories.Single(x => x.Name == categories[0].Name),
                    Tags = new List<Tag>{tag1, tag2,tag3}
                },
                new Post
                {
                    Id = Guid.NewGuid(),
                    Title = "Post 02",
                    UrlSlug = "post-02",
                    ShortDescription = "At the close of the year, Messi had scored a record 91 goals " +
                    "in all competitions for Barcelona and Argentina. Although FIFA did not acknowledge" +
                    " the achievement, citing verifiability issues, he received the Guinness World Records title" +
                    " for most goals scored in a calendar year. As the odds-on favourite, Messi again" +
                    " won the FIFA Ballon d'Or, becoming the only player in history to win the Ballon d'Or four times.",
                    ImageUrl = "white2.jpg",
                    PostContent = "All Vehicles Prices Exclude Sales Taxes, DMV Lic." +
                    " Fees, Finance Charges if Any, $80 Dealer Document Preparation Charge, " +
                    "Any Emission Testing Charge, Rebates in Lieu of Special Financing, All Vehicles " +
                    "Subject to Prior Sale, Prices Subject to Change. We are not responsible for misprints " +
                    "or errors. Folsom Buick GMC Makes Every Effort to Assure Accurate Information, Should an " +
                    "Error Occur, We will Make Updates Promptly. See Dealer for complete details. EPA Estimates " +
                    "Only No Cooling Off Period on Home Deliveries",
                    PublishedDate = DateTime.ParseExact("2020-03-04", "yyyy-MM-dd", CultureInfo.InvariantCulture),
                    IsDeleted = false,
                    Published = true,
                    ViewCount = 2,
                    Category = categories.Single(x => x.Name == categories[3].Name),
                    Tags = new List<Tag>{tag1, tag4,tag3}
                },
                new Post
                {
                    Id = Guid.NewGuid(),
                    Title = "Post 03",
                    UrlSlug = "post-03",
                    ShortDescription = "At the close of the year, Messi had scored a record 91 goals " +
                    "in all competitions for Barcelona and Argentina. Although FIFA did not acknowledge" +
                    " the achievement, citing verifiability issues, he received the Guinness World Records title" +
                    " for most goals scored in a calendar year. As the odds-on favourite, Messi again" +
                    " won the FIFA Ballon d'Or, becoming the only player in history to win the Ballon d'Or four times.",
                    ImageUrl = "white3.jpg",
                    PostContent = "All Vehicles Prices Exclude Sales Taxes, DMV Lic." +
                    " Fees, Finance Charges if Any, $80 Dealer Document Preparation Charge, " +
                    "Any Emission Testing Charge, Rebates in Lieu of Special Financing, All Vehicles " +
                    "Subject to Prior Sale, Prices Subject to Change. We are not responsible for misprints " +
                    "or errors. Folsom Buick GMC Makes Every Effort to Assure Accurate Information, Should an " +
                    "Error Occur, We will Make Updates Promptly. See Dealer for complete details. EPA Estimates " +
                    "Only No Cooling Off Period on Home Deliveries",
                    PublishedDate = DateTime.ParseExact("2019-04-04", "yyyy-MM-dd", CultureInfo.InvariantCulture),
                    IsDeleted = false,
                    Published = true,
                    ViewCount = 4,
                    Category = categories.Single(x => x.Name == categories[1].Name),
                    Tags = new List<Tag>{tag5, tag2,tag3}
                },
                new Post
                {
                    Id = Guid.NewGuid(),
                    Title = "Post 04",
                    UrlSlug = "post-04",
                    ShortDescription = "At the close of the year, Messi had scored a record 91 goals " +
                    "in all competitions for Barcelona and Argentina. Although FIFA did not acknowledge" +
                    " the achievement, citing verifiability issues, he received the Guinness World Records title" +
                    " for most goals scored in a calendar year. As the odds-on favourite, Messi again" +
                    " won the FIFA Ballon d'Or, becoming the only player in history to win the Ballon d'Or four times.",
                    ImageUrl = "white4.jpg",
                    PostContent = "All Vehicles Prices Exclude Sales Taxes, DMV Lic." +
                    " Fees, Finance Charges if Any, $80 Dealer Document Preparation Charge, " +
                    "Any Emission Testing Charge, Rebates in Lieu of Special Financing, All Vehicles " +
                    "Subject to Prior Sale, Prices Subject to Change. We are not responsible for misprints " +
                    "or errors. Folsom Buick GMC Makes Every Effort to Assure Accurate Information, Should an " +
                    "Error Occur, We will Make Updates Promptly. See Dealer for complete details. EPA Estimates " +
                    "Only No Cooling Off Period on Home Deliveries",
                    PublishedDate = DateTime.ParseExact("2025-02-02", "yyyy-MM-dd", CultureInfo.InvariantCulture),
                    IsDeleted = false,
                    Published = true,
                    ViewCount = 3,
                    Category = categories.Single(x => x.Name == categories[2].Name),
                    Tags = new List<Tag>{tag1, tag5,tag3}
                },
                new Post
                {
                    Id = Guid.NewGuid(),
                    Title = "Post 05",
                    UrlSlug = "post-05",
                    ShortDescription = "At the close of the year, Messi had scored a record 91 goals " +
                    "in all competitions for Barcelona and Argentina. Although FIFA did not acknowledge" +
                    " the achievement, citing verifiability issues, he received the Guinness World Records title" +
                    " for most goals scored in a calendar year. As the odds-on favourite, Messi again" +
                    " won the FIFA Ballon d'Or, becoming the only player in history to win the Ballon d'Or four times.",
                    ImageUrl = "white5.jpeg",
                    PostContent = "All Vehicles Prices Exclude Sales Taxes, DMV Lic." +
                    " Fees, Finance Charges if Any, $80 Dealer Document Preparation Charge, " +
                    "Any Emission Testing Charge, Rebates in Lieu of Special Financing, All Vehicles " +
                    "Subject to Prior Sale, Prices Subject to Change. We are not responsible for misprints " +
                    "or errors. Folsom Buick GMC Makes Every Effort to Assure Accurate Information, Should an " +
                    "Error Occur, We will Make Updates Promptly. See Dealer for complete details. EPA Estimates " +
                    "Only No Cooling Off Period on Home Deliveries",
                    PublishedDate = DateTime.ParseExact("2015-07-07", "yyyy-MM-dd", CultureInfo.InvariantCulture),
                    IsDeleted = false,
                    Published = true,
                    ViewCount = 2,
                    Category = categories.Single(x => x.Name == categories[1].Name),
                    Tags = new List<Tag>{tag2,tag3}
                },
                new Post
                {
                    Id = Guid.NewGuid(),
                    Title = "Post 06",
                    UrlSlug = "post-06",
                    ShortDescription = "At the close of the year, Messi had scored a record 91 goals " +
                    "in all competitions for Barcelona and Argentina. Although FIFA did not acknowledge" +
                    " the achievement, citing verifiability issues, he received the Guinness World Records title" +
                    " for most goals scored in a calendar year. As the odds-on favourite, Messi again" +
                    " won the FIFA Ballon d'Or, becoming the only player in history to win the Ballon d'Or four times.",
                    ImageUrl = "lokonga1.jpeg",
                    PostContent = "All Vehicles Prices Exclude Sales Taxes, DMV Lic." +
                    " Fees, Finance Charges if Any, $80 Dealer Document Preparation Charge, " +
                    "Any Emission Testing Charge, Rebates in Lieu of Special Financing, All Vehicles " +
                    "Subject to Prior Sale, Prices Subject to Change. We are not responsible for misprints " +
                    "or errors. Folsom Buick GMC Makes Every Effort to Assure Accurate Information, Should an " +
                    "Error Occur, We will Make Updates Promptly. See Dealer for complete details. EPA Estimates " +
                    "Only No Cooling Off Period on Home Deliveries",
                    PublishedDate = DateTime.ParseExact("2017-08-08", "yyyy-MM-dd", CultureInfo.InvariantCulture),
                    IsDeleted = false,
                    Published = true,
                    ViewCount = 4,
                    Category = categories.Single(x => x.Name == categories[0].Name),
                    Tags = new List<Tag>{tag6,tag3}
                },
                new Post
                {
                    Id = Guid.NewGuid(),
                    Title = "Post 07",
                    UrlSlug = "post-07",
                    ShortDescription = "At the close of the year, Messi had scored a record 91 goals " +
                    "in all competitions for Barcelona and Argentina. Although FIFA did not acknowledge" +
                    " the achievement, citing verifiability issues, he received the Guinness World Records title" +
                    " for most goals scored in a calendar year. As the odds-on favourite, Messi again" +
                    " won the FIFA Ballon d'Or, becoming the only player in history to win the Ballon d'Or four times.",
                    ImageUrl = "lokonga1.jpeg",
                    PostContent = "All Vehicles Prices Exclude Sales Taxes, DMV Lic." +
                    " Fees, Finance Charges if Any, $80 Dealer Document Preparation Charge, " +
                    "Any Emission Testing Charge, Rebates in Lieu of Special Financing, All Vehicles " +
                    "Subject to Prior Sale, Prices Subject to Change. We are not responsible for misprints " +
                    "or errors. Folsom Buick GMC Makes Every Effort to Assure Accurate Information, Should an " +
                    "Error Occur, We will Make Updates Promptly. See Dealer for complete details. EPA Estimates " +
                    "Only No Cooling Off Period on Home Deliveries",
                    PublishedDate = DateTime.ParseExact("2018-05-05", "yyyy-MM-dd", CultureInfo.InvariantCulture),
                    IsDeleted = false,
                    Published = true,
                    ViewCount = 4,
                    Category = categories.Single(x => x.Name == categories[3].Name),
                    Tags = new List<Tag>{tag6,tag3}
                }
            };
            context.Categories.AddRange(categories);
            context.Posts.AddRange(posts);
            context.SaveChanges();
        }
    }
}
