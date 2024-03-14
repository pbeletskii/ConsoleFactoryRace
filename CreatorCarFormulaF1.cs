using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleFactoryRace
{
    public class CreatorCarFormulaF1 : CreatorCar
    {
        public override CarFormulaF1 Creator() => new CarFormulaF1();
    }
}
