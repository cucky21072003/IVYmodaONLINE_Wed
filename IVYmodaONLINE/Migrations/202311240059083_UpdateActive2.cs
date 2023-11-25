namespace IVYmodaONLINE.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateActive2 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.tb_Post", "Description", c => c.String(maxLength: 550));
            AlterColumn("dbo.tb_Post", "Detail", c => c.String(maxLength: 4000));
            AlterColumn("dbo.tb_Post", "Image", c => c.String(maxLength: 550));
            AlterColumn("dbo.tb_Post", "Seotitle", c => c.String(maxLength: 150));
            AlterColumn("dbo.tb_Post", "SeoDescription", c => c.String(maxLength: 550));
            AlterColumn("dbo.tb_Post", "SeoKeyWords", c => c.String(maxLength: 150));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.tb_Post", "SeoKeyWords", c => c.String());
            AlterColumn("dbo.tb_Post", "SeoDescription", c => c.String());
            AlterColumn("dbo.tb_Post", "Seotitle", c => c.String());
            AlterColumn("dbo.tb_Post", "Image", c => c.String());
            AlterColumn("dbo.tb_Post", "Detail", c => c.String());
            AlterColumn("dbo.tb_Post", "Description", c => c.String());
        }
    }
}
