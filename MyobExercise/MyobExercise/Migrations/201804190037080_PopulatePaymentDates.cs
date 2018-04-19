namespace MyobExercise.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulatePaymentDates : DbMigration
    {
        public override void Up()
        {

            Sql("INSERT INTO PaymentDates (Id, MonthName, NumberOfDays, MonthSeqInYear, Description) VALUES ('2C5473E9-276C-4204-9DD4-6FDE1238C89D', 'January', 31, 1, '01 Januray to 31 January')");
            Sql("INSERT INTO PaymentDates (Id, MonthName, NumberOfDays, MonthSeqInYear, Description) VALUES ('A8633502-961C-4CE5-8F6B-D0C5F069F7E6', 'February', 28, 2, '01 February to 28 February')");
            Sql("INSERT INTO PaymentDates (Id, MonthName, NumberOfDays, MonthSeqInYear, Description) VALUES ('DF929BE5-8AF5-449A-9C0E-C6014B6894E7', 'March', 31, 3, '01 March to 31 March')");
            Sql("INSERT INTO PaymentDates (Id, MonthName, NumberOfDays, MonthSeqInYear, Description) VALUES ('AB483398-D570-4974-8D60-AA1534CA32E4', 'April', 30, 4, '01 April to 30 April')");
            Sql("INSERT INTO PaymentDates (Id, MonthName, NumberOfDays, MonthSeqInYear, Description) VALUES ('DD12D9A2-57C6-4230-B017-EAB0921E1522', 'May', 31, 5, '01 May to 31 May')");
            Sql("INSERT INTO PaymentDates (Id, MonthName, NumberOfDays, MonthSeqInYear, Description) VALUES ('0D1F37DE-42C6-4072-8413-D36C7D748E50', 'June', 30, 6, '01 June to 30 June')");
            Sql("INSERT INTO PaymentDates (Id, MonthName, NumberOfDays, MonthSeqInYear, Description) VALUES ('0204727F-AC6E-4048-BEDB-4BB51CFC28A8', 'July', 31, 7, '01 July to 31 July')");
            Sql("INSERT INTO PaymentDates (Id, MonthName, NumberOfDays, MonthSeqInYear, Description) VALUES ('B0F08DA2-A8AA-4DFC-BC13-0B944D226DAB', 'August', 31, 8, '01 August to 31 August')");
            Sql("INSERT INTO PaymentDates (Id, MonthName, NumberOfDays, MonthSeqInYear, Description) VALUES ('9BA25BFE-8755-4C3B-A937-0546D44F7E2E', 'September', 30, 9,'01 September to 30 September')");
            Sql("INSERT INTO PaymentDates (Id, MonthName, NumberOfDays, MonthSeqInYear, Description) VALUES ('71DFC804-1F03-4A3E-B979-457D4142D480', 'October', 31, 10, '01 October to 31 October')");
            Sql("INSERT INTO PaymentDates (Id, MonthName, NumberOfDays, MonthSeqInYear, Description) VALUES ('BED25393-F18D-46A6-9796-71D8E60E7A5A', 'November', 30, 11, '01 November to 30 November')");
            Sql("INSERT INTO PaymentDates (Id, MonthName, NumberOfDays, MonthSeqInYear, Description) VALUES ('331B5E78-CB37-457B-80F5-873B2ECAF244', 'December', 31, 12, '01 December to 31 December')");

        }
        
        public override void Down()
        {
        }
    }
}
