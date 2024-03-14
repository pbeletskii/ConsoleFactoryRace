using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleFactoryRace
{
    public class CreatorCarGT1 : CreatorCar
    {
        public override CarGT1 Creator() => new CarGT1();
    }
}
