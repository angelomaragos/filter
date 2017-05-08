using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UML.Assignment8
{
    class Pnt
    {
       public struct PolarPoint  // struct PolarPoint  aka  PolarCoordinate
        {
            public PolarPoint(double radius, double angle)  //gather radius and angle/degree of polar coordinates
            {
                _angle = angle;
                _radius = radius;

             

            }
            public double _angle;
            public double _radius;
        }

        
        

    }

 
}
