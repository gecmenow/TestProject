using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Product
    {
        public Guid Id { get; }
        public string Name { get; }
        public double Price { get; }

        public Product(Guid id, string name, double price)
        {
            this.Id = id;
            this.Name = name;
            this.Price = price;
        }
    }
}
