﻿using Kaffemaskinen.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kaffemaskinen.Class
{
    public class Filter : IFilter
    {
        public void Insert()
        {
            Console.WriteLine("Filter inserted.");
        }

        public void Remove()
        {
            Console.WriteLine("Filter removed");
        }
    }
}
