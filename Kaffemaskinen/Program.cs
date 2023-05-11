using Kaffemaskinen.Class;
using Kaffemaskinen.Interface;
using System;
using System.Collections.Generic;

namespace Kaffemaskinen
{
    class Program
    {
        public static void Main(string[] args)
        {

            // Create instances of the dependencies
            IWaterContainer waterContainer = new WaterContainer();
            IFilter filter = new Filter();
            IIngredient coffeeBeans = new Ingredient();


            // Create the coffee machine with the dependencies
            ICoffeeMachine coffeeMachine = new CoffeeMachine(waterContainer, filter, coffeeBeans);

            coffeeMachine.Brew();

        }
    }
}
