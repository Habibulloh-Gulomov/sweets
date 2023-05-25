using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sweets_task2
{
    internal class Lasagna
    {
        public int ExpectedMinutesInOven()
        {
            return 40;
        }

        public int RemainingMinutesInOven(int minutes)
        {
            return 40 - minutes;
        }

        public int PreparationTimeInMinutes(int layers)
        {
           int minutes = 0;
           for(int i = 0; i < layers; i++)
            {
                minutes += 2;
            }
           return minutes;
        }

        public  int ElapsedTimeInMinutes(int layers, int minutes)
        {
            var layer = layers * 2;
            var left = 40 - minutes;
            var result = left+layer;
            return result;
        }
    }
}
