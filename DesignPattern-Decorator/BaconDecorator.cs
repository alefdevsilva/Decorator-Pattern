using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesignPattern_Decorator.Interfaces;

namespace DesignPattern_Decorator
{
    //Concrete Decorator
    public class BaconDecorator:PizzaDecorator
    {
        public BaconDecorator(IPizza pizza)
              : base(pizza)
        {

        }

        public override string BuscarTipoPizza()
        {
            var pizza = base.BuscarTipoPizza();
            pizza += "\r\n Com extra de bacon";
            return pizza;
        }
    }
}
