namespace TicketSupport.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class gvdf : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Tickets",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Customer = c.String(),
                        Application = c.String(),
                        Subject = c.String(),
                        Description = c.String(),
                        Date = c.DateTime(nullable: false),
                        Status = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Tickets");
        }
    }
}
