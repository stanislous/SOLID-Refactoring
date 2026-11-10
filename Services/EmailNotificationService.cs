using SOLID_Refactoring.OrderContracts;

namespace SOLID_Refactoring.Services
{
    public class EmailNotificationService : INotificationService
    {
        public void Send(string message)
        {
            // Send email using an email provider
        }
    }
}
