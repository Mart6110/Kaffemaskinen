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
        public void AddBeans(int spoon)
        {
            // Method to add coffee beans
            Console.WriteLine($"Added {spoon} spoons of coffee.");
        }

        public void AddTealeaf(int spoon)
        {
            // Method to add tea leaves
            Console.WriteLine($"Added {spoon} spoons of tea leaves.");
        }

        public void AddEspressoBeans(int spoon)
        {
            // Method to add espresso beans
            Console.WriteLine($"Added {spoon} spoons of espresso.");
        }
    }
}
