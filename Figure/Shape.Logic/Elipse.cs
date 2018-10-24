using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shape.Logic
{
    public class Elipse:ShapeBase
    {

        public Elipse(double width, double heigth)
        {
            Width = width;
            Heigth = heigth;
        }

        public override double Perimenter()
        {
            return 2 * 3.14 * Width;
        }
        public override double Square()
        {
            return 4*((Width* Heigth*3.14f+(Heigth- Width))/(Width+ Heigth));
        }

    }
}
