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
        private ICoffeeBeans coffeeBeans;

        public CoffeeMachine(IWaterContainer waterContainer, IFilter filter, ICoffeeBeans coffeeBeans)
        {
            this.waterContainer = waterContainer;
            this.filter = filter;
            this.coffeeBeans = coffeeBeans;
        }

        public void Brew()
        {
            waterContainer.AddWater(2); // Add 2 cups of water
            filter.Insert(); // Insert the filter
            coffeeBeans.AddBeans(); // Add coffee beans

            Console.WriteLine("Brewing coffee...");
            Console.WriteLine("Coffee is ready!");
        }
    }
}
