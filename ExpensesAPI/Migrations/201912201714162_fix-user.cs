namespace ExpensesAPI.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class fixuser : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Users", "UserName", c => c.String());
            AlterColumn("dbo.Users", "Password", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Users", "Password", c => c.Int(nullable: false));
            AlterColumn("dbo.Users", "UserName", c => c.Int(nullable: false));
        }
    }
}
