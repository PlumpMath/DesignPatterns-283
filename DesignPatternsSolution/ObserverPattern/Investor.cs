using System;

namespace ObserverPattern
{
    internal class Investor : IInvestor
    {
        private string _name;
        private Stock _stock;

        public Investor(string name)
        {
            _name = name;
        }

        public void Update(Stock stock)
        {
            Console.WriteLine($"Notified { _name } of { stock.Symbol }'s change to { stock.Price } ");
        }
    }
}