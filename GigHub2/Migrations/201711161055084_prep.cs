namespace GigHub2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class prep : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT into Genres (Id, Name) VALUES (1, 'JAZZ')");
            Sql("INSERT into Genres (Id, Name) VALUES (2, 'BLUES')");
            Sql("INSERT into Genres (Id, Name) VALUES (3, 'PUNK')");
            Sql("INSERT into Genres (Id, Name) VALUES (4, 'COUNTRY')");
            Sql("INSERT into Genres (Id, Name) VALUES (5, 'ROCK')");
        }
        
        public override void Down()
        {
            Sql("DELETE from Genres WHERE Id IN (1,2,3,4)");
        }
    }
}
