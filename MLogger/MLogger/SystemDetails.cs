using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace MLogger
{
    class SystemDetails
    {
        private static string GetMAC()
        {
            var macAddr = (from nic in NetworkInterface.GetAllNetworkInterfaces()
                           where nic.OperationalStatus == OperationalStatus.Up
                           select nic.GetPhysicalAddress().ToString()).FirstOrDefault();
            Console.WriteLine(macAddr);
            return macAddr;
        }
        private static string GetSystemInfo()
        {
            String command = @"/c systeminfo";
            ProcessStartInfo cmdsi = new ProcessStartInfo("cmd.exe");
            cmdsi.Arguments = command;
            cmdsi.RedirectStandardOutput = true;
            cmdsi.UseShellExecute = false;
            Process cmd = Process.Start(cmdsi);
            cmd.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
            var output = cmd.StandardOutput.ReadToEnd();

            cmd.WaitForExit();

            return output;
        }

        
    }
}
