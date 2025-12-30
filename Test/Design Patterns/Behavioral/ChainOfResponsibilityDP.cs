using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Design_Patterns.Behavioral
{
    public abstract class Handler
    {
        public Handler NextHandler;

        public void SetNextHandler(Handler NextHandler) { this.NextHandler = NextHandler; }

        public abstract void DispatchNote(long requestedAmount);
    }

    public class TwoThousendHandler : Handler
    {
        public override void DispatchNote(long requestedAmount)
        {
            long numberOfNotesToBeDispatched = requestedAmount / 2000;
            if(numberOfNotesToBeDispatched > 0)
            {
                if(numberOfNotesToBeDispatched > 1)
                {
                    Console.WriteLine(numberOfNotesToBeDispatched + "Two thousands note dispatched.");
                }
                else
                {
                    Console.WriteLine(numberOfNotesToBeDispatched + "Two thousands note dispatched.");
                }
            }

            long pendingAmountToBeProcessed = requestedAmount % 2000;
            if(pendingAmountToBeProcessed > 0)
            
                NextHandler.DispatchNote(pendingAmountToBeProcessed);
            }
        }


    public class FiveHundradHandler : Handler
    {
        public override void DispatchNote(long requestedAmount)
        {
            long numberOfNotesToBeDispatched = requestedAmount / 500;
            if (numberOfNotesToBeDispatched > 0)
            {
                if (numberOfNotesToBeDispatched > 1)
                {
                    Console.WriteLine(numberOfNotesToBeDispatched + "Five hundrad note dispatched.");
                }
                else
                {
                    Console.WriteLine(numberOfNotesToBeDispatched + "Five hundrad note dispatched.");
                }
            }

            long pendingAmountToBeProcessed = requestedAmount % 500;
            if (pendingAmountToBeProcessed > 0)
            {
                NextHandler.DispatchNote(pendingAmountToBeProcessed);
            }
        }
    }

    public class TwoHundradHandler : Handler
    {
        public override void DispatchNote(long requestedAmount)
        {
            long numberOfNotesToBeDispatched = requestedAmount / 200;
            if (numberOfNotesToBeDispatched > 0)
            {
                if (numberOfNotesToBeDispatched > 1)
                {
                    Console.WriteLine(numberOfNotesToBeDispatched + "Two hundrad note dispatched.");
                }
                else
                {
                    Console.WriteLine(numberOfNotesToBeDispatched + "Two hundrad note dispatched.");
                }
            }
        }
    }

    public class ATM
    {
        private TwoThousendHandler twoThousendHandler = new TwoThousendHandler();
        private FiveHundradHandler fiveHundradHandler = new FiveHundradHandler();

        public ATM()
        {
            twoThousendHandler.SetNextHandler(fiveHundradHandler);
            fiveHundradHandler.SetNextHandler(twoThousendHandler);
        }

        public void Withdraw(long requestedAmout)
        {
            if(requestedAmout % 200 == 0)
            {
                twoThousendHandler.DispatchNote(requestedAmout);
            }
            else
            {
                Console.Write("Enter valid amount");
            }

        }
    }
    public class ChainOfResponsibilityDP
    {
        public void Main()
        {
            ATM atm = new ATM();
            atm.Withdraw(5000);

            atm.Withdraw(700);
        }
    }
}
