using System;
using System.Collections.Generic;

namespace mtg_lib.Library.Models;

public partial class Order
{
    public int Id { get; set; }

    public string Email { get; set; } = null!;

    public long CardId { get; set; }

    public DateTime? CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }
}
