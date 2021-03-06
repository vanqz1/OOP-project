﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace God
{
    public class Animal:AEntity
    {
         public Animal():base()
        { 
        
        }

        public Animal(string name,double energy,double power,double size,double weight, Point2D a,State b)
            :base(name, energy, power, size, weight,  a, b)
        {
            
        }

        public Animal(string name):base(name)
        {
        
        }

        public void Eat()
        {
            RandomG food=new RandomG();
            this.State = State.Eating;
            this.Weight += food.RandomNumbers(1,5);
        }

        public void SearchingForFood()
        {
            this.State = State.SearchingForFood;
            RandomG food = new RandomG();
            this.Energy -= food.RandomNumbers(0,20);

        }

        public void Sleep()
        {
            this.State = State.Sleeping;
            RandomG food = new RandomG();
            this.Energy += food.RandomNumbers(100,120);
        }

        public override void DoAction(AEntity entityAttacked)
        {
            RandomG num=new RandomG();
            double nextNum=num.RandomNumbers(-100,200);
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
            else
            {
                this.State = State.Moving;

            }

        }

        public override string ToString()
        {
            return "Animal: " + "Name " + this.Name;
        }
    }
}
