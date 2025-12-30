using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Design_Patterns.Structural
{
    public interface ILEDTV
    {
        void SwitchOn();
        void SwitchOff();
        void SetChannel(int channerNumber);
    }

    //Acts as a bridge between the abstraction classes and implementer classes
    public class SamsungLEDTV : ILEDTV
    {
        public void SwitchOn()
        {
            Console.WriteLine("Samsung turned on");
        }

        public void SwitchOff()
        {
            Console.WriteLine("Samsung turned off");
        }

        public void SetChannel(int channelNumber)
        {
            Console.WriteLine($"{channelNumber}");
        }
    }

    public class SonyLEDTV : ILEDTV
    {
        public void SwitchOn()
        {
            Console.WriteLine("Sony turned on");
        }

        public void SwitchOff()
        {
            Console.WriteLine("Sony turned off");
        }

        public void SetChannel(int channelNumber)
        {
            Console.WriteLine($"{channelNumber}");
        }
    }

    //Act as the base class for other abstractions.
    public abstract class AbstractRemoteControl
    {
        protected ILEDTV lEDTV;

        public abstract void SwitchOn();
        public abstract void SwitchOff();
        public abstract void SetChannel(int channelNumber);
    }

    public class SamsungRemoteControl : AbstractRemoteControl
    {
        public SamsungRemoteControl(ILEDTV lEDTV)
        {
            this.lEDTV = lEDTV;
        }

        public override void SwitchOn()
        {
            this.lEDTV = lEDTV;
        }

        public override void SwitchOff()
        {
            this.lEDTV = lEDTV;
        }

        public override void SetChannel(int channelNumber)
        {
            lEDTV.SetChannel(channelNumber);
        }
    }

    public class SonyRemoteControl : AbstractRemoteControl
    {
        public SonyRemoteControl(ILEDTV lEDTV)
        {
            this.lEDTV = lEDTV;
        }

        public override void SwitchOn()
        {
            this.lEDTV = lEDTV;
        }

        public override void SwitchOff()
        {
            this.lEDTV = lEDTV;
        }

        public override void SetChannel(int channelNumber)
        {
            lEDTV.SetChannel(channelNumber);
        }
    }

    public class BridgeDP
    {
        static void Main7()
        {
            AbstractRemoteControl samsung = new SamsungRemoteControl(new SamsungLEDTV());
            samsung.SwitchOn();
            samsung.SwitchOff();
            samsung.SetChannel(50);


            AbstractRemoteControl sony = new SonyRemoteControl(new SonyLEDTV());
            sony.SwitchOn();
            sony.SwitchOff();
            sony.SetChannel(50);
        }
    }
}
