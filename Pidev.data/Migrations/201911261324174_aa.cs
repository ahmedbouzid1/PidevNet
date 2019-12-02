namespace Pidev.data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class aa : DbMigration
    {
        public override void Up()
        {
          /*  CreateTable(
                "dbo.commentaire",
                c => new
                    {
                        id = c.Long(nullable: false, identity: true),
                        dateCreation = c.DateTime(precision: 0),
                        description = c.String(maxLength: 255, unicode: false),
                        id_pub = c.Long(),
                        id_user = c.Int(),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.publication", t => t.id_pub)
                .ForeignKey("dbo.user", t => t.id_user)
                .Index(t => t.id_pub)
                .Index(t => t.id_user);
            
            CreateTable(
                "dbo.publication",
                c => new
                    {
                        id = c.Long(nullable: false, identity: true),
                        dateCreation = c.DateTime(precision: 0),
                        description = c.String(maxLength: 255, unicode: false),
                        user = c.Int(),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.user", t => t.user)
                .Index(t => t.user);
            
            CreateTable(
                "dbo.user",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        addresse = c.String(maxLength: 255, unicode: false),
                        cin = c.String(maxLength: 255, unicode: false),
                        dat_naiss = c.DateTime(precision: 0),
                        email = c.String(maxLength: 255, unicode: false),
                        login = c.String(maxLength: 255, unicode: false),
                        nom = c.String(maxLength: 255, unicode: false),
                        password = c.String(maxLength: 255, unicode: false),
                        prenom = c.String(maxLength: 255, unicode: false),
                        role = c.Int(),
                        contrat_id = c.Int(),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.contrat", t => t.contrat_id)
                .Index(t => t.contrat_id);
            
            CreateTable(
                "dbo.contrat",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        dateDebutC = c.String(maxLength: 255, unicode: false),
                        dateFinC = c.String(maxLength: 255, unicode: false),
                        salaire = c.Int(nullable: false),
                        typeContrat = c.Int(),
                        user_id = c.Int(),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.user", t => t.user_id)
                .Index(t => t.user_id);*/
            
        }
        
        public override void Down()
        {
            /*DropForeignKey("dbo.publication", "user", "dbo.user");
            DropForeignKey("dbo.contrat", "user_id", "dbo.user");
            DropForeignKey("dbo.user", "contrat_id", "dbo.contrat");
            DropForeignKey("dbo.commentaire", "id_user", "dbo.user");
            DropForeignKey("dbo.commentaire", "id_pub", "dbo.publication");
            DropIndex("dbo.contrat", new[] { "user_id" });
            DropIndex("dbo.user", new[] { "contrat_id" });
            DropIndex("dbo.publication", new[] { "user" });
            DropIndex("dbo.commentaire", new[] { "id_user" });
            DropIndex("dbo.commentaire", new[] { "id_pub" });
            DropTable("dbo.contrat");
            DropTable("dbo.user");
            DropTable("dbo.publication");
            DropTable("dbo.commentaire");*/
        }
    }
}
