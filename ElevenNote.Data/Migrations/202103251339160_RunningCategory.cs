namespace ElevenNote.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RunningCategory : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Category", "Category_CategoryId", "dbo.Category");
            DropIndex("dbo.Category", new[] { "Category_CategoryId" });
            DropColumn("dbo.Category", "Category_CategoryId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Category", "Category_CategoryId", c => c.Int());
            CreateIndex("dbo.Category", "Category_CategoryId");
            AddForeignKey("dbo.Category", "Category_CategoryId", "dbo.Category", "CategoryId");
        }
    }
}
