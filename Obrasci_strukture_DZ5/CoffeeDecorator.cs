using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Obrasci_strukture_DZ5
{
    public abstract class CoffeeDecorator : Coffee
    {
        protected Coffee coffee;

        public CoffeeDecorator(Coffee coffee)
        {
            this.coffee = coffee;
        }

        public virtual double GetCost()
        {
            return coffee.GetCost();
        }

        public virtual String GetDescription()
        {
            return coffee.GetDescription();
        }
    }
}
