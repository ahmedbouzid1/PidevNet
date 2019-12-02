namespace Pidev.data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class aaaaa : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.user", "role", c => c.String(maxLength: 255, storeType: "nvarchar"));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.user", "role", c => c.Int());
        }
    }
}
