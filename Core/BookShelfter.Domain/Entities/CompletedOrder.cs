﻿using BookShelfter.Domain.Entities.Common;

namespace BookShelfter.Domain.Entities;

public class CompletedOrder:BaseEntity
{
    public Guid OrderId { get; set; }
    public Order Order { get; set; }
     
}