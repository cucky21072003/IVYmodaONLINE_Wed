namespace IVYmodaONLINE.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateActive1 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.tb_Post", "Category_Id", "dbo.tb_Category");
            DropIndex("dbo.tb_Post", new[] { "Category_Id" });
            DropColumn("dbo.tb_Post", "CategoryId");
            RenameColumn(table: "dbo.tb_Post", name: "Category_Id", newName: "CategoryId");
            AlterColumn("dbo.tb_Post", "CategoryId", c => c.Int(nullable: false));
            AlterColumn("dbo.tb_Post", "Seotitle", c => c.String());
            AlterColumn("dbo.tb_Post", "SeoDescription", c => c.String());
            AlterColumn("dbo.tb_Post", "SeoKeyWords", c => c.String());
            AlterColumn("dbo.tb_Post", "CategoryId", c => c.Int(nullable: false));
            AlterColumn("dbo.tb_ProductCategory", "Seotitle", c => c.String());
            AlterColumn("dbo.tb_ProductCategory", "SeoDescription", c => c.String());
            AlterColumn("dbo.tb_ProductCategory", "SeoKeyWords", c => c.String());
            AlterColumn("dbo.tb_ProductCategory", "Position", c => c.String());
            CreateIndex("dbo.tb_Post", "CategoryId");
            AddForeignKey("dbo.tb_Post", "CategoryId", "dbo.tb_Category", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.tb_Post", "CategoryId", "dbo.tb_Category");
            DropIndex("dbo.tb_Post", new[] { "CategoryId" });
            AlterColumn("dbo.tb_ProductCategory", "Position", c => c.Int(nullable: false));
            AlterColumn("dbo.tb_ProductCategory", "SeoKeyWords", c => c.Int(nullable: false));
            AlterColumn("dbo.tb_ProductCategory", "SeoDescription", c => c.Int(nullable: false));
            AlterColumn("dbo.tb_ProductCategory", "Seotitle", c => c.Int(nullable: false));
            AlterColumn("dbo.tb_Post", "CategoryId", c => c.Int());
            AlterColumn("dbo.tb_Post", "SeoKeyWords", c => c.Int(nullable: false));
            AlterColumn("dbo.tb_Post", "SeoDescription", c => c.Int(nullable: false));
            AlterColumn("dbo.tb_Post", "Seotitle", c => c.Int(nullable: false));
            AlterColumn("dbo.tb_Post", "CategoryId", c => c.String());
            RenameColumn(table: "dbo.tb_Post", name: "CategoryId", newName: "Category_Id");
            AddColumn("dbo.tb_Post", "CategoryId", c => c.String());
            CreateIndex("dbo.tb_Post", "Category_Id");
            AddForeignKey("dbo.tb_Post", "Category_Id", "dbo.tb_Category", "Id");
        }
    }
}
