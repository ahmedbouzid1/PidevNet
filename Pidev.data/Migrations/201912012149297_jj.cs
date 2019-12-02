namespace Pidev.data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class jj : DbMigration
    {
        public override void Up()
        {
            MoveTable(name: "dbo.commentaire", newSchema: "pidev");
            MoveTable(name: "dbo.publication", newSchema: "pidev");
            MoveTable(name: "dbo.user", newSchema: "pidev");
            MoveTable(name: "dbo.contrat", newSchema: "pidev");
            CreateTable(
                "pidev.__migrationhistory",
                c => new
                    {
                        MigrationId = c.String(nullable: false, maxLength: 150, unicode: false),
                        ContextKey = c.String(nullable: false, maxLength: 300, unicode: false),
                        Model = c.Binary(nullable: false),
                        ProductVersion = c.String(nullable: false, maxLength: 32, unicode: false),
                    })
                .PrimaryKey(t => new { t.MigrationId, t.ContextKey });
            
            AddColumn("pidev.user", "image", c => c.String(maxLength: 255, unicode: false));
            AlterColumn("pidev.user", "role", c => c.String(maxLength: 255, unicode: false));
        }
        
        public override void Down()
        {
            AlterColumn("pidev.user", "role", c => c.String(maxLength: 255, storeType: "nvarchar"));
            DropColumn("pidev.user", "image");
            DropTable("pidev.__migrationhistory");
            MoveTable(name: "pidev.contrat", newSchema: "dbo");
            MoveTable(name: "pidev.user", newSchema: "dbo");
            MoveTable(name: "pidev.publication", newSchema: "dbo");
            MoveTable(name: "pidev.commentaire", newSchema: "dbo");
        }
    }
}
