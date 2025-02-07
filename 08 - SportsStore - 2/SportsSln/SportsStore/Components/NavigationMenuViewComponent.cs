﻿using Microsoft.AspNetCore.Mvc;
using SportsStore.Models;


namespace SportsStore.Components;


public class NavigationMenuViewComponent(IStoreRepository repo) : ViewComponent
{
    private readonly IStoreRepository  repository = repo;

    public IViewComponentResult Invoke()
    {
        return View(repository.Products
            .Select(x => x.Category)
            .Distinct()
            .OrderBy(x => x));
    }
}
