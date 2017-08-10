namespace MoviesWeb.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class migration6 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Posts",
                c => new
                    {
                        PostId = c.Int(nullable: false, identity: true),
                        Title = c.String(),
                        Description = c.String(),
                        Date = c.String(),
                        Source = c.String(),
                        ShortDesc = c.String(),
                        CreatedOn = c.DateTime(),
                        Image = c.String(),
                        CreatedBy = c.String(),
                    })
                .PrimaryKey(t => t.PostId);
            
            AddColumn("dbo.CriticsReviews", "MovieId", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.CriticsReviews", "MovieId");
            DropTable("dbo.Posts");
        }
    }
}
