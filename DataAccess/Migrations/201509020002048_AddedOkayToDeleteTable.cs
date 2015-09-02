namespace DataAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedOkayToDeleteTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.OkayToDelete",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        SomeColumn = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.OkayToDelete");
        }
    }
}
