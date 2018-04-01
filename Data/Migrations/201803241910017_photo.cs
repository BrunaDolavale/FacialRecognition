namespace Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class photo : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.User1", "Email", c => c.String());
            DropColumn("dbo.User", "Email");
        }
        
        public override void Down()
        {
            AddColumn("dbo.User", "Email", c => c.String());
            DropColumn("dbo.User1", "Email");
        }
    }
}
