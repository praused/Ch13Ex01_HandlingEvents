using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace Ch13Ex01_HandlingEvents
{
    class Program
    {
        static int counter = 0;

        static string displayString = "This string will appear one letter at a time. ";

        static void Main(string[] args)
        {
            Timer myTimer = new Timer(100);
            myTimer.Elapsed += new ElapsedEventHandler(WriteChar);
            ////or use method group syntax (delegate type will be inferred)..
            //myTimer.Elapsed += WriteChar;
            myTimer.Start();
            Console.ReadKey();
        }

        static void WriteChar(object sender, ElapsedEventArgs e)
        {
            Console.Write(displayString[counter++ % displayString.Length]);
        }
    }
}
