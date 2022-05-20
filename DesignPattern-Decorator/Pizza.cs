using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesignPattern_Decorator.Interfaces;

namespace DesignPattern_Decorator
{
    public class Pizza : IPizza
    {
        public string BuscarTipoPizza()
        {
            var pizza = "Esta é uma pizza normal";
            return pizza;
        }
    }
}
