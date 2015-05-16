using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace God
{
    public static class CommandManager
    {
        public static void Read()
        {
            string command = Console.ReadLine();

           string [] commands=command.Split(' ');

            switch(commands[0])
            {
                case "add":
                    ///Add Planet syntax: <add>|<name_of_new_planet>
                   
                    
                    if(commands.Length==3 && commands[1]=="planet")
                    {
                        Planet m = new Planet(commands[2]);
                        Scene.AllPlanets.Add(m);
                        Console.WriteLine("You add planet:{0}", Scene.AllPlanets.ElementAt(Scene.AllPlanets.Count-1).Name);
                    }
                    ///Add entity of specific type and specific numbers of that kind of entity
                    ///syntax:<add> <name_planet> <entity|animal|human|god> <number_of_creatures>, 
                    if(commands.Length==4)
                    {
                       for (int i = 0; i < Scene.AllPlanets.Count(); i++)
			           {
                           
                           if(Scene.AllPlanets[i].Name==commands[1])
                            {
                               int m= int.Parse(commands[3]);
                               EntityType type = (EntityType) Enum.Parse(typeof(EntityType), commands[2]);
                                for (int k = 0; k < m; k++)
                                {
                                    Scene.CreateEntity(type,Scene.AllPlanets[i]);
                                }
                             }
                       
                         }
                        Console.WriteLine("You add to planet:{0},{1} {2}", commands[1], commands[3], commands[2]);
                     }
                    break;

                ///Kill creatures of the planet syntax:<kill>|<name_planet>
                case "kill":
                     foreach (Planet it in Scene.AllPlanets)
                      {
                          if(it.Name==commands[1])
                          {
                              it.citizens.Clear(); 
                          }
                          
                      }
                     Console.WriteLine("You kill creatures of planet:{0}", commands[1]);
                    break;

               ///destroy entire planet syntax: <destry>|<name_planet>
                case "destroy":
                    for (int i = 0; i < Scene.AllPlanets.Count; i++)
                    {
                        if(Scene.AllPlanets[i].Name==commands[1])
                        {
                            Scene.AllPlanets.RemoveAt(i);
                        }
                       
                    }
                    Console.WriteLine("You destroyed planet:{0}", commands[1]);
                      
                    break;
                /// statistic syntax: <statistic>
                case "statistic":
                    if (Scene.AllPlanets.Count != 0)
                    {
                        Console.WriteLine(Scene.AllPlanets.Count());
                        foreach (var planet in Scene.AllPlanets)
                        {
                            
                            Console.WriteLine(planet);
                            foreach (var cit in planet.citizens)
                            {
                                Console.WriteLine(cit);
                            }
                        }
                    }
                    else
                    {
                        Console.WriteLine("there is not planets created");
                    }
                    break;
             }

            CommandManager.Read();
        
        }

    }
}
