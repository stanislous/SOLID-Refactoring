using SOLID_Refactoring.Models;
using SOLID_Refactoring.OrderContracts;

namespace SOLID_Refactoring.Services
{
    public class InvoiceGenerator : IInvoiceGenerator
    {
        public void Generate(Order order)
        {
            // Generate PDF invoice
        }
    }
}
