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
        private int waterLevel;

        public void AddWater(int cups)
        {
            waterLevel += cups;
            Console.WriteLine($"Added {cups} cups of water.");
        }
    }
}
