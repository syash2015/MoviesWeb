namespace MoviesWeb.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class migration7 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Movies", "CreatedBy", c => c.String());
            AddColumn("dbo.Movies", "CreatedOn", c => c.DateTime());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Movies", "CreatedOn");
            DropColumn("dbo.Movies", "CreatedBy");
        }
    }
}
