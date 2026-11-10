using SOLID_Refactoring.OrderContracts;

namespace SOLID_Refactoring.Strategies
{
    public class VipDiscount : IDiscountStrategy
    {
        public bool CanHandle(string type) => type == "VIP";
        public decimal Apply(decimal amount) => amount * 0.80m;
    }
}
