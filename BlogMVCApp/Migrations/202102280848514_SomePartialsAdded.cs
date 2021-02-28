namespace BlogMVCApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SomePartialsAdded : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Articles", "ViewCount", c => c.Int(nullable: false));
            AlterColumn("dbo.Articles", "Title", c => c.String(nullable: false, maxLength: 80));
            DropColumn("dbo.Articles", "AuthorName");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Articles", "AuthorName", c => c.String(nullable: false, maxLength: 30));
            AlterColumn("dbo.Articles", "Title", c => c.String(nullable: false, maxLength: 100));
            DropColumn("dbo.Articles", "ViewCount");
        }
    }
}
