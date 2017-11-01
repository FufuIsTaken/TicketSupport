namespace TicketSupport.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class bleh : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Tickets", "Status", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Tickets", "Status", c => c.String());
        }
    }
}
