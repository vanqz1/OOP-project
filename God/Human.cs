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
        public override void DoAction(AEntity entityAttacked)
        {
            RandomG num = new RandomG();
            double nextNum = num.RandomNumbers(-100, 200);
            if (nextNum < -50)
            {
                this.State = State.Attacking;
            }
            else if (nextNum >= -50 && nextNum < 0)
            {
                this.State = State.Sleeping;
            }
            else if (nextNum >= 0 && nextNum < 50)
            {
                this.State = State.Sleeping;
            }
            else if (nextNum >= 50 && nextNum < 100)
            {

                this.State = State.SearchingForFood;
            }
            else if (nextNum >= 100 && nextNum < 150)
            {
                this.State = State.Moving;

            }
            else
            {
                this.State = State.Analyzing;
            }

        }

        public override string ToString()
        {
            return "Human: " + "Name " + this.Name;
        }
    }
}
