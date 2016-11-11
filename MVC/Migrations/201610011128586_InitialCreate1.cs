namespace MVC.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate1 : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.Fans", newName: "Users");
            CreateTable(
                "dbo.Hotels",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Street = c.String(),
                        StreetNumber = c.Int(nullable: false),
                        City = c.String(),
                        State = c.String(),
                        Contents = c.String(),
                        Photo = c.String(),
                        Video = c.String(),
                        Stars = c.Int(nullable: false),
                        Rate = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            AddColumn("dbo.Posts", "HotelID", c => c.Int(nullable: false));
            CreateIndex("dbo.Posts", "HotelID");
            AddForeignKey("dbo.Posts", "HotelID", "dbo.Hotels", "ID", cascadeDelete: true);
            DropColumn("dbo.Users", "Seniority");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Users", "Seniority", c => c.Int(nullable: false));
            DropForeignKey("dbo.Posts", "HotelID", "dbo.Hotels");
            DropIndex("dbo.Posts", new[] { "HotelID" });
            DropColumn("dbo.Posts", "HotelID");
            DropTable("dbo.Hotels");
            RenameTable(name: "dbo.Users", newName: "Fans");
        }
    }
}
