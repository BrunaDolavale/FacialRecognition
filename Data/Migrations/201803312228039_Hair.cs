namespace Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Hair : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.User", newName: "Users");
            CreateTable(
                "dbo.PhotoProfiles",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        Url = c.String(),
                        HairColor = c.Int(nullable: false),
                        HairStyle = c.Int(nullable: false),
                        HairLength = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.Users", "FirstName", c => c.String());
            AddColumn("dbo.Users", "LastName", c => c.String());
            AddColumn("dbo.Users", "Birth", c => c.DateTime(nullable: false));
            AddColumn("dbo.Users", "Gender", c => c.String());
            AddColumn("dbo.Users", "Sexuality", c => c.String());
            AddColumn("dbo.Users", "Description", c => c.String());
            AddColumn("dbo.Users", "CellphoneNumber", c => c.String());
            AddColumn("dbo.Users", "Email", c => c.String());
            AddColumn("dbo.Users", "SchoolLevel", c => c.String());
            AddColumn("dbo.Users", "Office", c => c.String());
            AddColumn("dbo.Users", "PhotoProfile_Id", c => c.Guid());
            CreateIndex("dbo.Users", "PhotoProfile_Id");
            AddForeignKey("dbo.Users", "PhotoProfile_Id", "dbo.PhotoProfiles", "Id");
            DropColumn("dbo.Users", "PhotoUrl");
            DropTable("dbo.User1");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.User1",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        FirstName = c.String(),
                        LastName = c.String(),
                        Birth = c.DateTime(nullable: false),
                        Gender = c.String(),
                        Sexuality = c.String(),
                        Description = c.String(),
                        CellphoneNumber = c.String(),
                        Email = c.String(),
                        SchoolLevel = c.String(),
                        Office = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.Users", "PhotoUrl", c => c.String());
            DropForeignKey("dbo.Users", "PhotoProfile_Id", "dbo.PhotoProfiles");
            DropIndex("dbo.Users", new[] { "PhotoProfile_Id" });
            DropColumn("dbo.Users", "PhotoProfile_Id");
            DropColumn("dbo.Users", "Office");
            DropColumn("dbo.Users", "SchoolLevel");
            DropColumn("dbo.Users", "Email");
            DropColumn("dbo.Users", "CellphoneNumber");
            DropColumn("dbo.Users", "Description");
            DropColumn("dbo.Users", "Sexuality");
            DropColumn("dbo.Users", "Gender");
            DropColumn("dbo.Users", "Birth");
            DropColumn("dbo.Users", "LastName");
            DropColumn("dbo.Users", "FirstName");
            DropTable("dbo.PhotoProfiles");
            RenameTable(name: "dbo.Users", newName: "User");
        }
    }
}
