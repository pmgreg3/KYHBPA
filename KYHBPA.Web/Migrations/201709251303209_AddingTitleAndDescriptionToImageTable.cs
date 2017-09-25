namespace KYHBPA.Web.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddingTitleAndDescriptionToImageTable : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Images", "Title", c => c.String());
            AddColumn("dbo.Images", "Description", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Images", "Description");
            DropColumn("dbo.Images", "Title");
        }
    }
}
