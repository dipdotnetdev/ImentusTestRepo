using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{

    public class StockPriceEventArgs : EventArgs
    {
        public string Symbol { get; set; }
        public decimal OldPrice { get; set; }
        public decimal NewPrice { get; set; }
        public decimal ChangePercent => ((NewPrice - OldPrice) / OldPrice) * 100;
    }
    public class CustomEventClass
    {
        public event EventHandler<StockPriceEventArgs> PriceChanged;

        private decimal curretPrice;
        public void UpdatePrice(string symbol, decimal newPrice)
        {
            var oldPrice = curretPrice;
            curretPrice = newPrice;

            OnPriceChanged(new StockPriceEventArgs
            {
                Symbol = symbol,
                OldPrice = oldPrice,
                NewPrice = newPrice
            }
            );
        }

        protected virtual void OnPriceChanged(StockPriceEventArgs e)
        {
            PriceChanged.Invoke(this, e);
        }
    }
}
