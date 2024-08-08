namespace ShopNuocHoa.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class upproductcategory : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.tb_ProductCategory", "ImageBanner", c => c.String(maxLength: 150));
        }
        
        public override void Down()
        {
            DropColumn("dbo.tb_ProductCategory", "ImageBanner");
        }
    }
}
