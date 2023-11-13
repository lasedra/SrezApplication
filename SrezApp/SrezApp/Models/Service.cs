using System;
using System.Collections.Generic;

namespace SrezApp.Models;

public partial class Service
{
    public int ServiceId { get; set; }

    public string Servicename { get; set; } = null!;

    public string? Description { get; set; }

    public decimal? ServiceCost { get; set; }

    public virtual ICollection<Order> Orders { get; set; } = new List<Order>();
}
