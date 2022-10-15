namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddCustomerBirthdate : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Customer", "BirthDate", c => c.DateTime());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Customer", "BirthDate");
        }
    }
}
