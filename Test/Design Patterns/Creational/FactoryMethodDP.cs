using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Design_Patterns.Creational
{

    public interface ICreditCard
    {
        string GetCardType();
        int GetCreditLimit();
        int GetAnnualCharge();
    }

    public class PlatinumCard : ICreditCard
    {
        public string GetCardType()
        {
            return "Platinum";
        }

        public int GetCreditLimit()
        {
            return 10000;
        }
        public int GetAnnualCharge()
        {
            return 1400;
        }
    }

    public class MoneyBackCard : ICreditCard
    {

        public string GetCardType()
        {
            return "Money Back";
        }

        public int GetCreditLimit()
        {
            return 150000;
        }
        public int GetAnnualCharge()
        {
            return 1000;
        }
    }

    public class TitaniumCard : ICreditCard
    {
        public string GetCardType()
        {
            return "Titanium";
        }

        public int GetCreditLimit()
        {
            return 200000;
        }

        public int GetAnnualCharge()
        {
            return 1300;
        }
    }

    public abstract class CreditCardFactory
    {
        protected abstract ICreditCard MakeProduct();

        public ICreditCard CreateProduct()
        {
            ICreditCard creditCard = this.MakeProduct();
            return creditCard;
        }
    }

    public class MoneyBackFactory : CreditCardFactory
    {
        protected override ICreditCard MakeProduct()
        {
            ICreditCard creditCard = new MoneyBackCard();
            return creditCard;
        }
    }

    public class PlatinumFactory : CreditCardFactory
    {
        protected override ICreditCard MakeProduct()
        {
            ICreditCard creditCard = new PlatinumCard();
            return creditCard;
        }
    }

    public class TitaniumFactory : CreditCardFactory
    {
        protected override ICreditCard MakeProduct()
        {
            ICreditCard creditCard = new TitaniumCard();
            return creditCard;
        }
    }

    public class FactoryMethodDP
    {
        public void Method()
        {
            ICreditCard platinumCard = new PlatinumFactory().CreateProduct();
            Console.WriteLine($"Card type : {platinumCard.GetCardType}, Limit: {platinumCard.GetCreditLimit}, Annual Charge: {platinumCard.GetAnnualCharge}");

            ICreditCard moneyBackCard = new MoneyBackFactory().CreateProduct();
            Console.WriteLine($"Card type : {moneyBackCard.GetCardType}, Limit: {moneyBackCard.GetCreditLimit}, Annual Charge: {moneyBackCard.GetAnnualCharge}");

            ICreditCard titaniumCard = new TitaniumFactory().CreateProduct();
            Console.WriteLine($"Card type : {titaniumCard.GetCardType}, Limit: {titaniumCard.GetCreditLimit}, Annual Charge: {titaniumCard.GetAnnualCharge}");

        }
    }
}
