using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleFactoryRace
{
    public class CarFormulaF1 : Car
    {
        double Speed { get; set; }
        public override void Move()
        {
            Random randomSpeed = new();
            int count = 0;
            for (double distance = 0.0; distance < 2000; distance += Speed)
            {
                Speed = randomSpeed.NextDouble() * (100 - 80) + 80;
                count++;
                GetInfoRace(distance,count);
            }
        }
        public void GetInfoRace(double distance, int count)
        {
            Console.WriteLine($"Formula1: {distance:N2} : {count}"); //Информация о пройденном пути за константу времени и номер шага, о пройденном пути
        }
    }
}
