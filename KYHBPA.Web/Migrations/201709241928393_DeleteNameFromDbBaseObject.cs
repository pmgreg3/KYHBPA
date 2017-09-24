namespace KYHBPA.Web.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DeleteNameFromDbBaseObject : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Reports", "Name");
            DropColumn("dbo.Members", "Name");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Members", "Name", c => c.String());
            AddColumn("dbo.Reports", "Name", c => c.String());
        }
    }
}
