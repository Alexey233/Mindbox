namespace Mindbox.Square
{
    public class TriangleSquare : ShapeSquare
    {
        public double A { get; init; }
        public double B { get; init; }
        public double C { get; init; }

        public TriangleSquare(double a, double b, double c)
        {
            A = a;
            B = b;
            C = c;
        }

        protected override bool Validate()
        {
            if (A >= 0
                && B >= 0
                && C >= 0
                && (A > (B + C)
                && A > (B + C)
                && C > (A + B))) return true;

            else return false;
        }

        protected override void CalculateShape()
        {
            double perimeter = (A + B + C) / 2;
            Square = Math.Round(Math.Sqrt(perimeter * (perimeter - A) * (perimeter - B) * (perimeter - C)), 1);
        }
        public bool IsRectangular()
        {
            bool check = false;
            if ((A * A + B * B == C * C)
                || (A * A + C * C == B * B)
                || (C * C + B * B == A * A))
            {
                check = true;
            }


            return check;
        }

    }
}
