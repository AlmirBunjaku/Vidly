namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddMovieDetailsAndGenre : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Genre",
                c => new
                    {
                        Id = c.Byte(nullable: false),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.Movie", "ReleaseDate", c => c.DateTime(nullable: false));
            AddColumn("dbo.Movie", "DateAdded", c => c.DateTime(nullable: false));
            AddColumn("dbo.Movie", "NumberInStock", c => c.Byte(nullable: false));
            AddColumn("dbo.Movie", "GenreId", c => c.Byte(nullable: false));
            CreateIndex("dbo.Movie", "GenreId");
            AddForeignKey("dbo.Movie", "GenreId", "dbo.Genre", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Movie", "GenreId", "dbo.Genre");
            DropIndex("dbo.Movie", new[] { "GenreId" });
            DropColumn("dbo.Movie", "GenreId");
            DropColumn("dbo.Movie", "NumberInStock");
            DropColumn("dbo.Movie", "DateAdded");
            DropColumn("dbo.Movie", "ReleaseDate");
            DropTable("dbo.Genre");
        }
    }
}
