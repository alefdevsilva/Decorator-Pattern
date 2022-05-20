using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesignPattern_Decorator.Interfaces;

namespace DesignPattern_Decorator
{
    //Concrete Decorator
    public  class CebolaDecorator:PizzaDecorator
    {
        public CebolaDecorator(IPizza pizza)
            : base(pizza)
        {

        }

        public override string BuscarTipoPizza()
        {
            var pizza = base.BuscarTipoPizza();
            pizza += "\r\n Com extra de cebola";
            return pizza;
        }

    }
}
