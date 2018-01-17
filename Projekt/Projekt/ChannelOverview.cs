using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt
{
    class ChannelOverview 
    {
        public int channelNumber = 1;
        public string channelName = "DR1";
        public string channeldescription = "total solformørkelse";

        public string[] channels = { "DR1", "TV2", "Something", "Lolz med z", "DR3" };
        
        public void ShowChannels()
        {
            //Show the channels to choose from
            int i = 1;
            foreach(string channel in channels)
            {
                Console.WriteLine(i +" "+ channel);
                i++;

            }
            Console.WriteLine();
            Console.WriteLine("Choose one of the above");

            // userinput
            int uInput = 0;
            bool pickChannel = true;
            while(pickChannel)
            {
                try
                {
                    uInput = Convert.ToInt32(Console.ReadLine());
                    pickChannel = false;
                }
                catch
                {
                    continue;
                }
            }
            
            channelNumber = uInput;
            uInput--;
            channelName = channels[uInput];
            

        }
    }
}
