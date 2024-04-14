﻿using Microsoft.AspNetCore.Mvc;
using QLBQA.Data;
using QLBQA.Infrastructure;
using QLBQA.Models;

namespace QLBQA.Controllers
{
    public class CartController : Controller
    {
        public Cart? Cart { get; set; }
        private readonly ApplicationDbContext _context;

        public CartController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult AddToCart(int productId)
        {
            Product? product = _context.Products.FirstOrDefault(P=> P.ProductId == productId);
            if (product != null)
            {
                Cart = HttpContext.Session.GetJson<Cart>("cart") ?? new Cart();
                Cart.AddItem(product, 1);
                HttpContext.Session.SetJson("cart", Cart);
            }
            return View("Cart", Cart);
        }
    }
}