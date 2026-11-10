using SOLID_Refactoring.Models;
using SOLID_Refactoring.OrderContracts;

namespace SOLID_Refactoring.Services
{
    public class OrderService(
        IOrderValidator validator,
        IOrderPricingService pricingService,
        IOrderRepository repository,
        INotificationService notification,
        IInvoiceGenerator invoiceGenerator)
    {
        public void PlaceOrder(Order order)
        {
            validator.Validate(order);

            order.Total = pricingService.CalculateTotal(order);

            repository.Save(order);

            notification.Send("Order placed successfully");

            invoiceGenerator.Generate(order);
        }
    }
}
