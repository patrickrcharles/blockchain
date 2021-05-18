using blockchain;
using Newtonsoft.Json;
using System;


namespace blockchain_basic
{
    class Program
    {
        static void Main(string[] args)
        {
            //BlockChain bloodMoney = new BlockChain();
            //bloodMoney.AddBlock(new Block(DateTime.Now, null, "{sender:Henry,receiver:MaHesh,amount:10}"));
            //bloodMoney.AddBlock(new Block(DateTime.Now, null, "{sender:MaHesh,receiver:Henry,amount:5}"));
            //bloodMoney.AddBlock(new Block(DateTime.Now, null, "{sender:Mahesh,receiver:Henry,amount:5}"));

            //Console.WriteLine(JsonConvert.SerializeObject(bloodMoney, Formatting.Indented));

            //bloodMoney.Chain[1].Data = "{sender:Henry,receiver:MaHesh,amount:1000}";

            //Console.WriteLine($"Is Chain Valid: {bloodMoney.IsValid()}");

            //Console.WriteLine($"Update amount to 1000");
            //bloodMoney.Chain[1].Data = "{sender:Henry,receiver:MaHesh,amount:1000}";
            //Console.WriteLine($"Is Chain Valid: {bloodMoney.IsValid()}");

            ////bloodMoney.Chain[1].Hash = bloodMoney.Chain[1].CalculateHash();

            //Console.WriteLine($"Update the entire chain");
            //bloodMoney.Chain[2].PreviousHash = bloodMoney.Chain[1].Hash;
            //bloodMoney.Chain[2].Hash = bloodMoney.Chain[2].CalculateHash();
            //bloodMoney.Chain[3].PreviousHash = bloodMoney.Chain[2].Hash;
            //bloodMoney.Chain[3].Hash = bloodMoney.Chain[3].CalculateHash();

            //Console.WriteLine($"bloodMoney.Chain[3].Data: {bloodMoney.Chain[3].Data}");

            //var startTime = DateTime.Now;

            //BlockChain bloodMoney = new BlockChain();
            //bloodMoney.AddBlock(new Block(DateTime.Now, null, "{sender:Henry,receiver:MaHesh,amount:10}"));
            //bloodMoney.AddBlock(new Block(DateTime.Now, null, "{sender:MaHesh,receiver:Henry,amount:5}"));
            //bloodMoney.AddBlock(new Block(DateTime.Now, null, "{sender:Mahesh,receiver:Henry,amount:5}"));

            //var endTime = DateTime.Now;

            //Console.WriteLine($"Duration: {endTime - startTime}");

            var startTime = DateTime.Now;

            BlockChain phillyCoin = new BlockChain();
            phillyCoin.CreateTransaction(new Transaction("Henry", "MaHesh", 10));
            phillyCoin.ProcessPendingTransactions("Bill");

            phillyCoin.CreateTransaction(new Transaction("MaHesh", "Henry", 5));
            phillyCoin.CreateTransaction(new Transaction("MaHesh", "Henry", 5));
            phillyCoin.ProcessPendingTransactions("Bill");

            var endTime = DateTime.Now;

            Console.WriteLine($"Duration: {endTime - startTime}");

            Console.WriteLine("=========================");
            Console.WriteLine($"Henry' balance: {phillyCoin.GetBalance("Henry")}");
            Console.WriteLine($"MaHesh' balance: {phillyCoin.GetBalance("MaHesh")}");
            Console.WriteLine($"Bill' balance: {phillyCoin.GetBalance("Bill")}");

            Console.WriteLine("=========================");
            Console.WriteLine($"phillyCoin");
            Console.WriteLine(JsonConvert.SerializeObject(phillyCoin, Formatting.Indented));

            Console.ReadKey();
        }
    }
}
