namespace BlogMVCApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CategoryUpdated_ArticlesAdded : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Categories", "Article_Id", "dbo.Articles");
            DropIndex("dbo.Categories", new[] { "Article_Id" });
            CreateTable(
                "dbo.CategoryArticles",
                c => new
                    {
                        Category_Id = c.Int(nullable: false),
                        Article_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Category_Id, t.Article_Id })
                .ForeignKey("dbo.Categories", t => t.Category_Id, cascadeDelete: true)
                .ForeignKey("dbo.Articles", t => t.Article_Id, cascadeDelete: true)
                .Index(t => t.Category_Id)
                .Index(t => t.Article_Id);
            
            DropColumn("dbo.Categories", "Article_Id");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Categories", "Article_Id", c => c.Int());
            DropForeignKey("dbo.CategoryArticles", "Article_Id", "dbo.Articles");
            DropForeignKey("dbo.CategoryArticles", "Category_Id", "dbo.Categories");
            DropIndex("dbo.CategoryArticles", new[] { "Article_Id" });
            DropIndex("dbo.CategoryArticles", new[] { "Category_Id" });
            DropTable("dbo.CategoryArticles");
            CreateIndex("dbo.Categories", "Article_Id");
            AddForeignKey("dbo.Categories", "Article_Id", "dbo.Articles", "Id");
        }
    }
}
