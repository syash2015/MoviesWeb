namespace MoviesWeb.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class migration41 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.News", "Image", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.News", "Image");
        }
    }
}
