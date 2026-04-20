using Microsoft.AspNetCore.Mvc;
using VANTRO.Models;
using System.Collections.Generic;

public class ClothingController : Controller
{
    private static List<Clothing> clothes = new List<Clothing>()
    {
        new Clothing
        {
            Id = 1,
            Name = "T-Shirt",
            Size = "M",
            Price = 25,
            Color = "Red",
            ImageUrl = "/Images/T-shirtred123.jpg"
        },

        new Clothing
        {
            Id = 2,
            Name = "Jeans",
            Size = "L",
            Price = 60,
            Color = "Blue",
            ImageUrl = "/img/jeans.jpg"
        }
    };

    public IActionResult Index()
    {
        return View(clothes);
    }
}