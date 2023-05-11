using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kaffemaskinen.Interface
{
    public interface IIngredient
    {
        void AddBeans(int spoon);
        void AddTealeaf(int spoon);
        void AddEspressoBeans(int spoon);
    }
}
