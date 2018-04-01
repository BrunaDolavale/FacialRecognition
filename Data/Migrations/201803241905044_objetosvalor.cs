namespace Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class objetosvalor : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.Users", newName: "User");
            RenameColumn(table: "dbo.User", name: "Email_email", newName: "Email");
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
                        SchoolLevel = c.String(),
                        Office = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.User", "PhotoUrl", c => c.String());
            DropColumn("dbo.User", "FirstName");
            DropColumn("dbo.User", "LastName");
            DropColumn("dbo.User", "Birth");
            DropColumn("dbo.User", "Gender");
            DropColumn("dbo.User", "Sexuality");
            DropColumn("dbo.User", "Description");
            DropColumn("dbo.User", "CellphoneNumber");
            DropColumn("dbo.User", "SchoolLevel");
            DropColumn("dbo.User", "Office");
        }
        
        public override void Down()
        {
            AddColumn("dbo.User", "Office", c => c.String());
            AddColumn("dbo.User", "SchoolLevel", c => c.String());
            AddColumn("dbo.User", "CellphoneNumber", c => c.String());
            AddColumn("dbo.User", "Description", c => c.String());
            AddColumn("dbo.User", "Sexuality", c => c.String());
            AddColumn("dbo.User", "Gender", c => c.String());
            AddColumn("dbo.User", "Birth", c => c.DateTime(nullable: false));
            AddColumn("dbo.User", "LastName", c => c.String());
            AddColumn("dbo.User", "FirstName", c => c.String());
            DropColumn("dbo.User", "PhotoUrl");
            DropTable("dbo.User1");
            RenameColumn(table: "dbo.User", name: "Email", newName: "Email_email");
            RenameTable(name: "dbo.User", newName: "Users");
        }
    }
}
