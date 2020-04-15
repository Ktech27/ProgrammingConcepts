using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesAndMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            Car myCar = new Car();

            myCar.Height = 45;            

            string result = myCar.turnEngineOff();
            Console.WriteLine(result);
            result = myCar.turnEngineOn();
            Console.WriteLine(result);
            result = myCar.turnEngineOn();
            Console.WriteLine(result);
            result = myCar.turnEngineOff();
            Console.WriteLine(result);

            Console.ReadLine();

        }
    }     
}
