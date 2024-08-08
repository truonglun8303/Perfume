namespace ShopNuocHoa.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updtableImageBanner : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.tb_Product", "ImageBanner", c => c.String(maxLength: 250));
        }
        
        public override void Down()
        {
            DropColumn("dbo.tb_Product", "ImageBanner");
        }
    }
}
