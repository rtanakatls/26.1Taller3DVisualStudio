using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taller3D261
{
    internal class Circle : Shape
    {
        protected float r;
        private float pi = 3.14f;

        public Circle(string name, float r) : base(name)
        {
            this.r = r;
        }

        public override float GetArea()
        {
            return pi * r * r;
        }
    }
}
