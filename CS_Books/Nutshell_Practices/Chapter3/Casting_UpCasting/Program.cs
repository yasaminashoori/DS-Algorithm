﻿namespace Casting_UpCasting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var msft = new Stock() { Name = "MSFT", SharesOwned = 1000000 };
            var manison = new House() { Name = "Manison", Mortgage = 2100000 };
            Asset a = msft; //Up Casting
        }
    }
    public class Asset
    {
        public string Name;
    }

    public class House : Asset
    {
        public int Mortgage;
    }
    public class Stock : Asset
    {
        public int SharesOwned;
    }
}
