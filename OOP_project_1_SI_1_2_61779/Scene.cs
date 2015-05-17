using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace God
{
    public static class Scene
    {
        public static List<Planet> AllPlanets=new List<Planet>();
        private static RandomG name=new RandomG(); 

        public static void CreateEntity(EntityType creature,Planet planet)
        {
          switch(creature)
          {
                
              case EntityType.animal:
                  
                  Animal p = new Animal(name.RandomName());
                  planet.AddCitizen(p);
                  break;

              case EntityType.entity:
                  Entity q = new Entity(name.RandomName());
                  planet.AddCitizen(q);
                  break;

              case EntityType.god:
                  God r = new God(name.RandomName());
                  planet.AddCitizen(r);
                  break;

              case EntityType.human:
                  Human s = new Human(name.RandomName());
                  planet.AddCitizen(s);
                  break;

              case EntityType.unknown:
                  Entity d = new Entity(name.RandomName());
                  planet.AddCitizen(d);
                  break;
              default:
                  throw new ArgumentOutOfRangeException("there is no that kond of creature");
                  break;

          
          }
        
        }
    }
}
