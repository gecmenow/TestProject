using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Book : Product
    {
        public string Author { get; }
        public int Pages { get; }

        public Book(Guid id, string name, double price, string author, int pages) : base (id, name, price)
        {
            this.Author = author;
            this.Pages = pages;
        }
    }
}
