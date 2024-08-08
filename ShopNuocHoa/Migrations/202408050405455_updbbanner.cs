namespace ShopNuocHoa.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updbbanner : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.tb_Banner",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Title = c.String(nullable: false, maxLength: 150),
                        Description = c.String(),
                        Image = c.String(),
                        CreatedBy = c.String(),
                        CreatedDate = c.DateTime(nullable: false),
                        ModifiedDate = c.DateTime(nullable: false),
                        Modifiedby = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.tb_Banner");
        }
    }
}
