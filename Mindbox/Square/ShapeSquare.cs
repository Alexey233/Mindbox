using System;

namespace Mindbox.Square
{
    public abstract class ShapeSquare : ISquare
    {
        public double Square { get; protected set; }
        public double Calculate()
        { 
            if (Validate())
            {
                CalculateShape();
                return Square;
            }
            return 0;
        }
        
        protected abstract bool Validate();

        protected abstract void CalculateShape();
    }
}
