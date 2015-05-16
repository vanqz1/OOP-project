using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace God
{
    public class Planet
    {
        protected string name;
        protected int numCitizens;
        public List<IEntity> citizens;
        public Planet(string name1)
        { 
        this.Name=name1;
        this.citizens = new List<IEntity>();
        }

        public Planet(string name1,IEntity[] cits)
        {
            this.Name = name1;
            foreach (var cit in cits)
            {
                citizens.Add(cit);
            }
            
        }

        public string Name
        {
            get;
            set;
        }

        protected int NumCitizens
        {
            get { return this.numCitizens; }
            set
            {
                if (value <0)
                {
                    throw new ArgumentOutOfRangeException("The number of citizens is a positive number");
                }
                this.numCitizens = value;
            }

        }

        public void AddCitizen(IEntity m)
        {
           citizens.Add(m);
        }

        public override string ToString()
        {
            return "Planet:"+this.Name;
        }

        
        
       

    }
}
