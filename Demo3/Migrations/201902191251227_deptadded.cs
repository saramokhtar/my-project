namespace Demo3.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class deptadded : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Departments",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        DeptName = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.AspNetUsers", "DeptNo", c => c.Int(nullable: true));
            CreateIndex("dbo.AspNetUsers", "DeptNo");
            AddForeignKey("dbo.AspNetUsers", "DeptNo", "dbo.Departments", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.AspNetUsers", "DeptNo", "dbo.Departments");
            DropIndex("dbo.AspNetUsers", new[] { "DeptNo" });
            DropColumn("dbo.AspNetUsers", "DeptNo");
            DropTable("dbo.Departments");
        }
    }
}
