namespace MoviesWeb.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class migration5 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.News", "CreatedOn", c => c.DateTime());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.News", "CreatedOn", c => c.DateTime(nullable: false));
        }
    }
}
