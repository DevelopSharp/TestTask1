using System;

namespace ClassLibrary1
{
    public class Class1
    {
        public void MyTestMethod()
        {
            var calc = new Calc();
            var c = new Circle();
            c.Radius = 5;
            calc.CalcAreaSpace(c);

            var t = new Triangle();
            t.A = 2;
            t.B = 3;
            t.C = 4;
            calc.CalcAreaSpace(t);
            t.IsRightAngled();
        }

        public class Calc
        {
            public double CalcAreaSpace(Shape shape)
            {
                if (shape != null)
                    return shape.CalcAreaSpace();

                return 0;
            }
        }

        public abstract class Shape
        {
            public abstract double CalcAreaSpace();
        }

        public class Triangle : Shape
        {
            public double A;
            public double B;
            public double C;
            public override double CalcAreaSpace()
            {
                double P = (A + B + C) / 2;
                var S = Math.Sqrt(P * (P - A) * (P - B) * (P - C));
                return S;
            }

            public bool IsRightAngled()
            {
                if ((A * A + B * B == C * C) || (A * A + C * C == B * B) || (C * C + B * B == A * A))
                    return true;
                else return false;
            }
        }

        public class Circle : Shape
        {
            public double Radius;
            public double Pi = 3.14;
            public override double CalcAreaSpace()
            {
                var area = Pi * (Radius * Radius);
                return area;
            }
        }


    }
}
