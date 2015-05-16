using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace God
{
    public interface IEntity
    {
        Point2D Point{get;set;}

       string Name{get;set;}

       double Energy { get; set; }

       double Power { get; set; }

       double Size { get; set; }

       double Weight { get; set; }

       State State { get; set; }
        
        void Attack(IEntity entityAttacked);

        void Move(Point2D a);

        void DoAction(AEntity entityAttacked);
    }
}
