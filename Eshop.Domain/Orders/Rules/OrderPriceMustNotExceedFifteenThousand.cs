using Eshop.Domain.SeedWork;

namespace Eshop.Domain.Orders.Rules
{
    public class OrderPriceMustNotExceedFifteenThousand : IBusinessRule
    {
        private readonly List<OrderProduct> _orderProducts;

        public OrderPriceMustNotExceedFifteenThousand(List<OrderProduct> orderProducts)
        {
            _orderProducts = orderProducts;
        }

        public bool IsBroken() => _orderProducts.Sum(op => op.TotalCost) > 15000;

        public string Message => "Order's price must not exceed 15000";
    }
}
