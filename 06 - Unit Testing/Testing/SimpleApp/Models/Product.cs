﻿namespace SimpleApp.Models;

public class Product
{
    public string Name { get; set; } = string.Empty;
    public decimal? Price { get; set; }

    //public static Product[] GetProducts()
    //{
    //    Product kayak = new()
    //    {
    //        Name = "Kayak",
    //        Price = 275M
    //    };
    //    Product lifejacket = new()
    //    {
    //        Name = "Lifejacket",
    //        Price = 48.95M
    //    };

    //    return [kayak, lifejacket];
    //}
}
