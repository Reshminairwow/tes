using System;

using Training;
public class OwnExpenses
{
    public double propMaintanance { get; set; }
    public double waterRates { get; set; }
    public double councilTax { get; set; }

    public double insurance { get; set; }

    public double mortgageInterest { get; set; }
    public double numberOfYears { get; set; }
    public double getMaintananceCost()
    {
        double maintainanceTotal = (propMaintanance + waterRates + councilTax + insurance + mortgageInterest) * numberOfYears;
        return maintainanceTotal;
    }

}
