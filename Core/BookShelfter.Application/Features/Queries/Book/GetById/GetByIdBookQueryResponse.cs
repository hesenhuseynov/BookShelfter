﻿namespace BookShelfter.Application.Features.Queries.Book.GetById;

public class GetByIdBookQueryResponse
{
    public string Name { get; set; }
    public int Stock { get; set; }
    public float Price { get; set; }
}