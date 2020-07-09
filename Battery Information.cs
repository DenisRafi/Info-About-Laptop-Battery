using System;
using System.Management;

namespace ByDenisRafi
{
    class Program
    {
        static void Main()
        {
            Console.Title = "Info About Laptop Battery";
            ManagementObjectSearcher mos = new 
            ManagementObjectSearcher("select * from Win32_Battery");

            foreach (ManagementObject mo in mos.Get())
            {
                Console.WriteLine("Battery Name\t:{0}",
                mo["Name"]);
                Console.WriteLine("Charge \t\t:{0}%", 
                mo["EstimatedChargeRemaining"]);
            }
            Console.ReadLine();
        }
    }
}