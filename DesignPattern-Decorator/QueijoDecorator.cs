using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesignPattern_Decorator.Interfaces;

namespace DesignPattern_Decorator
{
    //Concrete Decorator
    public class QueijoDecorator : PizzaDecorator
    {
        public QueijoDecorator(IPizza pizza)
            :base(pizza)
        {

        }

        public override string BuscarTipoPizza()
        {
            var pizza = base.BuscarTipoPizza();
            pizza += "\r\n Com extra de queijo";
            return pizza;
        }
    }
}
