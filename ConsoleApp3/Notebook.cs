using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Notebook: Product
    {
        public string Processor { get; }
        public int Ram { get; }
        public string Videocard { get; }

        public Notebook(Guid id, string name, double price, string processor, int ram, string videocard) :base(id, name, price)
        {
            this.Processor = processor;
            this.Ram = ram;
            this.Videocard = videocard;
        }
    }
}
