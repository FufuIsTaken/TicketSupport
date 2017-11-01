namespace TicketSupport.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class BLEHE : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Tickets", "Customer_Id", c => c.String(maxLength: 128));
            CreateIndex("dbo.Tickets", "Customer_Id");
            AddForeignKey("dbo.Tickets", "Customer_Id", "dbo.AspNetUsers", "Id");
            DropColumn("dbo.Tickets", "Customer");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Tickets", "Customer", c => c.String());
            DropForeignKey("dbo.Tickets", "Customer_Id", "dbo.AspNetUsers");
            DropIndex("dbo.Tickets", new[] { "Customer_Id" });
            DropColumn("dbo.Tickets", "Customer_Id");
        }
    }
}
