using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taller3D261
{
    internal class Triangle : Shape
    {
        protected float b;
        protected float h;

        public float B { get { return b; } }

        public Triangle(string name, float b, float h) : base(name)
        {
            this.b = b;
            this.h = h;
        }

        public override float GetArea()
        {
            return b * h / 2;
        }
    }
}
