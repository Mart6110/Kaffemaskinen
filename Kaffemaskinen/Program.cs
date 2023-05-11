using Kaffemaskinen.Class;
using Kaffemaskinen.Interface;
using System;

namespace Kaffemaskinen
{
    class Program
    {
        public  static void Main(string[] args)
        {
            // Create instances of the dependencies
            IWaterContainer waterContainer = new WaterContainer();
            IFilter filter = new Filter();
            ICoffeeBeans coffeeBeans = new CoffeeBeans();

            // Create the coffee machine with the dependencies
            ICoffeeMachine coffeeMachine = new CoffeeMachine(waterContainer, filter, coffeeBeans);

            coffeeMachine.Brew();
        }
    }
}
