using FacadeSearch;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InternetSearch
{
    class Program
    {
        static void Main(string[] args)
        {
            var searchEngine = new Facade();

            Console.WriteLine("Enter search term: ");
            var term = Console.ReadLine();

            var result = searchEngine.Search(term);

            foreach (var item in result)
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();
        }
    }
}
