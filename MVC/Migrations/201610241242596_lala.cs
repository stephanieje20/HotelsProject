namespace MVC.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class lala : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Comments", "DateUpload", c => c.DateTime(nullable: false));
            AddColumn("dbo.Users", "Password", c => c.String());
            DropColumn("dbo.Comments", "Title");
            DropColumn("dbo.Comments", "Name");
            DropColumn("dbo.Comments", "WebSite");
            DropColumn("dbo.Posts", "Name");
            DropColumn("dbo.Posts", "WebSite");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Posts", "WebSite", c => c.String());
            AddColumn("dbo.Posts", "Name", c => c.String());
            AddColumn("dbo.Comments", "WebSite", c => c.String());
            AddColumn("dbo.Comments", "Name", c => c.String());
            AddColumn("dbo.Comments", "Title", c => c.String());
            DropColumn("dbo.Users", "Password");
            DropColumn("dbo.Comments", "DateUpload");
        }
    }
}
