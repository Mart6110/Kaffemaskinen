using Kaffemaskinen.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kaffemaskinen.Class
{
    public class WaterContainer : IWaterContainer
    {
        public void AddWater(int cups)
        {
            // Method to add water to the container
            Console.WriteLine($"Added {cups} cups of water.");
        }
    }
}
