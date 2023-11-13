namespace API.Models
{
    public partial class OrderService
    {
        public int ServiceId { get; set; }

        public string OrderId { get; set; }

        public virtual ICollection<Order> Orders { get; set; } = new List<Order>();
    }
}
