using Kaffemaskinen.Class;
using Kaffemaskinen.Interface;
using System;

namespace Kaffemaskinen
{
    class Program
    {
        public  static void Main(string[] args)
        {
            IWaterContainer waterContainer = new WaterContainer();
            IFilter filter = new Filter();
            ICoffeeBeans coffeeBeans = new CoffeeBeans();

            ICoffeeMachine coffeeMachine = new CoffeeMachine(waterContainer, filter, coffeeBeans);

            coffeeMachine.BrewCoffee();
        }
    }
}
