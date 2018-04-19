namespace MyobExercise.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _InitialModel : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Employees",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        FirstName = c.String(nullable: false, maxLength: 55),
                        LastName = c.String(nullable: false, maxLength: 50),
                        AnnualSalary = c.Decimal(nullable: false, precision: 18, scale: 2),
                        SuperRate = c.Decimal(nullable: false, precision: 18, scale: 2),
                        PaymentDateId = c.Guid(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.PaymentDates", t => t.PaymentDateId, cascadeDelete: true)
                .Index(t => t.PaymentDateId);
            
            CreateTable(
                "dbo.PaymentDates",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        MonthName = c.String(),
                        NumberOfDays = c.Int(nullable: false),
                        Description = c.String(),
                        MonthSeqInYear = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Taxes",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        MinimumPay = c.Decimal(nullable: false, precision: 18, scale: 2),
                        MaximumPay = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Rate = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Surplus = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Employees", "PaymentDateId", "dbo.PaymentDates");
            DropIndex("dbo.Employees", new[] { "PaymentDateId" });
            DropTable("dbo.Taxes");
            DropTable("dbo.PaymentDates");
            DropTable("dbo.Employees");
        }
    }
}
