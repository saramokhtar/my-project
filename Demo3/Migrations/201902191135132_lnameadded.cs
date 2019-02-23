namespace Demo3.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class lnameadded : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.AspNetUsers", "Lname", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.AspNetUsers", "Lname");
        }
    }
}
