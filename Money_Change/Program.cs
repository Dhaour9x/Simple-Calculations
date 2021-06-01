using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Money_Change
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal bitcoins = int.Parse(Console.ReadLine());
            decimal yuans = decimal.Parse(Console.ReadLine());
            decimal commission = decimal.Parse(Console.ReadLine());

            var bitcoinToBGN = bitcoins * 1168;
            var yuanToUSD = yuans * 0.15m;
            
            var commiss = commission/100;

            var euro = (bitcoinToBGN + yuanToUSD * 1.76m) / 1.95m
                - ((bitcoinToBGN + yuanToUSD * 1.76m) / 1.95m * commiss);

            Console.WriteLine(euro);
        }
    }
}
