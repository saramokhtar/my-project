namespace Demo3.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class g : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.AspNetUsers", "DeptNo", "dbo.Departments");
            DropIndex("dbo.AspNetUsers", new[] { "DeptNo" });
            AlterColumn("dbo.AspNetUsers", "DeptNo", c => c.Int());
            CreateIndex("dbo.AspNetUsers", "DeptNo");
            AddForeignKey("dbo.AspNetUsers", "DeptNo", "dbo.Departments", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.AspNetUsers", "DeptNo", "dbo.Departments");
            DropIndex("dbo.AspNetUsers", new[] { "DeptNo" });
            AlterColumn("dbo.AspNetUsers", "DeptNo", c => c.Int(nullable: false));
            CreateIndex("dbo.AspNetUsers", "DeptNo");
            AddForeignKey("dbo.AspNetUsers", "DeptNo", "dbo.Departments", "Id", cascadeDelete: true);
        }
    }
}
