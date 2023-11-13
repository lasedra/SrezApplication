using System;
using System.Collections.Generic;

namespace SrezApp.Models;

public partial class Order
{
    public int OrderId { get; set; }

    public int? UserId { get; set; }

    public DateOnly? OrderDate { get; set; }

    public decimal? TotalAmount { get; set; }

    public virtual User? User { get; set; }

    public virtual ICollection<Service> Services { get; set; } = new List<Service>();
}
