using System;

namespace Mindbox.Square
{
    public abstract class ShapeSquare : ISquare
    {
        public double Square { get; protected set; }

        public bool IsValid { get; protected set; }

        public double Calculate()
        {
            Validate();

            if (IsValid)
            {
                CalculateShape();
                return Square;
            }
            return 0;
        }
        
        protected abstract void Validate();

        protected abstract void CalculateShape();
    }
}
