using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shape.Logic
{
   public class Area:ShapeBase
    {
        public Area(double width)
        {
            Width = width;            
        }

        public override double Perimenter()
        {
            return Width *4;
        }
        public override double Square()
        {
            return Width * Width;
        }

    }
}
