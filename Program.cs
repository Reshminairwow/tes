using System;

namespace tes
{
    class Program
    {
        static void Main(string[] args)
        {
            SellExpense sellexp = new SellExpense();
            sellexp.salePriceNow = 720000;
            sellexp.salesCostPercent = 3 / 100;
            SellInvestment invest = new SellInvestment();
            invest.roiPercentage = 12 / 100;
            OwnExpenses ownexp = new OwnExpenses();
            ownexp.propMaintanance = 416.66;
            ownexp.waterRates = 83.33;
            ownexp.councilTax = 150;
            ownexp.insurance = 125;
            ownexp.mortgageInterest = 1866.67;
            OwnIncome owninc = new OwnIncome();
            owninc.rentAgencyRate = 7 / 100;
            owninc.monthlyRent = 1880;
            owninc.hikePercent = 4 / 100;
            invest.numberOfYears = 3;

            double totalOwnSaving = owninc.getOwnSavings();
            double totalSellSaving = invest.getInvestmentPlan();

            if (totalSellSaving > totalOwnSaving)
            {
                Console.WriteLine("Selling now and investing it in an investment plan is profitable");
            }
            else
            {
                Console.WriteLine("Owning is profitable");
            }
        }
    }
}
