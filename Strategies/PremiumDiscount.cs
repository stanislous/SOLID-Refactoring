using SOLID_Refactoring.OrderContracts;

namespace SOLID_Refactoring.Strategies
{
    public class PremiumDiscount : IDiscountStrategy
    {
        public bool CanHandle(string type) => type == "Premium";
        public decimal Apply(decimal amount) => amount * 0.90m;
    }
}
