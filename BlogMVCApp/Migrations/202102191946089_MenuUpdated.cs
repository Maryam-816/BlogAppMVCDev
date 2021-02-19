namespace BlogMVCApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class MenuUpdated : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Menus", "IsActive", c => c.Boolean(nullable: false));
            AddColumn("dbo.Menus", "ControllerName", c => c.String(nullable: false));
            AddColumn("dbo.Menus", "Order", c => c.Byte(nullable: false));
            AddColumn("dbo.Menus", "ActionName", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Menus", "ActionName");
            DropColumn("dbo.Menus", "Order");
            DropColumn("dbo.Menus", "ControllerName");
            DropColumn("dbo.Menus", "IsActive");
        }
    }
}
