namespace BlogMVCApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CommentUpdated_UserImage_ArticleId : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Comments", "Name", c => c.String(nullable: false, maxLength: 80));
            AddColumn("dbo.Comments", "UserImage", c => c.String());
            AlterColumn("dbo.Comments", "CommentDate", c => c.DateTime(nullable: false, storeType: "smalldatetime"));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Comments", "CommentDate", c => c.DateTime(nullable: false));
            DropColumn("dbo.Comments", "UserImage");
            DropColumn("dbo.Comments", "Name");
        }
    }
}
