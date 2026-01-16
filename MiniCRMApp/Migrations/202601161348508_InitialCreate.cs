namespace MiniCRMApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Companies",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                        ContactPerson = c.String(),
                        Phone = c.String(),
                        Email = c.String(),
                        CreatedDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Meetings",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        MeetingDate = c.DateTime(nullable: false),
                        Note = c.String(),
                        MeetingType = c.String(),
                        NextActionDate = c.DateTime(),
                        CompanyId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Companies", t => t.CompanyId, cascadeDelete: true)
                .Index(t => t.CompanyId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Meetings", "CompanyId", "dbo.Companies");
            DropIndex("dbo.Meetings", new[] { "CompanyId" });
            DropTable("dbo.Meetings");
            DropTable("dbo.Companies");
        }
    }
}
