using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            Guid guid = new Guid();

            Notebook notebook = new Notebook(guid, "Dell", 185.5, "Intel Core i9", 16, "Nvidia 1660 6Gb");
            Book book = new Book(guid, "Остров Сокровищ", 85.5, "Роберт Льюис Стивенсон", 565);

            Console.WriteLine("Notebook");
            Console.WriteLine(notebook.Name + "\n" +
                notebook.Price + "\n" +
                notebook.Processor + "\n" +
                notebook.Ram + "\n" +
                notebook.Videocard + "\n");

            Console.ReadKey();
        }
    }
}
