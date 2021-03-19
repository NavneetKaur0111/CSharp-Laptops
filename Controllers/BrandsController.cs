using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Final_Project.Models;

namespace Final_Project.Controllers
{
    public class BrandsController : Controller
    {
        DB db = new DB();
        public IActionResult ShowAllBrands()
        {
            List<string> brands = db.Brands.Select(b => b.ToString()).ToList();
            return View(brands);
        }

        public IActionResult BrandWithMostExpensiveLaptop()
        {
            double MaxPrice =  db.Brands.Max(b => b.MostExpensiveLaptopPrice());
            Brand brand = db.Brands.FirstOrDefault(b => b.MostExpensiveLaptopPrice() == MaxPrice);
            return View(brand);
        }

        public IActionResult Comparelaptops(int id1, int id2)
        {
            List<Laptop> laptops = db.Laptops.Where(l => (l.id == id1 || l.id == id2)).ToList();
            return View(laptops);
        }
        public IActionResult ShowLaptopBrandsWithPriceLessThan(double money)
        {
            ViewBag.money = money;
            List<Brand> brands = db.Brands.Where(b => b.HaveLaptopsLessThan(money)).ToList();
            return View(brands);
        }

        public IActionResult ShowAllbrandsWithLaptops()
        {
            return View(db.Brands);
        }
    }
}
