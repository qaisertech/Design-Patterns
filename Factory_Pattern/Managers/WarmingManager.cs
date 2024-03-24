using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory_Pattern.Managers
{
    public class WarmingManager : IAirConditioner
    {
        private readonly double _temperature;

        public WarmingManager(double temp)
        {
            _temperature = temp;
        }
        public void Operate()
        {
            Console.WriteLine($"Warming the room to the required temperature of {_temperature} degrees.");
        }
    }
}
