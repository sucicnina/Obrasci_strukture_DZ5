using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Obrasci_strukture_DZ5
{
    public class Espresso : Coffee
    {

        public double GetCost()
        {
            return 1.99;
        }

        public String GetDescription()
        {
            return "Espresso";
        }
    }
}
