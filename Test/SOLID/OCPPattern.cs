using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.SOLID
{
    //Open-Closed Principle - Open for extension closed for modification
    //Prroblem - For every new customer type modify the class
    public class OCPPattern
    {
        public double Calculation(string compareType, double amount)
        {
            if (compareType == "Regualar")
                return amount = amount * 5;
            else if(compareType == "Premium")
                return amount = amount * 10;

            return amount;
        }
    }

    //Solution - 
    interface IDiscount
    {
        double Apply(double amount);
    }

    class RegularDiscount : IDiscount
    {
        public double Apply(double amount)
        {
            return amount * 5;
        }
    }

    class PremiumDiscount : IDiscount
    {
        public double Apply(double amount)
        {
            return amount * 10;
        }
    }
}
