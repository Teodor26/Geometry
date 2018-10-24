using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shape.Logic
{
    public class Triangle:ShapeBase
    {
        public Triangle(double width, double heigth)
        {
            Width = width;
            Heigth = heigth;
        }

        public override double Perimenter()
        {
            double NewSide=Math.Sqrt(Math.Pow(Width, 2) * Math.Pow(Heigth, 2));
            return  Width + Heigth + NewSide;
        }
        public override double Square()
        {
            double NewSide = Math.Sqrt(Math.Pow(Width, 2) * Math.Pow(Heigth, 2));
            return (Width + Heigth) / 2;
        }

    }
}
