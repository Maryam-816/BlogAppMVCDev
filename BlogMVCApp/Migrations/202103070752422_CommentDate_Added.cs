namespace BlogMVCApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CommentDate_Added : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Comments", "CommentDate", c => c.DateTime(nullable: false, storeType: "smalldatetime"));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Comments", "CommentDate", c => c.DateTime(nullable: false));
        }
    }
}
