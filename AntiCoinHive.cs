using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Security.Permissions;

namespace AntiCoin
{
    class AntiCoinHive
    {

        static void Main(string[] args)
        {
            Console.WriteLine("░█▀▀█ █▀▀▄ ▀▀█▀▀ ░▀░ ▒█▀▀█ █▀▀█ ░▀░ █▀▀▄");
            Console.WriteLine("▒█▄▄█ █░░█ ░░█░░ ▀█▀ ▒█░░░ █░░█ ▀█▀ █░░█");
            Console.WriteLine("▒█░▒█ ▀░░▀ ░░▀░░ ▀▀▀ ▒█▄▄█ ▀▀▀▀ ▀▀▀ ▀░░▀");
            Console.WriteLine("--------------------------------------------------------------");
            Console.WriteLine("");

            if (Utils.amIAdmin() == false) { Console.WriteLine("Program is not running as Admin! Please run it as Admin! Press any Key to continue!"); Console.ReadKey(); return; }

            Console.Write("Enable AntiCoinHive Y/N J/N?");

            string decision = Console.ReadLine().ToLower();


            if(decision == "y" || decision == "j")
            {
                Utils.addLineUnderHosts(" ");
                Utils.addLineUnderHosts("127.0.0.1 coin-hive.com");
                Utils.addLineUnderHosts("127.0.0.1 coinhive.com");
                Utils.addLineUnderHosts("127.0.0.1 jsecoin.com");
                Utils.addLineUnderHosts("127.0.0.1 reasedoper.pw");
                Utils.addLineUnderHosts("127.0.0.1 mataharirama.xyz");
                Utils.addLineUnderHosts("127.0.0.1 listat.biz");
                Utils.addLineUnderHosts("127.0.0.1 lmodr.biz");
                Utils.addLineUnderHosts("127.0.0.1 minecrunch.co");
                Utils.addLineUnderHosts("127.0.0.1 minemytraffic.com");
                Utils.addLineUnderHosts("127.0.0.1 crypto-loot.com");
            }
            else
            {
                Utils.RemoveLineFromFile("127.0.0.1 coin-hive.com");
                Utils.RemoveLineFromFile("127.0.0.1 coinhive.com");
                Utils.RemoveLineFromFile("127.0.0.1 jsecoin.com");
                Utils.RemoveLineFromFile("127.0.0.1 reasedoper.pw");
                Utils.RemoveLineFromFile("127.0.0.1 mataharirama.xyz");
                Utils.RemoveLineFromFile("127.0.0.1 listat.biz");
                Utils.RemoveLineFromFile("127.0.0.1 lmodr.biz");
                Utils.RemoveLineFromFile("127.0.0.1 minecrunch.co");
                Utils.RemoveLineFromFile("127.0.0.1 minemytraffic.com");
                Utils.RemoveLineFromFile("127.0.0.1 crypto-loot.com");
            }

            Console.WriteLine("Successful!");
            
        }


    }
}
