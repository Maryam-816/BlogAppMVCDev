namespace BlogMVCApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ToAuthorAddedProPic_Description : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Authors", "ProfilePicture", c => c.String());
            AddColumn("dbo.Authors", "Description", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Authors", "Description");
            DropColumn("dbo.Authors", "ProfilePicture");
        }
    }
}
