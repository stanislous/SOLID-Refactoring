using SOLID_Refactoring.Models;
using System.Data.SqlClient;

namespace SOLID_Refactoring.OrderService
{
    public class OrderService
    {
        private readonly SqlConnection _connection;

        public OrderService()
        {
            _connection = new SqlConnection(
                "Server=localhost;Database=Shop;Trusted_Connection=True;");
        }

        public void PlaceOrder(Order order)
        {
            // 1. Validate order
            if (order.Items == null || !order.Items.Any())
                throw new Exception("Order is empty");

            // 2. Calculate total
            decimal total = 0;

            foreach (var item in order.Items)
            {
                total += item.Price * item.Quantity;
            }

            // 3. Apply discount
            if (order.CustomerType == "VIP")
            {
                total *= 0.80m;
            }
            else if (order.CustomerType == "Premium")
            {
                total *= 0.90m;
            }

            // 4. Save to database
            _connection.Open();

            var command = new SqlCommand(
                "INSERT INTO Orders (Total) VALUES (@Total)",
                _connection);

            command.Parameters.AddWithValue("@Total", total);
            command.ExecuteNonQuery();

            _connection.Close();

            // 5. Send email
            Console.WriteLine("Order confirmation email sent");

            // 6. Generate invoice
            Console.WriteLine("Invoice generated");
        }
    }
}
