namespace MVC.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Migrate : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Comments", "Photo");
            DropColumn("dbo.Comments", "Video");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Comments", "Video", c => c.String());
            AddColumn("dbo.Comments", "Photo", c => c.String());
        }
    }
}
