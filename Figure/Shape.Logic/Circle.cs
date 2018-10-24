using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shape.Logic
{
   
        public class Circle : ShapeBase
        {
            public Circle(double width)
            {
                Width = width;
            }

            public override double Perimenter()
            {
                return 2*3.14*Width;
            }
            public override double Square()
            {
                return 3.14* Width* Width;
            }

        }
}

