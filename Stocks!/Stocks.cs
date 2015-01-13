using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stocks_
{
    class Stock
    {
        public string StockName { get; set; }
        public double StockValue { get; set; }
        public int AvailableStocks { get; set; }

        public Stock (string stockName, double stockValue, int availableStocks)
        {
            this.StockName = stockName;
            this.StockValue = stockValue;
            this.AvailableStocks = availableStocks;
        }

    }

    class User
    {
        public string UserName { get; set; }

        public double Cash { get; set; }

        public Dictionary<String, double> portfolio = new Dictionary<String, double>();

        public User (string userName, double cash)
        {
            this.UserName = userName;
            this.Cash = cash;
        }

    }

}
