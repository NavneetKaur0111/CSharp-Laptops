using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Final_Project.Models
{
    public class Brand
    {
        public string Name { get; set; }
        public List<Laptop> Laptops { get; set; }
        public Brand(string name)
        {
            this.Name = name;
            this.Laptops = new List<Laptop>();
        }

        public Laptop MakeLaptop(int id,string name, string processor, string color, double price)
        {
            Laptop laptop = new Laptop(id,name, processor, color, this, price);
            this.Laptops.Add(laptop);
            return laptop;
        }

        public double MostExpensiveLaptopPrice()
        {
            return Laptops.Max(l => l.Price);
        }

        public bool HaveLaptopsLessThan(double price)
        {
            return Laptops.Any(l => l.Price <= price);
        }
        public override string ToString()
        {
            return $"{this.Name}";
        }
    }
}
