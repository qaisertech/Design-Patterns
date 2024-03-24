using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory_Pattern.Factory
{
    public abstract class AirConditionerFactory
    {
        public abstract IAirConditioner Create(double temp);
    }
}
