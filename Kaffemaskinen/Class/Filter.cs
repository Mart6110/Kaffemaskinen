using Kaffemaskinen.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kaffemaskinen.Class
{
    public class Filter : IFilter
    {
        public void Insert()
        {
            // Method to insert a filter
            Console.WriteLine("Filter inserted.");
        }

        public void Remove()
        {
            // Method to remove a filter
            Console.WriteLine("Filter removed.");
        }
    }
}
