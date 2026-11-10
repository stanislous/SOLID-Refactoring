namespace SOLID_Refactoring.Models
{
    public class Order
    {
        public List<Item> Items { get; internal set; }
        public int OrderId { get; internal set; }
        public string CustomerType { get; internal set; }
        public string CustomerName { get; internal set; }
        public string CustomerEmail { get; internal set; }
        public string CustomerPhone { get; internal set; }
    }
}
