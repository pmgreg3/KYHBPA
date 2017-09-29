namespace KYHBPA.Web.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedPropertyToImageTable : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Images", "InImageGallery", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Images", "InImageGallery");
        }
    }
}
