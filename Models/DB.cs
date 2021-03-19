using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Final_Project.Models
{
    public class DB
    {
        public List<Brand> Brands { get; set; }
        public List<Laptop> Laptops { get; set; }

        public DB()
        {
            Brand b1 = new Brand("Hp");
            Brand b2 = new Brand("Apple");
            Brand b3 = new Brand("Dell");
            Brand b4 = new Brand("Asus");
            Brand b5 = new Brand("Surface");
            this.Brands = new List<Brand>() { b1,b2,b3,b4,b5};

            Laptop l1 = b1.MakeLaptop( 1,"Envy", "i5", "natural Silver", 899.99);
            Laptop l2 = b1.MakeLaptop(2,"Spectre", "i7" , "Black", 1999.99 );
            Laptop l3 = b2.MakeLaptop(3,"Macbook-pro", "8-core", "Black", 3499.00);
            Laptop l4 = b2.MakeLaptop(4,"Macbook-Air", "8-core" ,"Gold", 1299.99);
            Laptop l5 = b3.MakeLaptop(5,"Inspiron", "AMD Ryzen 5 4500U Mobile", "Black", 599.00);
            Laptop l6 = b3.MakeLaptop(6,"G5 Gaming", " Intel Core i7", "Black", 1379.99);
            Laptop l7 = b4.MakeLaptop(7,"Vivobook", "Intel Core i5", "Silver", 749.00);
            Laptop l8 = b5.MakeLaptop(8,"Pro 7", "Intel Core", "Silver", 999.00);
            Laptop l9 = b5.MakeLaptop(9,"Laptop 3", "Intel Core i7", "Sandstone metal", 1149.00);
            this.Laptops = new List<Laptop>() { l1, l2, l3, l4, l5, l6, l7, l8, l9 };
        }
    }
}
