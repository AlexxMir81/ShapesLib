using System.ComponentModel.DataAnnotations;

namespace ShapesLib
{
	/// <summary> Треугольник </summary>
	public partial class Triangle : IShapes
    {
		/// <summary>
		/// Сторона треугольника А
		/// </summary>
		public Side A { get; set; }
		/// <summary>
		/// Сторона треугольника B
		/// </summary>
		public Side B { get; set; }
		/// <summary>
		/// Сторона треугольника С
		/// </summary>
		public Side C { get; set; }

		/// <summary>
		/// Конструктор треугольника
		/// </summary>
		/// <param names="a, b, c">Стороны треульника</param>
		/// <exception cref="ArgumentOutOfRangeException"> Если стороны меньше или равны нулю или равны бесконечности или равны NaN </exception>
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

		/// <summary>
		///  Провекра существует ли треугольник с заданными параметрами
		/// </summary>
		public bool IsExist(double a, double b, double c)
        {
			return a + b > c && a + c > b && b + c > a;
		}
		/// <summary>
		///  Площадь треугольника
		/// </summary>
		public double CalculateArea()
        {
            var p = (A.Value + B.Value + C.Value) / 2;
            var p2 = p * (p - A.Value) * (p - B.Value) * (p - C.Value);
            var result = Math.Sqrt(p2);
            return result;
        }

		/// <summary>
		///  Проверка является ли треуголник прямоуголным
		/// </summary>
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
