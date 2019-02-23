namespace Demo3.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class fnameadded : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.AspNetUsers", "Fname", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.AspNetUsers", "Fname");
        }
    }
}
