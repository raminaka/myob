namespace MyobExercise.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateTaxes : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Taxes (Id, MinimumPay, MaximumPay, Rate, Surplus) VALUES ('2C5473E9-276C-4204-9DD4-6FDE1238C89D', 0, 18200, 0, 0)");
            Sql("INSERT INTO Taxes (Id, MinimumPay, MaximumPay, Rate, Surplus) VALUES ('C70FC633-9331-4ACD-94EC-2D4353818894', 18201, 37000, 0, 0.19)");
            Sql("INSERT INTO Taxes (Id, MinimumPay, MaximumPay, Rate, Surplus) VALUES ('5FD8F06B-9E5B-439F-B48A-4F34AA1739EB', 37001, 87000, 3572, 0.325)");
            Sql("INSERT INTO Taxes (Id, MinimumPay, MaximumPay, Rate, Surplus) VALUES ('E636010A-90F6-4B42-9570-1FA6BCC3B31E', 87001, 180000, 19822, 0.37)");
            Sql("INSERT INTO Taxes (Id, MinimumPay, MaximumPay, Rate, Surplus) VALUES ('875DD98F-3825-4F44-B07F-D779236E9EC8', 180001, 0, 54232, 0.45)");
        }

        public override void Down()
        {
        }
    }
}
