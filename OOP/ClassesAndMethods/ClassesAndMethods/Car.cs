using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesAndMethods
{
    //Accesibility modifier, keywork class , Class name
    public class Car
    {
        //Class members

        //Properties
        public string Color { get; set; }
        public int Length { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }



        //Field
        public bool isEngineOn;

        public string turnEngineOn()
        {
            if (isEngineOn == true)
            {
                return "Engine is already on";
            }
            //if(isEngineOn == false)Creates error
            else //this is the  when isEngineOn is false
            {
                isEngineOn = true;
                return "Engine is on";
            }
        }

        public string turnEngineOff()
        {
            if (isEngineOn == true)
            {
                isEngineOn = false;
                return "Engine is off";
            }
            else
            {
                return "Engine is already off";
            }
        }

    }
}
