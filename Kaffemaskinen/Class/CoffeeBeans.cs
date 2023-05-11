using Kaffemaskinen.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kaffemaskinen.Class
{
    public class CoffeeBeans : ICoffeeBeans
    {
        public void AddBeans()
        {
            Console.WriteLine("Coffee beans added.");
        }
    }
}
