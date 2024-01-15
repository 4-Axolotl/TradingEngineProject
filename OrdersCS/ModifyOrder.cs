using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TradingEngineServer.Orders
{
    public class ModifyOrder : IOrderCore
    {
        public ModifyOrder(IOrderCore orderCore, long modifyPrice, uint modifyQuantity,bool isBuySide)
        {
            // PROPERTIES //
            Price = modifyPrice;
            Quantity = modifyQuantity;
            IsBuySide = isBuySide;
            
            // FIELDS //
            _orderCore = orderCore;
        }

        // PROPERTIES //

        public long Price { get; private set; }
        public uint Quantity { get; private set; }
        public bool IsBuySide { get; private set; }
        public long OrderId => _orderCore.OrderId;
        public string Username => _orderCore.Username;
        public int SecurityId => _orderCore.SecurityId;

        // METHODS //
        public CancelOrder ToCancelOrder()
        {
            return new CancelOrder(this);
        }

        public Order ToNewOrder()
        {
            return new Order(this);
        }
        
        // FIELDS //

        private readonly IOrderCore _orderCore;
    }
}
