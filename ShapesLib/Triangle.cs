using System.ComponentModel.DataAnnotations;

namespace ShapesLib
{
	public partial class Triangle : IShapes
    {
        public Side A { get; set; }
		public Side B { get; set; }
		public Side C { get; set; }

		public Triangle(double a, double b, double c)
        {
            if (!IsExist(a,b,c))
            {
                throw new ArgumentOutOfRangeException(nameof(c));
            }
            A = new Side();
            A.Value = a;
            B = new Side();
            B.Value = b;
            C = new Side();
            C.Value = c;
        }

        public bool IsExist(double a, double b, double c)
        {
			return a + b > c && a + c > b && b + c > a;
		}

        public double CalculateArea()
        {
            var p = (A.Value + B.Value + C.Value) / 2;
            var p2 = p * (p - A.Value) * (p - B.Value) * (p - C.Value);
            var result = Math.Sqrt(p2);
            return result;
        }

        public bool IsRightTraingle()
        {
            List<double> temp = new List<double>() { A.Value, B.Value, C.Value };
            var hypotenuse = temp.Max();
            if (hypotenuse == A.Value) return Math.Pow(A.Value, 2) == Math.Pow(B.Value, 2) + Math.Pow(C.Value, 2);
            else if (hypotenuse == B.Value) return Math.Pow(B.Value, 2) == Math.Pow(A.Value, 2) + Math.Pow(C.Value, 2);
            else if (hypotenuse == C.Value) return Math.Pow(C.Value, 2) == Math.Pow(A.Value, 2) + Math.Pow(B.Value, 2);
            else return false;
        }
    }
}
