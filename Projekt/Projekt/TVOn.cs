using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Projekt
{
    class TVOn : ChannelOverview
    {
        public bool tvPowerOn;

        //public int channelNumber = 1;
        //public string channelName = "something";
        //public string channeldescription = "total solformørkelse";

        public void TVTurnedOn()
        {
            Console.Clear();
            tvPowerOn = true;
            Timer timer = new Timer();
            Thread timerth = new Thread(timer.TimeToShutdown);
            timerth.Start();
            

            while (tvPowerOn)
            {
                Console.WriteLine("You're watching {0} {1} {2}", channelNumber, channelName, channeldescription);
                string title = @" 
    .---..-----------------------------------------------..---.
    |   ||.---------------------------------------------.||   |
    | o ||| _0_o O/oo  _0_ \O/ _   _0_  O_0_o_O/ooO _0_ ||| o |
    | _ |||O oo _0_ _0_o\O  _O/~'       O oo__0_ _0_o\O ||| _ |
    |(_)|||_0_ \O oo        /)    _0_ \O_0_ \O oo       |||(_)|
    |   |||---------------------------------------------|||   |
    |.-.|||     __....------------------------....___   |||.-.|
    | o |||---''                         _.--._      `  ||| o |
    |`-'|||             _.--._          'O---O-'        |||`-'|
    |   |||     _.--._ 'O---O-'_.--._  _.--._           |||   |
    |.-.|||    'O---O-'       'O---O-''O---O-'          |||.-.|
    | O |||__,,...,----------------------....___        ||| O |
    |`-'||`---------------------------------------------'||`-'|
    `---'`-----------------------------------------------'`---'
           _||_                                     _||_
          /____\                                   /____\";

                Console.WriteLine(title);
                //Console.Read();
                Console.WriteLine("Channels \noff");
                Console.WriteLine("You have the options listet above");
                

                string uInput = Console.ReadLine().ToLower();

                if (uInput == "channels")
                {
                    ShowChannels();
                }
                else if(uInput == "off")
                {
                    Environment.Exit(0);
                }
            }
        }

    }
}
