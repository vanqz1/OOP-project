using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace God
{
    public class God:Human
    {
         public God():base()
        { 
        
        }
         public God(string name)
             : base(name)
         {

         }

        public God(string name,double energy,double power,double size,double weight, Point2D a,State b)
            :base(name, energy, power, size, weight,  a, b)
        {
            
        }

        public void CreatePlanet(string name)
        {
            Planet planet = new Planet(name);
            Scene.AllPlanets.Add(planet);
        }

        public void CreatePlanet(string name,Entity[] citizens)
        {
            Planet planet = new Planet(name,citizens);
            Scene.AllPlanets.Add(planet);

        }

        public void Destroy(Planet name)
        {
            name.Name = "unnamed";
            for (int i = 0; i < name.citizens.Count; i++)
			{
                name.citizens.Remove(name.citizens[i]);
			}
                
            
        }
        
        public void AddCitizen(Planet planet,IEntity citizen)
        {
            
            planet.citizens.Add(citizen);
        }

        public override string ToString()
        {
            return "God: " + "Name " + this.Name;
        }
    }
}
