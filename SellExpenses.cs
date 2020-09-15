using System;
using Training;
public class SellExpense
{
    public double salePriceNow { get; set; }
    public double salesCostPercent { get; set; }
    public double pendingMortgage { get; set; }
    public double getExpense()
    {
        double salesCost = salePriceNow * salesCostPercent;
        double sellProfit = salePriceNow - (salesCost + pendingMortgage);
        return sellProfit;

    }


}

