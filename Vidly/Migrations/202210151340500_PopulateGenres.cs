namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    using System.Web.Mvc.Ajax;

    public partial class PopulateGenres : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Genre (Id, Name) VALUES (1, 'Comedy')");
            Sql("INSERT INTO Genre (Id, Name) VALUES (2, 'Action')");
            Sql("INSERT INTO Genre (Id, Name) VALUES (3, 'Family')");
            Sql("INSERT INTO Genre (Id, Name) VALUES (4, 'Romance')");

            Sql("INSERT INTO Movie (Name, ReleaseDate, DateAdded, NumberInStock, GenreId) VALUES ('The Hangover', '2009-07-05', getdate(), 35, 1)");
            Sql("INSERT INTO Movie (Name, ReleaseDate, DateAdded, NumberInStock, GenreId) VALUES ('Die Hard', '1988-07-15', getdate(), 25, 2)");
            Sql("INSERT INTO Movie (Name, ReleaseDate, DateAdded, NumberInStock, GenreId) VALUES ('The Terminator', '1984-10-26', getdate(), 6, 2)");
            Sql("INSERT INTO Movie (Name, ReleaseDate, DateAdded, NumberInStock, GenreId) VALUES ('Toy Story', '1995-11-19', getdate(), 30, 3)");
            Sql("INSERT INTO Movie (Name, ReleaseDate, DateAdded, NumberInStock, GenreId) VALUES ('The Hangover', '1997-12-19', getdate(), 200, 4)");
        }
        
        public override void Down()
        {
        }
    }
}
