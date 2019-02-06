namespace RevisaoApp.Repository.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateInitial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Usuario",
                c => new
                    {
                        Codigo = c.Long(nullable: false, identity: true),
                        Nome = c.String(nullable: false, maxLength: 255),
                    })
                .PrimaryKey(t => t.Codigo);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Usuario");
        }
    }
}
