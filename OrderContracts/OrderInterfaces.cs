using SOLID_Refactoring.Models;

namespace SOLID_Refactoring.OrderContracts
{
    public interface IOrderValidator
    {
        void Validate(Order order);
    }

    public interface IOrderPricingService
    {
        decimal CalculateTotal(Order order);
    }

    public interface IOrderRepository
    {
        void Save(Order order);
    }

    public interface INotificationService
    {
        void Send(string message);
    }

    public interface IInvoiceGenerator
    {
        void Generate(Order order);
    }

    public interface IDiscountStrategy
    {
        bool CanHandle(string customerType);
        decimal Apply(decimal amount);
    }
}
