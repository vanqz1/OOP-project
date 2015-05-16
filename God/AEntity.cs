using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace God
{
    public abstract class AEntity:IEntity
    {
        private static RandomG nameR = new RandomG();
        private string name;
        private double energy;
        private double power;
        private double size;
        private double weight;
        private Point2D point;
        private State state;

        public AEntity()
        {
           this.Name = nameR.RandomName();
            this.Energy = 0;
            this.Power = 0;
            this.Size = 0;
            this.Weight = 0;
            this.Point = new Point2D();
            this.State = State.Unknown;
        }
        public AEntity(string name)
        {
            this.Name = name;
            this.Energy = 0;
            this.Power = 0;
            this.Size = 0;
            this.Weight = 0;
            this.Point = new Point2D();
            this.State = State.Unknown;
        }
        public AEntity(string name,double energy,double power,double size,double weight, Point2D a,State b)
        {
            this.Name = name;
            this.Energy = energy;
            this.Power = power;
            this.Size = size;
            this.Weight = weight;
            this.Point = a;
            this.State = b;
        }
        public string Name 
        {
            get { return this.name; }
            set 
            {
                if(value==null)
                {
                    throw new ArgumentOutOfRangeException("The entity should have name");
                }
                this.name = value;
            }
        }

        public double Energy
        {
            get { return this.energy; }
            set 
            {
                if (value<0)
                {
                    throw new ArgumentOutOfRangeException("The energy should be a positive number");
                } 
                this.energy = value;
            }
        }

        public double Power
        {
            get { return this.power; }
            set 
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("The power should be a positive number");
                } 
                this.power = value;
            }
        }

        public double Size
        {
            get { return this.size; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("The size should be a positive number");
                } 
                this.size = value;
            }
        }

        public double Weight
        {
            get { return this.weight; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("The weight should be a positive number");
                } 
                this.weight = value;
            }
        }

        public Point2D Point
        {
            get
            {
                return this.point;
            }
            set
            {
                 this.point = value;
            }
        
        }

        public State State
        {
            get
            {
                return this.state;
            }
            set
            {
                this.state = value;
            }

        }

        public virtual void Attack(IEntity entityAttacked)
        {
            RandomG rand = new RandomG();
            double r = rand.RandomNumbers(10, 20);
            if ((entityAttacked.Energy - r) >= 0)
            {
                entityAttacked.Energy -= r;
                this.State = State.Attacking;
            }
            else
            {
                Console.WriteLine("{0} is killed", entityAttacked.Name);
                for (int i = 0; i < Scene.AllPlanets.Count(); i++)
                {
                    for (int k = 0; k < Scene.AllPlanets[i].citizens.Count(); k++)
                    {
                        if (Scene.AllPlanets[i].citizens[k]==entityAttacked)
                        {
                            Scene.AllPlanets[i].citizens[k] = null;

                        }
                        
                    }
                    
                }
            }
        }

        public virtual void Move(Point2D a)
        {
            this.Point = a;
            this.State = State.Moving;
        }

        public virtual void DoAction(AEntity entityAttacked)
        {
            this.Attack(entityAttacked);
        }
        
        public override string ToString()
        {
            return "Entity: "+"Name "+this.Name;
        }

    }
}
