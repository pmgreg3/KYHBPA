namespace KYHBPA.Web.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateMemberTable : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Members", "FirstName", c => c.String());
            AddColumn("dbo.Members", "LastName", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Members", "LastName");
            DropColumn("dbo.Members", "FirstName");
        }
    }
}
