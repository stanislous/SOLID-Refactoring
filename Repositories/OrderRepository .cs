using SOLID_Refactoring.Models;
using SOLID_Refactoring.OrderContracts;

namespace SOLID_Refactoring.Repositories
{
    public class OrderRepository : IOrderRepository
    {
        public void Save(Order order)
        {
            // Database persistence using EF Core or Dapper
        }
    }
}
