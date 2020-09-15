using System;
using System.Collections.Generic;
using Training;

public class SellInvestment
{
    public double roiPercentage { get; set; }
    public int numberOfYears { get; set; }
    public int numberOfYear =60;

    //public double expense{get;set;}
    //SellExpense exp = new SellExpense();
    public double getInvestmentPlan()
    {
       // var moneyInvested = exp.getExpense();

        if (numberOfYear > 0)
        {
            double compoundedValue =1;
            for (int i = 1; i <= numberOfYear; i++)
            {
                double body = 1 + (roiPercentage / 12);
                double exponent = 12 * numberOfYear;
              //   compoundedValue = moneyInvested * Math.Pow(body, exponent);
                //Console.WriteLine("The compounded value is" + ":" + compoundedValue);
                //return compoundedValue;
            }
            return compoundedValue;
        }
        else
        {
            return 3.4;
        }
    }

    
}

