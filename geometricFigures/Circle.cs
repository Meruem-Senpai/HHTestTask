using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace geometricFigures
{
    public class Circle : Figure
    {
        public string Name { get; } = "Circle";

        private double radius;

        public Circle(int radius)
        {
            if (radius <= 0)
                throw new ArgumentException("Argument cannot be zero or less"); 

            this.radius = radius;
        }

        public override double GetArea()
        {
            return Math.PI * this.radius * this.radius;

            Math.Round(this.radius, 3); 
        }


        public override string ToString()
        {
          return $"Name figure: {this.Name}\n " +
                $"Area: {this.GetArea()}";
        }
    }
}
