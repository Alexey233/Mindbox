using System;

namespace Mindbox.Square
{
    public class CircleSquare : ShapeSquare
    {
        public double Radius { get; init; }
        public CircleSquare(double radius)
        {
            Radius = radius;
        }

        protected override bool Validate()
        {
            if (Radius >= 0) return true;
            else return false;
        }

        protected override void CalculateShape()
        {
            Square = Math.PI * Radius * Radius;
        }
    }
}
