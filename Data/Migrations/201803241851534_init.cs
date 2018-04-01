namespace Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class init : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Users",
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
                        Email_email = c.String(),
                        SchoolLevel = c.String(),
                        Office = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Users");
        }
    }
}
