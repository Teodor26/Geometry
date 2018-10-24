using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shape.Logic
{
   public class Rectangle : ShapeBase
    {
        public Rectangle(double width, double heigth)
        {
            Width = width;
            Heigth = heigth;
        }

        public override double Perimenter()
        {
            return Width * 2 + Heigth * 2;
        }
        public override double Square()
        {
            return Width * Heigth;
        }
    }
}
