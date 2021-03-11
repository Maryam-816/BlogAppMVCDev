namespace BlogMVCApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Comment_User_Updated : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Users", "ProfilePicture", c => c.String());
            AddColumn("dbo.Comments", "Email", c => c.String(nullable: false, maxLength: 50));
            AddColumn("dbo.Comments", "WebSite", c => c.String());
            AlterColumn("dbo.Comments", "Text", c => c.String(nullable: false, maxLength: 1000));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Comments", "Text", c => c.String(nullable: false, maxLength: 100));
            DropColumn("dbo.Comments", "WebSite");
            DropColumn("dbo.Comments", "Email");
            DropColumn("dbo.Users", "ProfilePicture");
        }
    }
}
