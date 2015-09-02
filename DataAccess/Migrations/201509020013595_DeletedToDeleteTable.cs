namespace DataAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DeletedToDeleteTable : DbMigration
    {
        public override void Up()
        {
            DropTable("dbo.OkayToDelete");
        }
        
        public override void Down()
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
    }
}
