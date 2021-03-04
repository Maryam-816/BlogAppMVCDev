namespace BlogMVCApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class GetPaginatableArticlesData_added : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Articles", "ViewCount");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Articles", "ViewCount", c => c.Int(nullable: false));
        }
    }
}
