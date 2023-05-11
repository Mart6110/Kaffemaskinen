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

        public void BrewCoffee()
        {
            waterContainer.AddWater(2);
            filter.Insert();
            coffeeBeans.AddBeans();

            Console.WriteLine("Brewing coffee...");
            Console.WriteLine("Coffee is ready!");
        }
    }
}
