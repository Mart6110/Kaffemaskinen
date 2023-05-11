using Kaffemaskinen.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kaffemaskinen.Class
{
    public class Ingredient : IIngredient
    {
        public void AddBeans()
        {
            Console.WriteLine("Coffee beans added.");
        }
        public void AddTealeaf()
        {
            Console.WriteLine("Tealeaf added.");
        }
    }
}
