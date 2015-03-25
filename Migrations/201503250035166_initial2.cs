namespace StudentExample.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initial2 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.HotDogProfiles", "Favorite_Meat", c => c.String());
            AddColumn("dbo.HotDogProfiles", "Favorite_Bun", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.HotDogProfiles", "Favorite_Bun");
            DropColumn("dbo.HotDogProfiles", "Favorite_Meat");
        }
    }
}
