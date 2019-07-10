namespace Point_of_Sale_System.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangingDoubleToDecimal2 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.SalesLists", "TotalAmount", c => c.Decimal(nullable: false, precision: 18, scale: 2));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.SalesLists", "TotalAmount", c => c.Double(nullable: false));
        }
    }
}
