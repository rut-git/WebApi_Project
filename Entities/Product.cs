﻿using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Entities;

public partial class Product
{
    public int ProductId { get; set; }

    public string ProductName { get; set; }

    public int Price { get; set; }

    public int? CategoryId { get; set; }

    public string Description { get; set; }

    public string imageUrl { get; set; }
    [JsonIgnore]
    public virtual Category? Category { get; set; }
    [JsonIgnore]
    public virtual ICollection<OrderItem> OrderItems { get; set; } = new List<OrderItem>();
}
