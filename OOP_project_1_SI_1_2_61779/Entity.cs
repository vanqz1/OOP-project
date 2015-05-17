using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace God
{
    public class Entity:AEntity 
    {
        public Entity():base()
        { 
        
        }
        public Entity(string name):base(name)
        {
        
        }

        public Entity(string name,double energy,double power,double size,double weight, Point2D a,State b)
            :base(name, energy, power, size, weight,  a, b)
        {
            
        }
        
        
    }
}
