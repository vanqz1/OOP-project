using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace God
{
    public class Human:Animal
    {
         public Human():base()
        { 
        
        }

        public Human(string name):base(name)
        {
        
        }

        public Human(string name,double energy,double power,double size,double weight, Point2D a,State b)
            :base(name, energy, power, size, weight,  a, b)
        {
            
        }

        public void Analyze()
        {
            this.State = State.Analyzing;
        }

        public override string ToString()
        {
            return "Human: " + "Name " + this.Name;
        }
    }
}
