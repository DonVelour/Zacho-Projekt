using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Projekt
{
    class Program
    {
        static void Main(string[] args)
        {
            //Hello, i'm a little bug
            Start();
        }

        public static void Start()
        {
            TVOn tvon = new TVOn();

            int inches = 55;
            string brand = "Samsung";
            string productType = "not that smart TV";

            // Console.WriteLine("The {0} inch {1} {2} is turned off, you can turn it on or not, whatever you like.", inches, brand, productType);
            Console.WriteLine("Turn on by typing on");
            string uInput = Console.ReadLine().ToLower();
            if (uInput == "on")
            {
                tvon.TVTurnedOn();
            }
            else
            {
                // do something else.
            }
        }

        public void ShowTV()
        {

        }
    }

    class Timer
    {
        public void TimeToShutdown()
        {
            int time = 300;
            while(time > 0)
            {
                time = time - 1;
                Thread.Sleep(1000);
                //Console.WriteLine(time);
            }
        }
    }

}
