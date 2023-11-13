using System;
using System.Collections.Generic;

namespace SrezApp.Models;

public partial class User
{
    public int user_id { get; set; }

    public string username { get; set; } = null!;

    public string LOGIN { get; set; } = null!;

    public string PASSWORD { get; set; } = null!;

    public string email { get; set; } = null!;

    public virtual ICollection<Order> Orders { get; set; } = new List<Order>();
}
