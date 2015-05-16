using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
namespace God
{
    public class RandomG
    {
        private Random roller = new Random();

        private Random d = new Random();
        public  double RandomNumbers(int minimum,int maximum)
        {
            int m = d.Next(minimum,maximum);
            double toHit = roller.NextDouble();
            return toHit+m;
;
        }

        public string RandomName()
        {
            StringBuilder builder = new StringBuilder();
            
            char ch;
            for (int i = 0; i <4; i++)
            {
                ch = Convert.ToChar(Convert.ToInt32(Math.Floor(26 * this.roller.NextDouble() + 65)));
                builder.Append(ch);
            }
            
            return builder.ToString();
        } 

    }
}
