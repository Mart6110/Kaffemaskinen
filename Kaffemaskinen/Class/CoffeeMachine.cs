using Kaffemaskinen.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kaffemaskinen.Class
{
    public class CoffeeMachine : ICoffeeMachine
    {
        private IWaterContainer waterContainer;
        private IFilter filter;
        private IIngredient ingredient;

        public CoffeeMachine(IWaterContainer waterContainer, IFilter filter, IIngredient ingredient)
        {
            this.waterContainer = waterContainer;
            this.filter = filter;
            this.ingredient = ingredient;
        }

        public void Brew()
        {
            waterContainer.AddWater(2); // Add 2 cups of water
            filter.Insert(); // Insert the filter
            ingredient.AddBeans(4); // Add coffee beans

            Console.WriteLine("Brewing coffee...");
            Console.WriteLine("Coffee is ready!");

            filter.Remove(); // Remove the filter

            Console.WriteLine();

            waterContainer.AddWater(6); // Add 6 cups of water
            filter.Insert(); // Insert the filter
            ingredient.AddTealeaf(4); // add tealeaf

            Console.WriteLine("Brewing tea...");
            Console.WriteLine("Tea is ready!");

            filter.Remove(); // Remove the filter

            Console.WriteLine();

            waterContainer.AddWater(1); // Add 1 cups of water
            filter.Insert(); // Insert the filter
            ingredient.AddEspressoBeans(4); // Add espresso beans

            Console.WriteLine("Brewing espresso...");
            Console.WriteLine("ekspresso is ready!");

            filter.Remove(); // Remove the filter

            Console.WriteLine();

        }
    }
}
