using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Final_Project.Models
{
    public class Laptop
    {
        public int id { get; set; }
        public string Name { get; set; }
        public Brand Brand { get; set; }
        public string Processor { get; set; }
        public string Color { get; set; }
        public double Price { get; set; }

        public Laptop (int id ,string name, string processor, string color , Brand brand, double price)
        {
            this.id = id;
            this.Name = name;
            this.Processor = processor;
            this.Color = color;
            this.Brand = brand;
            this.Price = price;
        }

        public override string ToString()
        {
            return $"{Color} {Brand.Name} {Name}- {Processor} of ${Price}";
        }
    }
}
