using System;

namespace MoneyMaker
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Money Maker!");
            Console.WriteLine("Enter an amount to convert to coins:");
            string amount = Console.ReadLine();
            double goldCoin = 10;
            double silverCoin = 5;
            double goldCoins = Math.Floor(Convert.ToDouble(amount) / goldCoin);
            double goldCoinsRemainder = Convert.ToDouble(amount) % goldCoin;
            double silverCoins = Math.Floor(goldCoinsRemainder / silverCoin);
            double silverCoinsRemainder = goldCoinsRemainder % silverCoin;
            Console.WriteLine($"{amount} cents is equal to");
            Console.WriteLine($"Gold coins: {goldCoins}");
            Console.WriteLine($"Silver coins: {silverCoins}");
            Console.WriteLine($"Bronze coins: {silverCoinsRemainder}");
        }
    }
}
