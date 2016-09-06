namespace SimpleSearch.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreatePersonTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.People",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        FirstName = c.String(nullable: false, maxLength: 255),
                        LastName = c.String(nullable: false, maxLength: 255),
                        Address = c.String(nullable: false),
                        Age = c.Int(nullable: false),
                        Intrest = c.String(),
                        Photo = c.Binary(),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.People");
        }
    }
}
