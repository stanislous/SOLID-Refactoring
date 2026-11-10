using SOLID_Refactoring.Models;
using SOLID_Refactoring.OrderContracts;

namespace SOLID_Refactoring.Services
{
    public class OrderPricingService(IEnumerable<IDiscountStrategy> strategies) : IOrderPricingService
    {
        public decimal CalculateTotal(Order order)
        {
            decimal total = order.Items.Sum(
                x => x.Price * x.Quantity);

            var strategy = strategies.FirstOrDefault(
                x => x.CanHandle(order.CustomerType));

            return strategy?.Apply(total) ?? total;
        }
    }
}
