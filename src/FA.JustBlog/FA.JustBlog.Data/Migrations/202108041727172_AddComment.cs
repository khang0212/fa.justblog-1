namespace FA.JustBlog.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddComment : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "common.Comments",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        Name = c.String(nullable: false, maxLength: 255),
                        Email = c.String(nullable: false, maxLength: 255),
                        CommentHeader = c.String(nullable: false, maxLength: 255),
                        CommentText = c.String(nullable: false, maxLength: 255),
                        CommentTime = c.DateTime(nullable: false),
                        PostId = c.Guid(nullable: false),
                        IsDeleted = c.Boolean(nullable: false),
                        InsertedAt = c.DateTime(nullable: false),
                        UpdatedAt = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("common.Posts", t => t.PostId, cascadeDelete: true)
                .Index(t => t.PostId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("common.Comments", "PostId", "common.Posts");
            DropIndex("common.Comments", new[] { "PostId" });
            DropTable("common.Comments");
        }
    }
}
