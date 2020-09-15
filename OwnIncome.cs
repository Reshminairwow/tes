using System;
using Training;
public class OwnIncome
{
    public double rentAgencyRate { get; set; }
    public double monthlyRent { get; set; }

    public double numberOfYears { get; set; }

    public double hikePercent { get; set; }
    public double salePriceNow { get; set; }


    public double getRentIncome()
    {
        double agencyFees = monthlyRent * rentAgencyRate;
        double income = (monthlyRent - agencyFees) * numberOfYears;
        return income;
    }

    public double getPropertyHike()
    {
        if (numberOfYears > 0)
        {
            for (int i = 1; i <= numberOfYears; i++)
            {
                double body = 1 + (hikePercent / 12);
                double exponent = 12 * numberOfYears;
                double currentPropertyValue = salePriceNow + (salePriceNow * Math.Pow(body, exponent));
                Console.WriteLine("The current property value is" + ":" + currentPropertyValue);
                return currentPropertyValue;
            }
            return 5;
        }
        else
        {
            return salePriceNow;
        }
    }
    public double getOwnSavings()
    {

        double x = getRentIncome();
        double y = getPropertyHike();
        OwnExpenses ownexp = new OwnExpenses();
        double z = ownexp.getMaintananceCost();
        double totalOwnSavings = x + y - z;
        return totalOwnSavings;
    }

}
