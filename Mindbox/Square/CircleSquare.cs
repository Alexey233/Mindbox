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

        protected override void Validate()
        {
            IsValid = Radius >= 0;
        }

        protected override void CalculateShape()
        {
            Square = Math.PI * Radius * Radius;
        }
    }
}
