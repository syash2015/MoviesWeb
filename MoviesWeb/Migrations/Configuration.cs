namespace MoviesWeb.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using MoviesWeb.Models;

    internal sealed class Configuration : DbMigrationsConfiguration<MoviesWeb.Models.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(MoviesWeb.Models.ApplicationDbContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            context.Movies.AddOrUpdate(
              p => p.MName,
               new Movies
               {
                   MName = "Ae Dil Hai Mushkil",
                   MDuration = "2 hrs 10 min",
                   ReleaseDate = DateTime.Parse("2016-09-14"),
                   Genre = "Romance",
                   Cast = "Ranbir Kapoor, Aishwarya Rai, Anushka Sharma",
                   Direcotr = "KaranJohar",
               }
            );
            

        }
    }
}
