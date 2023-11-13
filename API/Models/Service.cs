using System;
using System.Collections.Generic;

namespace API.Models;

public partial class Service
{
    public int ServiceId { get; set; }

    public string Servicename { get; set; } = null!;

    public string? Description { get; set; }

    public decimal? ServiceCost { get; set; }
}
