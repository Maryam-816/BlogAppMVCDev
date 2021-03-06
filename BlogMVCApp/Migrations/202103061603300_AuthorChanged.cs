namespace BlogMVCApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AuthorChanged : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Authors", "Name", c => c.String());
            AddColumn("dbo.Authors", "Surname", c => c.String());
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.TagModels", "ArticleDetailsModel_Id", "dbo.ArticleDetailsModels");
            DropIndex("dbo.TagModels", new[] { "ArticleDetailsModel_Id" });
            DropColumn("dbo.Authors", "Surname");
            DropColumn("dbo.Authors", "Name");
            DropTable("dbo.TagModels");
            DropTable("dbo.ArticleDetailsModels");
        }
    }
}
