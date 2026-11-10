using SOLID_Refactoring.Models;
using SOLID_Refactoring.OrderContracts;

namespace SOLID_Refactoring.Validators
{
    public class OrderValidator : IOrderValidator
    {
        public void Validate(Order order)
        {
            if (order.Items == null || !order.Items.Any())
                throw new InvalidOperationException("Order is empty");
        }
    }
}
