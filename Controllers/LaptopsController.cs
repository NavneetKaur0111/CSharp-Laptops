using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Final_Project.Models;

namespace Final_Project.Controllers
{
    public class LaptopsController : Controller
    {
        DB db = new DB();
        public IActionResult MostExpensiveLaptop()
        {
            double MaxPrice = db.Laptops.Max(l => l.Price);
            Laptop laptop = db.Laptops.FirstOrDefault(l => l.Price == MaxPrice);
            return View(laptop);
        }

        public IActionResult TwoMostExpensiveLaptops()
        {
            List<Laptop> laptops = db.Laptops.OrderByDescending(l => l.Price).Take(2).ToList();
            return View(laptops);
        }

        public IActionResult ThreeMostAffordableLaptops()
        {
            List<Laptop> laptops = db.Laptops.OrderBy(l => l.Price).Take(3).ToList();
            return View(laptops);
        }

        public IActionResult AffordableLaptops(double money)
        {
            ViewBag.money = money;
            List<Laptop> laptops = db.Laptops.Where(l => l.Price <= money).ToList();
            return View(laptops);
        }

       

      
    }
}
