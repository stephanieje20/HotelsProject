namespace MVC.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class lal : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Posts", "UserID", c => c.Int(nullable: false));
            CreateIndex("dbo.Posts", "UserID");
            AddForeignKey("dbo.Posts", "UserID", "dbo.Users", "ID", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Posts", "UserID", "dbo.Users");
            DropIndex("dbo.Posts", new[] { "UserID" });
            DropColumn("dbo.Posts", "UserID");
        }
    }
}
