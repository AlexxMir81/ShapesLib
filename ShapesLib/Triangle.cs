using System.ComponentModel.DataAnnotations;

namespace ShapesLib
{
    public class Triangle : IAreaFigure
    {
        private double sideA;
        private double sideB;
        private double sideC;

        public Triangle(double sideA, double sideB, double sideC)
        {
            this.sideA = sideA;
            this.sideB = sideB;
            this.sideC = sideC;
        }
        public double CalculateArea()
        {
            var p = (sideA + sideB + sideC) / 2;
            var p2 = p * (p - sideA) * (p - sideB) * (p - sideC);
            var result = Math.Sqrt(p2);
            return result;
        }

        public bool IsRightTraingle()
        {
            List<double> temp = new List<double>() { sideA, sideB, sideC };
            var hypotenuse = temp.Max();
            if (temp.Max() == sideA) return Math.Pow(sideA, 2) == Math.Pow(sideB, 2) + Math.Pow(sideC, 2);
            else if (temp.Max() == sideB) return Math.Pow(sideB, 2) == Math.Pow(sideA, 2) + Math.Pow(sideC, 2);
            else if (temp.Max() == sideC) return Math.Pow(sideC, 2) == Math.Pow(sideA, 2) + Math.Pow(sideB, 2);
            else return false;
        }
    }
}
