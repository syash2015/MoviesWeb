namespace MoviesWeb.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class migration3 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.CriticsReviews",
                c => new
                    {
                        ReviewId = c.Int(nullable: false, identity: true),
                        CriticName = c.String(),
                        Rating = c.String(),
                        SourceName = c.String(),
                        SourceURL = c.String(),
                        ShortReview = c.String(),
                        FullReview = c.String(),
                    })
                .PrimaryKey(t => t.ReviewId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.CriticsReviews");
        }
    }
}
