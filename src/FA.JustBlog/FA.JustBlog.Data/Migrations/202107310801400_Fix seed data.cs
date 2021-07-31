namespace FA.JustBlog.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Fixseeddata : DbMigration
    {
        public override void Up()
        {
            AddColumn("common.Posts", "ViewCount", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("common.Posts", "ViewCount");
        }
    }
}
