namespace Pomoceo.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class offerUserIdTypeEdit : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Offers", "UserID", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Offers", "UserID", c => c.Int(nullable: false));
        }
    }
}
