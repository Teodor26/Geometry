using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shape.Logic
{
    abstract public class ShapeBase
    {
        public double Width { get; set; }
        public double Heigth { get; set; }       

        public abstract double Perimenter();
        public abstract double Square();

    }
}
