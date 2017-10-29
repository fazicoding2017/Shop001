namespace HomeAccessories.DataAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddingExtraDetails : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ExtraDetails",
                c => new
                    {
                        ExtraDetailId = c.Int(nullable: false, identity: true),
                        ExtraDetailTitle = c.String(),
                        ExtraDetailDescription = c.String(),
                        ProductId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ExtraDetailId)
                .ForeignKey("dbo.Products", t => t.ProductId, cascadeDelete: true)
                .Index(t => t.ProductId);
            
            AddColumn("dbo.Products", "ProductDescription", c => c.String());
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ExtraDetails", "ProductId", "dbo.Products");
            DropIndex("dbo.ExtraDetails", new[] { "ProductId" });
            DropColumn("dbo.Products", "ProductDescription");
            DropTable("dbo.ExtraDetails");
        }
    }
}
